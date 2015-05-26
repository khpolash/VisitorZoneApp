using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;
using VisitorZoneApp.DAL.Gateway;

namespace VisitorZoneApp.UI
{
    public partial class ZoneSpecificVisitorReport : Form
    {
       VisitorManager visitorManager = new VisitorManager();
        Zone anZone = new Zone();
        Visitor aVisitor = new Visitor();

        public ZoneSpecificVisitorReport()
        {
            InitializeComponent();
            LoadZoneIntoZoneComboBox();
        }

        public void LoadZoneIntoZoneComboBox()
        {
            zoneComboBox.DataSource = visitorManager.GetAllZone();
            zoneComboBox.ValueMember = "Id";
            zoneComboBox.DisplayMember = "Name";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            visitorZoneSpecificListView.Items.Clear();
            Zone zone = (Zone) zoneComboBox.SelectedItem;
            int zoneId = zone.Id;
            List<Visitor> visitorList = visitorManager.GetAllVisitorByZone(zoneId);
            int serial = 1;
            int totalVisitor = 0;
            foreach (var visitor in visitorList)
            {
                ListViewItem item = new ListViewItem(serial.ToString());
                item.SubItems.Add(visitor.Name);
                item.SubItems.Add(visitor.Email);
                item.SubItems.Add(visitor.Phone);
                visitorZoneSpecificListView.Items.Add(item);
                serial++;
                totalVisitor++;

            }
            totalVisitroTextBox.Text = totalVisitor.ToString();
        }

    }
}
