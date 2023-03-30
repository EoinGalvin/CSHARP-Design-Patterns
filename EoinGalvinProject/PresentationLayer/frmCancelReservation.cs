using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EoinGalvinProject.BusinessLayer.ReservationAbstractFactory;
using RestaurantSystem.BusinessLayer;

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmCancelReservation : Form
    {
        private static frmCancelReservation instance = null;
        private static readonly object padlock = new object();
        private frmCancelReservation(){
            InitializeComponent();
        }
        public static frmCancelReservation GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmCancelReservation();
                    }
                    return instance;
                }
            }
        }
        private void frmCancelReservation_Load(object sender, EventArgs e){
            setUI();
        }
        private void btnCancelReservation_Click(object sender, EventArgs e){
            if (cboResID.SelectedItem != null){
                int resID = Convert.ToInt32(cboResID.Text);
                
                Reservation.deleteFromDatabase(resID);
                MessageBox.Show("Reservation : " + cboResID.Text + " has been cancelled");
            }
            else{MessageBox.Show("Please select a reservation");}
            setUI();
        }
        private void btnSearch_Click(object sender, EventArgs e){
            dgvCancelReservation.DataSource = Reservation.reservationSearch(txtName.Text);
            DataTable dtbl = Reservation.fillResIDCboOnSearch(txtName.Text);

            cboResID.DisplayMember = "RESID";
            cboResID.DataSource = dtbl;
            cboResID.Enabled = true;
        }
        private void btnShowAll_Click(object sender, EventArgs e){
            dgvCancelReservation.DataSource = Utility.returnTable("SELECT * FROM RESERVATIONS WHERE ACTIVE = 'N' ORDER BY RESID");
            Utility.populateAnyCbo(cboResID, "SELECT RESID FROM RESERVATIONS WHERE ACTIVE = 'N' ORDER BY RESID", "RESID");
        }
        private void dgvCancelReservation_CellClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex == -1) return;
            if (dgvCancelReservation.SelectedCells.Count > 0){
                dgvCancelReservation.CurrentRow.Selected = true;
                if (dgvCancelReservation.Rows.Count > 0){
                    cboResID.Text = dgvCancelReservation.Rows[e.RowIndex].Cells["RESID"].Value.ToString();
                }
            }
        }
        private void setUI(){
            DataTable dtbl = Utility.returnTable("SELECT * FROM RESERVATIONS WHERE ACTIVE = 'N' ORDER BY RESID");
            dgvCancelReservation.DataSource = dtbl;
            Utility.populateAnyCbo(cboResID, "SELECT RESID FROM RESERVATIONS WHERE ACTIVE = 'N' ORDER BY RESID", "RESID");
        }
    }
}
