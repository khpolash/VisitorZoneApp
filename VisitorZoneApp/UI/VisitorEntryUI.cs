using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.UI
{
    public partial class VisitorEntryUi : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        private List<Zone> zoneList;
        public VisitorEntryUi()
        {
            InitializeComponent();
            
        }

        VisitorManager visitorManager = new VisitorManager();
      

        private void VisitorEntryUi_Load(object sender, EventArgs e)
        {
            zoneList = zoneManager.GetAllZone();
            zoneTypeCheckedListBox.Items.Clear();
            foreach (var zone in zoneList)
            {
                var item = zoneTypeCheckedListBox.Items;
                item.Add(zone.Name,true);

                //if (zoneTypeCheckedListBox.CheckOnClick)
                //{
                //    MessageBox.Show(zone.Name+zone.Id);
                //}
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Visitor newVisitor = new Visitor();
            newVisitor.Name = nameTextBox.Text;
            newVisitor.Email = emailTextBox.Text;
            newVisitor.Phone = contactNumberTextBox.Text;

            if (newVisitor.Name!=""&&newVisitor.Email!=""&&newVisitor.Phone!="")
            {
                List<Zone> zoneListFroSave = new List<Zone>();
                foreach (var zone in zoneList)
                {
                    foreach (string itemChecked in zoneTypeCheckedListBox.CheckedItems)
                    {
                        if (itemChecked == zone.Name)
                        {
                            zoneListFroSave.Add(zone);
                        }
                        
                    }

                }

                string message = visitorManager.SaveVesitorWithZone(newVisitor, zoneListFroSave);
                MessageBox.Show(message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
            }
            else
            {
                MessageBox.Show(@"Fill up required",@"Erroe",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        public void ClearField()
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            contactNumberTextBox.Clear();
        }

   }
}
