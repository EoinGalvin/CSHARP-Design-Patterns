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
    public partial class frmCheckIn : Form
    {
        private static frmCheckIn instance = null;
        private static readonly object padlock = new object();
        private frmCheckIn(){
            InitializeComponent();
        }
        public static frmCheckIn GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmCheckIn();
                    }
                    return instance;
                }
            }
        }
        private void frmCheckIn_Load(object sender, EventArgs e){
            setUI();
        }

        private void btnCheckIn_Click(object sender, EventArgs e){
            if (cboResID.SelectedItem == null){
                MessageBox.Show("Please select a reservation ID");
            }
            else{
                Reservation.checkIntoSystem(Convert.ToInt32(cboResID.Text));
                MessageBox.Show("Reservation " + Convert.ToInt32(cboResID.Text) + " has been Checked in");
                setUI();
            }
        }
        private void dgvCheckIn_CellClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex == -1) return;
            if (dgvCheckIn.SelectedCells.Count > 0){
                dgvCheckIn.CurrentRow.Selected = true;
                cboResID.Text = dgvCheckIn.Rows[e.RowIndex].Cells["RESID"].Value.ToString();
            }
        }
        private void setUI(){
            DateTime currentDate = DateTime.Now.Date;
            String currentDateAsString = currentDate.ToString("dd MMM yy").Replace(' ', '-').ToUpper();
           
            DataTable dtbl = Utility.returnTable("SELECT * FROM RESERVATIONS WHERE ACTIVE = 'N' AND RESDATE ='" +currentDateAsString+ "' ORDER BY RESID");
            dgvCheckIn.DataSource = dtbl;
            Utility.populateAnyCbo(cboResID, "SELECT * FROM RESERVATIONS WHERE ACTIVE = 'N' AND RESDATE ='" + currentDateAsString+ "' ORDER BY RESID", "RESID");
        }
    }
}
