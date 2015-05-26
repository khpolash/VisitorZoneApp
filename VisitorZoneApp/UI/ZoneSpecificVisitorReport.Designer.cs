namespace VisitorZoneApp.UI
{
    partial class ZoneSpecificVisitorReport
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
            this.searchButton = new System.Windows.Forms.Button();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visitorZoneSpecificListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalVisitroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(465, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(199, 20);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(253, 21);
            this.zoneComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Zone";
            // 
            // visitorZoneSpecificListView
            // 
            this.visitorZoneSpecificListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.visitorZoneSpecificListView.FullRowSelect = true;
            this.visitorZoneSpecificListView.GridLines = true;
            this.visitorZoneSpecificListView.Location = new System.Drawing.Point(21, 64);
            this.visitorZoneSpecificListView.Name = "visitorZoneSpecificListView";
            this.visitorZoneSpecificListView.Size = new System.Drawing.Size(674, 301);
            this.visitorZoneSpecificListView.TabIndex = 3;
            this.visitorZoneSpecificListView.UseCompatibleStateImageBehavior = false;
            this.visitorZoneSpecificListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Visitor Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 241;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 158;
            // 
            // totalVisitroTextBox
            // 
            this.totalVisitroTextBox.Location = new System.Drawing.Point(546, 384);
            this.totalVisitroTextBox.Name = "totalVisitroTextBox";
            this.totalVisitroTextBox.ReadOnly = true;
            this.totalVisitroTextBox.Size = new System.Drawing.Size(149, 20);
            this.totalVisitroTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Visitor";
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(546, 417);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(149, 23);
            this.exportToExcelButton.TabIndex = 0;
            this.exportToExcelButton.Text = "Export to Excel";
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // ZoneSpecificVisitorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 452);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalVisitroTextBox);
            this.Controls.Add(this.visitorZoneSpecificListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.searchButton);
            this.Name = "ZoneSpecificVisitorReport";
            this.ShowIcon = false;
            this.Text = "Zone Specific Visitor Information Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView visitorZoneSpecificListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox totalVisitroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportToExcelButton;
    }
}