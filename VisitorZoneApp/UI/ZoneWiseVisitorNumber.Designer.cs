namespace VisitorZoneApp.UI
{
    partial class ZoneWiseVisitorNumber
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
            this.zoneWiseVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.overAllVisitorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zoneWiseVisitorListView
            // 
            this.zoneWiseVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.zoneWiseVisitorListView.GridLines = true;
            this.zoneWiseVisitorListView.Location = new System.Drawing.Point(43, 48);
            this.zoneWiseVisitorListView.Name = "zoneWiseVisitorListView";
            this.zoneWiseVisitorListView.Size = new System.Drawing.Size(492, 258);
            this.zoneWiseVisitorListView.TabIndex = 0;
            this.zoneWiseVisitorListView.UseCompatibleStateImageBehavior = false;
            this.zoneWiseVisitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Name";
            this.columnHeader2.Width = 295;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Visitor";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 126;
            // 
            // overAllVisitorTextBox
            // 
            this.overAllVisitorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overAllVisitorTextBox.Location = new System.Drawing.Point(406, 324);
            this.overAllVisitorTextBox.Name = "overAllVisitorTextBox";
            this.overAllVisitorTextBox.ReadOnly = true;
            this.overAllVisitorTextBox.Size = new System.Drawing.Size(129, 22);
            this.overAllVisitorTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Over All Visitor ";
            // 
            // ZoneWiseVisitorNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.overAllVisitorTextBox);
            this.Controls.Add(this.zoneWiseVisitorListView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 435);
            this.MinimumSize = new System.Drawing.Size(600, 435);
            this.Name = "ZoneWiseVisitorNumber";
            this.ShowIcon = false;
            this.Text = "Zone Wise Visitor Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneWiseVisitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox overAllVisitorTextBox;
        private System.Windows.Forms.Label label1;
    }
}