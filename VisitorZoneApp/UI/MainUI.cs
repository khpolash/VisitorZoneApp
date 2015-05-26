using System;
using System.Windows.Forms;

namespace VisitorZoneApp.UI
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
            ShowMessage();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            VisitorEntryUi visitorEntry = new VisitorEntryUi();
            visitorEntry.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           ZoneEntryUi aZoneEntryUi = new ZoneEntryUi();
           aZoneEntryUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Are you want to Exit ", @"Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void zoneToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneSpecificVisitorReport zoneSpecificVisitorReport= new ZoneSpecificVisitorReport();
            zoneSpecificVisitorReport.Show();
        }

        private void zoneSpecificVisitorNumberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneWiseVisitorNumber zoneWiseVisitorNumber = new ZoneWiseVisitorNumber();
            zoneWiseVisitorNumber.Show();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            timeShowLabel.Text = DateTime.Now.ToLongTimeString();
            dateShowLabel.Text = DateTime.Now.ToLongDateString();
        }

        public void ShowMessage()
        {
            messageLabel.Text = @"Group Name: Dew Drop" + "\n\n" + "1.Md. Ashikur Rahman\nSEID-100565\n\n2.Md. Kamrul Hasan\nSEID-103247\n\n3.Md. Salman Sabbir\nSEID-103486\n\n4.Nazmul Hasan Rupam\nSEID-103633\n";
        }
    }
}
