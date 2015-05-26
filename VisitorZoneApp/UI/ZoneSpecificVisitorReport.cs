using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.UI
{
    public partial class ZoneSpecificVisitorReport : Form
    {
       VisitorManager visitorManager = new VisitorManager();
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

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            if (visitorZoneSpecificListView.Items.Count > 0)
            {
                
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                app.Columns.ColumnWidth= 12;
                int i;
                int j = 1;
                foreach (ListViewItem item in visitorZoneSpecificListView.Items)
                {
                    i = 1;
                    foreach (ListViewItem.ListViewSubItem items in item.SubItems)
                    {
                        ws.Cells[j, i] = items.Text;
                        i++;
                    }
                    j++;
                }
            }
            else
            {
                MessageBox.Show(@"Document is Empty!",@"Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            
        }

    }
}
