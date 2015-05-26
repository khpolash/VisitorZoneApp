namespace VisitorZoneApp.UI
{
    partial class MainUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUi));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoneSpecificVisitorNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateShowLabel = new System.Windows.Forms.Label();
            this.timeShowLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.messageLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 29);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorEntryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // visitorEntryToolStripMenuItem
            // 
            this.visitorEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitorEntryToolStripMenuItem.Image")));
            this.visitorEntryToolStripMenuItem.Name = "visitorEntryToolStripMenuItem";
            this.visitorEntryToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.visitorEntryToolStripMenuItem.Text = "Visitor Entry";
            this.visitorEntryToolStripMenuItem.Click += new System.EventHandler(this.visitorEntryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneTypeToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // zoneTypeToolStripMenuItem
            // 
            this.zoneTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneTypeToolStripMenuItem.Image")));
            this.zoneTypeToolStripMenuItem.Name = "zoneTypeToolStripMenuItem";
            this.zoneTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.zoneTypeToolStripMenuItem.Text = "Zone Type";
            this.zoneTypeToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneToolStripMenuItem,
            this.toolStripSeparator2,
            this.zoneSpecificVisitorNumberToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // zoneToolStripMenuItem
            // 
            this.zoneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneToolStripMenuItem.Image")));
            this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            this.zoneToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.zoneToolStripMenuItem.Text = "Zone Specific Visitor Details";
            this.zoneToolStripMenuItem.Click += new System.EventHandler(this.zoneToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // zoneSpecificVisitorNumberToolStripMenuItem
            // 
            this.zoneSpecificVisitorNumberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneSpecificVisitorNumberToolStripMenuItem.Image")));
            this.zoneSpecificVisitorNumberToolStripMenuItem.Name = "zoneSpecificVisitorNumberToolStripMenuItem";
            this.zoneSpecificVisitorNumberToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.zoneSpecificVisitorNumberToolStripMenuItem.Text = "Zone Wise Visitor Number";
            this.zoneSpecificVisitorNumberToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificVisitorNumberToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateShowLabel);
            this.panel1.Controls.Add(this.timeShowLabel);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(496, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 249);
            this.panel1.TabIndex = 1;
            // 
            // dateShowLabel
            // 
            this.dateShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateShowLabel.Location = new System.Drawing.Point(19, 36);
            this.dateShowLabel.Name = "dateShowLabel";
            this.dateShowLabel.Size = new System.Drawing.Size(230, 23);
            this.dateShowLabel.TabIndex = 2;
            this.dateShowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeShowLabel
            // 
            this.timeShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeShowLabel.Location = new System.Drawing.Point(19, 13);
            this.timeShowLabel.Name = "timeShowLabel";
            this.timeShowLabel.Size = new System.Drawing.Size(230, 23);
            this.timeShowLabel.TabIndex = 1;
            this.timeShowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CausesValidation = false;
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Friday;
            this.monthCalendar1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.monthCalendar1.Location = new System.Drawing.Point(16, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.DarkGreen;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.SeaGreen;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // messageLabel
            // 
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Location = new System.Drawing.Point(12, 187);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Padding = new System.Windows.Forms.Padding(20, 20, 10, 10);
            this.messageLabel.Size = new System.Drawing.Size(234, 252);
            this.messageLabel.TabIndex = 2;
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainUi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main AREA UI";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificVisitorNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dateShowLabel;
        private System.Windows.Forms.Label timeShowLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label messageLabel;

    }
}

