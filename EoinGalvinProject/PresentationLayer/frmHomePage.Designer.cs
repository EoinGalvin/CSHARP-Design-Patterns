namespace RestaurantSystem.PresentationLayer
{
    partial class frmHomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailabilityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyStationAnalysisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationsToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stationsToolStripMenuItem
            // 
            this.stationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStationMenuItem,
            this.updateStationMenuItem,
            this.deleteStationMenuItem,
            this.checkAvailabilityMenuItem});
            this.stationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stationsToolStripMenuItem.Name = "stationsToolStripMenuItem";
            this.stationsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.stationsToolStripMenuItem.Text = "Stations";
            this.stationsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.stationsToolStripMenuItem_DropDownClosed);
            this.stationsToolStripMenuItem.Click += new System.EventHandler(this.stationsToolStripMenuItem_Click);
            // 
            // addStationMenuItem
            // 
            this.addStationMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.addStationMenuItem.ForeColor = System.Drawing.Color.White;
            this.addStationMenuItem.Name = "addStationMenuItem";
            this.addStationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStationMenuItem.Text = "Add Station";
            this.addStationMenuItem.Click += new System.EventHandler(this.addStationMenuItem_Click);
            // 
            // updateStationMenuItem
            // 
            this.updateStationMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.updateStationMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateStationMenuItem.Name = "updateStationMenuItem";
            this.updateStationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateStationMenuItem.Text = "Update Station";
            this.updateStationMenuItem.Click += new System.EventHandler(this.updateStationMenuItem_Click);
            // 
            // deleteStationMenuItem
            // 
            this.deleteStationMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteStationMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteStationMenuItem.Name = "deleteStationMenuItem";
            this.deleteStationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteStationMenuItem.Text = "Delete Station";
            this.deleteStationMenuItem.Click += new System.EventHandler(this.deleteStationMenuItem_Click);
            // 
            // checkAvailabilityMenuItem
            // 
            this.checkAvailabilityMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.checkAvailabilityMenuItem.ForeColor = System.Drawing.Color.White;
            this.checkAvailabilityMenuItem.Name = "checkAvailabilityMenuItem";
            this.checkAvailabilityMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkAvailabilityMenuItem.Text = "Check Availability";
            this.checkAvailabilityMenuItem.Click += new System.EventHandler(this.checkAvailabilityMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationMenuItem,
            this.cancelReservationMenuItem,
            this.checkinMenuItem,
            this.checkoutMenuItem});
            this.reservationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.DropDownClosed += new System.EventHandler(this.reservationToolStripMenuItem_DropDownClosed);
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // addReservationMenuItem
            // 
            this.addReservationMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.addReservationMenuItem.ForeColor = System.Drawing.Color.White;
            this.addReservationMenuItem.Name = "addReservationMenuItem";
            this.addReservationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addReservationMenuItem.Text = "Add Reservation";
            this.addReservationMenuItem.Click += new System.EventHandler(this.addReservationMenuItem_Click);
            // 
            // cancelReservationMenuItem
            // 
            this.cancelReservationMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.cancelReservationMenuItem.ForeColor = System.Drawing.Color.White;
            this.cancelReservationMenuItem.Name = "cancelReservationMenuItem";
            this.cancelReservationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelReservationMenuItem.Text = "Cancel Reservation";
            this.cancelReservationMenuItem.Click += new System.EventHandler(this.cancelReservationMenuItem_Click);
            // 
            // checkinMenuItem
            // 
            this.checkinMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.checkinMenuItem.ForeColor = System.Drawing.Color.White;
            this.checkinMenuItem.Name = "checkinMenuItem";
            this.checkinMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkinMenuItem.Text = "Check-in";
            this.checkinMenuItem.Click += new System.EventHandler(this.checkinMenuItem_Click);
            // 
            // checkoutMenuItem
            // 
            this.checkoutMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.checkoutMenuItem.ForeColor = System.Drawing.Color.White;
            this.checkoutMenuItem.Name = "checkoutMenuItem";
            this.checkoutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkoutMenuItem.Text = "Check-out";
            this.checkoutMenuItem.Click += new System.EventHandler(this.checkoutMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisMenuItem,
            this.yearlyStationAnalysisMenuItem});
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.DropDownClosed += new System.EventHandler(this.adminToolStripMenuItem_DropDownClosed);
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // yearlyRevenueAnalysisMenuItem
            // 
            this.yearlyRevenueAnalysisMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.yearlyRevenueAnalysisMenuItem.ForeColor = System.Drawing.Color.White;
            this.yearlyRevenueAnalysisMenuItem.Name = "yearlyRevenueAnalysisMenuItem";
            this.yearlyRevenueAnalysisMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisMenuItem_Click);
            // 
            // yearlyStationAnalysisMenuItem
            // 
            this.yearlyStationAnalysisMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.yearlyStationAnalysisMenuItem.ForeColor = System.Drawing.Color.White;
            this.yearlyStationAnalysisMenuItem.Name = "yearlyStationAnalysisMenuItem";
            this.yearlyStationAnalysisMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyStationAnalysisMenuItem.Text = "Yearly Station Analysis";
            this.yearlyStationAnalysisMenuItem.Click += new System.EventHandler(this.yearlyStationAnalysisMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvailabilityMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyStationAnalysisMenuItem;
    }
}