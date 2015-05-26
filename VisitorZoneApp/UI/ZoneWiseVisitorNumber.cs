using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;
using Zone = VisitorZoneApp.DAL.DAO.Zone;

namespace VisitorZoneApp.UI
{
    public partial class ZoneWiseVisitorNumber : Form
    {
        public ZoneWiseVisitorNumber()
        {
            InitializeComponent();
            LoadView();
        }
        ZoneManager zoneManager = new ZoneManager();
        VisitorManager visitorManager = new VisitorManager();
        public void LoadView()
        {
            double numberofVisitor = 0;
            double totalVisitor = 0;

            List<Zone> zoneList = zoneManager.GetAllZone();
            int serial = 1;
            foreach (var zone in zoneList)
            {
                List<Visitor> visitorList = visitorManager.GetAllVisitorByZone(zone.Id);
                foreach (var visitor in visitorList)
                {
                    if (visitor!=null)
                    {
                        numberofVisitor++;
                    }
                }

                ListViewItem item = new ListViewItem(serial.ToString());
                item.SubItems.Add(zone.Name);
                item.SubItems.Add(numberofVisitor.ToString());

                zoneWiseVisitorListView.Items.Add(item);
                serial++;
                totalVisitor += numberofVisitor;
                numberofVisitor = 0;
            }
            
            overAllVisitorTextBox.Text = totalVisitor.ToString();
        }
    }
}
