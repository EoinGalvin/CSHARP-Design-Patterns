using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.BusinessLayer;
using EoinGalvinProject.BusinessLayer;
using EoinGalvinProject.BusinessLayer.ReservationAbstractFactory;

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmAddReservation : Form
    {
        private static frmAddReservation instance = null;
        private static readonly object padlock = new object();
        private frmAddReservation(){
            InitializeComponent();
        }
        public static frmAddReservation GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmAddReservation();
                    }
                    return instance;
                }
            }
        }
        private void frmAddReservation_Load(object sender, EventArgs e){
            setUI();
        }
        private void btnAddReservation_Click(object sender, EventArgs e){

            if (isValidDetails()){


                ReservationFactory resFactory = ReservationFactory.CreateReservationFactory(Convert.ToInt32(cboSitting.Text));
                Reservation reservation = resFactory.GetReservation(Convert.ToInt32(cboCapacity.Text));

                reservation.setResId(Reservation.getNextResID());
                reservation.setResDate(dtpDate.Value);
                reservation.setStationNo(Convert.ToInt32(cboStationNo.Text));
                reservation.setCustName(txtCustName.Text);
                reservation.setCustNum(txtCustNum.Text);
                reservation.setSitting(Convert.ToInt32(cboSitting.Text));
                reservation.setCost(0);
                reservation.setActive('N');

                reservation.addReservationToDB();

                
                MessageBox.Show("Reservation has been added!");
                dgvAvailableStations.DataSource = null;
                cboStationNo.DataSource = null;
            }
        }
        private void btnGetStations_Click(object sender, EventArgs e){

            if (dtpDate.Value <= DateTime.Now.Date){
                hideDetails();
                MessageBox.Show("Please select a date greater than " + DateTime.Now.Date.ToString().Substring(0, 10));
            }
            else{
                DataTable dtbl = Station.getAvailableStations(dtpDate.Value, Convert.ToInt32(cboSitting.Text), Convert.ToInt32(cboCapacity.Text), false);
                if(dtbl.Rows.Count <= 0){
                    hideDetails();
                    MessageBox.Show("There is no available Stations with this criteria. Please try again.");
                }
                else{
                    dgvAvailableStations.DataSource = dtbl;
                    grpResDetails.Visible = true;
                    dtbl = Station.getStationNoCboNotBkd(Convert.ToInt32(cboCapacity.Text), dtpDate.Value, Convert.ToChar(cboSitting.Text));

                    cboStationNo.DataSource = dtbl;
                    cboStationNo.Enabled = true;
                    cboStationNo.DisplayMember = "STATIONNO";
                }                
            }
        }
        private void dgvAvailableStations_CellClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex == -1) return;
            cboStationNo.Text = dgvAvailableStations.Rows[e.RowIndex].Cells["STATIONNO"].Value.ToString();
        }

        private void hideDetails() {
            dgvAvailableStations.DataSource = null;
            cboStationNo.DataSource = null;
            grpResDetails.Visible = false;
        }
        private void setUI(){
            Utility.populateAnyCbo(cboCapacity, "SELECT STATIONCAPACITY FROM STATIONUTILITY WHERE STATIONCAPACITY IS NOT NULL", "STATIONCAPACITY");
            Utility.populateAnyCbo(cboSitting, "SELECT SITTING FROM RESERVATIONUTILITY WHERE SITTING IS NOT NULL", "SITTING");
        }
        private Boolean isValidDetails(){
            if (cboStationNo.SelectedItem == null){
                MessageBox.Show("You must select a Station Number");
                return false;
            }else if (txtCustNum.Text == ""){
                MessageBox.Show("You must enter a customer number");
                return false;
            }else if (txtCustNum.Text.All(char.IsDigit) == false){
                MessageBox.Show("Customer Phone number must only contain numbers");
                return false;
            }else if (txtCustName.Text == ""){
                MessageBox.Show("You must enter a customer name");
                return false;
            }
            else{
                return true;
            }
        }
    }
}
