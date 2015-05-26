using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;
using VisitorZoneApp.DAL.Gateway;

namespace VisitorZoneApp.BLL
{
    class VisitorManager
    {
        VisitorGateway visitorGateway = new VisitorGateway();
        ZoneGateway zoneGateway = new ZoneGateway();
        public string SaveVesitorWithZone(Visitor newVisitor, List<Zone> zoneListforSave)
        {
            if (visitorGateway.HasThisEmailExists(newVisitor.Email))
            {
                return "Email already exists!";
            }
            else
            {
                if (visitorGateway.SaveVesitorWithZone(newVisitor, zoneListforSave))
                {
                    return "Successfully Saved";
                }
                else
                {
                    return "Save Failed!";
                }
            }
        }

        public List<Zone> GetAllZone()
        {
            return zoneGateway.GetAllZone();
        }


        public List<Visitor> GetAllVisitorByZone(int zoneId)
        {
            return visitorGateway.GetVisitorbyZoneId(zoneId);
        }
    }
}
