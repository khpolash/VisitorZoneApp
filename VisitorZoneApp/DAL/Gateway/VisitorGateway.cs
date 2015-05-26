using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.DAL.Gateway
{
    class VisitorGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public VisitorGateway()
        {
            connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["VisitorZoneDB"].ConnectionString);
            commandObj = new SqlCommand();
            commandObj.Connection = connectionObj;
        }
        public bool HasThisEmailExists(string email)
        {
            string select = string.Format("SELECT * FROM tbl_visitor WHERE email = '"+email+"'");
            connectionObj.Open();
            commandObj.CommandText = select;
            SqlDataReader reader = commandObj.ExecuteReader();
            bool zoneStatus = reader.HasRows;
            reader.Close();
            connectionObj.Close();
            return zoneStatus;
        }

        public bool SaveVesitorWithZone(Visitor newVisitor, List<Zone> zoneListforSave)
        {
            string insert = String.Format("INSERT INTO tbl_visitor VALUES('{0}','{1}','{2}')", newVisitor.Name, newVisitor.Email, newVisitor.Phone);
            connectionObj.Open();
            commandObj.CommandText = insert;
            int rowAffected = commandObj.ExecuteNonQuery();
            connectionObj.Close();
            if (SaveVisitorandZoneinJointTable(newVisitor.Email, zoneListforSave)&& rowAffected>0)
            {
                return true;
            }
            return false;
        }

        private bool SaveVisitorandZoneinJointTable(string email, List<Zone> zoneListforSave)
        {
            int id = GetVisitorId(email);
            int saveZone = 0;
            foreach (var zone in zoneListforSave)
            {
                string insert = String.Format("INSERT INTO tbl_joint_visitor_zone VALUES({0},{1})", id, zone.Id);
                connectionObj.Open();
                commandObj.CommandText = insert;
                saveZone =+ commandObj.ExecuteNonQuery();
                connectionObj.Close();
            }
            if (saveZone>0)
            {
                return true;
            }
            return false;
        }

        private int GetVisitorId(string email)
        {
            connectionObj.Open();
            string query = string.Format("SELECT * FROM tbl_visitor WHERE email='{0}'", email);
            commandObj.CommandText = query;
            SqlDataReader aReader = commandObj.ExecuteReader();
            Visitor visitor = new Visitor();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    visitor.Id = (int)aReader[0];
                }
            }
            aReader.Close();
            connectionObj.Close();
            return visitor.Id;
        }

        public List<Visitor> GetVisitorbyZoneId(int zoneId)
        {
            connectionObj.Open();
            string query = string.Format("SELECT * FROM tbl_joint_visitor_zone WHERE zoneid={0}", zoneId);
            commandObj.CommandText = query;
            SqlDataReader reader = commandObj.ExecuteReader();
            List<int> visitorIdList = new List<int>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["visitorid"];
                    visitorIdList.Add(id);
                }
            }
            reader.Close();
            connectionObj.Close();

            List<Visitor> visitorsList = GetVisitorList(visitorIdList);
            return visitorsList;
        }

        private List<Visitor> GetVisitorList(List<int> visitorIdList)
        {
            List<Visitor> visitorsList = new List<Visitor>();
            foreach (var visitorId in visitorIdList)
            {
                connectionObj.Open();
                string query = string.Format("SELECT * FROM tbl_visitor WHERE id={0}", visitorId);
                commandObj.CommandText = query;
                SqlDataReader reader = commandObj.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Visitor aVisitor = new Visitor();
                        aVisitor.Id = (int)reader[0];
                        aVisitor.Name = reader[1].ToString();
                        aVisitor.Email = reader[2].ToString();
                        aVisitor.Phone = reader[3].ToString();

                        visitorsList.Add(aVisitor);
                    }
                }
                reader.Close();
                connectionObj.Close();
            }
            return visitorsList;

        }

    }
}
