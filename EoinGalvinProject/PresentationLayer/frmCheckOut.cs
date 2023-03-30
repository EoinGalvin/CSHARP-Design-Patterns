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
    public partial class frmCheckOut : Form
    {
        private static frmCheckOut instance = null;
        private static readonly object padlock = new object();
        private frmCheckOut(){
            InitializeComponent();
        }
        public static frmCheckOut GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmCheckOut();
                    }
                    return instance;
                }
            }
        }
        private void frmCheckOut_Load(object sender, EventArgs e){
            setUI();
        }
        private void btnCheckOut_Click(object sender, EventArgs e){
            if (cboResID.SelectedItem == null){
                MessageBox.Show("Please select a reservation");
            }
            else if (nudTotalCost.Value < 2){
                MessageBox.Show("Please enter a valid cost");
            }
            else{
                Reservation.checkOutSystem((float)(nudTotalCost.Value),Convert.ToInt32(cboResID.Text));
                MessageBox.Show("Reservation : " + cboResID.Text + " is now checked out");
                setUI();
            }
        }
        private void dgvCheckOut_CellClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex == -1) return;
            dgvCheckOut.CurrentRow.Selected = true;
                if (dgvCheckOut.Rows.Count > 0){
                    cboResID.Text = dgvCheckOut.Rows[e.RowIndex].Cells["RESID"].Value.ToString();
                }
        }
        private void setUI(){
            DataTable dtblBillCollection = Utility.returnTable("SELECT * FROM RESERVATIONS WHERE COST = 0 AND ACTIVE = 'Y' ORDER BY RESID");
            dgvCheckOut.DataSource = dtblBillCollection;
            Utility.populateAnyCbo(cboResID, "SELECT RESID FROM RESERVATIONS WHERE COST = 0 AND ACTIVE = 'Y' ORDER BY RESID", "RESID");
        } 
    }
}
