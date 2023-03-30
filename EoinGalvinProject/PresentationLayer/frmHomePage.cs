using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmHomePage : Form
    {
        public frmHomePage(){
            InitializeComponent();
        }

        private void addStationMenuItem_Click(object sender, EventArgs e){
            frmAddStation frmAddStation = frmAddStation.GetForm;
            frmAddStation.Show();
            frmAddStation.BringToFront();
        }

        private void updateStationMenuItem_Click(object sender, EventArgs e){
            frmUpdateStation frmUpdateStation = frmUpdateStation.GetForm;
            frmUpdateStation.Show();
            frmUpdateStation.BringToFront();
        }

        private void deleteStationMenuItem_Click(object sender, EventArgs e){
            frmDeleteStation frmDeleteStation = frmDeleteStation.GetForm;
            frmDeleteStation.Show();
            frmDeleteStation.BringToFront();
        }

        private void checkAvailabilityMenuItem_Click(object sender, EventArgs e){
            frmCheckAvailability frmCheckAvailability = frmCheckAvailability.GetForm;
            frmCheckAvailability.Show();
            frmCheckAvailability.BringToFront();
        }

        private void addReservationMenuItem_Click(object sender, EventArgs e){
            frmAddReservation frmAddReservation = frmAddReservation.GetForm;
            frmAddReservation.Show();
            frmAddReservation.BringToFront();
        }

        private void cancelReservationMenuItem_Click(object sender, EventArgs e){
            frmCancelReservation frmCancelReservation = frmCancelReservation.GetForm;
            frmCancelReservation.Show();
            frmCancelReservation.BringToFront();
        }

        private void checkinMenuItem_Click(object sender, EventArgs e){
            frmCheckIn frmCheckIn = frmCheckIn.GetForm;
            frmCheckIn.Show();
            frmCheckIn.BringToFront();
        }

        private void checkoutMenuItem_Click(object sender, EventArgs e){
            frmCheckOut frmCheckOut = frmCheckOut.GetForm;
            frmCheckOut.Show();
            frmCheckOut.BringToFront();
        }

        private void yearlyRevenueAnalysisMenuItem_Click(object sender, EventArgs e){
            frmYearlyRevAnalysis frmYearlyRevAnalysis = frmYearlyRevAnalysis.GetForm;
            frmYearlyRevAnalysis.Show();
            frmYearlyRevAnalysis.BringToFront();
        }

        private void yearlyStationAnalysisMenuItem_Click(object sender, EventArgs e){
            frmStationAnalysis frmStationAnalysis = frmStationAnalysis.GetForm;
            frmStationAnalysis.Show();
            frmStationAnalysis.BringToFront();
        }

        private void stationsToolStripMenuItem_Click(object sender, EventArgs e){
            stationsToolStripMenuItem.ForeColor = Color.Black;
        }

        private void stationsToolStripMenuItem_DropDownClosed(object sender, EventArgs e){
            stationsToolStripMenuItem.ForeColor = Color.White;
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e){
            reservationToolStripMenuItem.ForeColor = Color.Black;
        }

        private void reservationToolStripMenuItem_DropDownClosed(object sender, EventArgs e){
            reservationToolStripMenuItem.ForeColor = Color.White;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e){
            adminToolStripMenuItem.ForeColor = Color.Black;
        }

        private void adminToolStripMenuItem_DropDownClosed(object sender, EventArgs e){
            adminToolStripMenuItem.ForeColor = Color.White;
        }
    }
}
