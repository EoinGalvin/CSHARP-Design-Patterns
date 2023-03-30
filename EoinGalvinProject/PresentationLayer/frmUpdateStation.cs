using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EoinGalvinProject.BusinessLayer;
using RestaurantSystem.BusinessLayer;

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmUpdateStation : Form
    {
        private static frmUpdateStation instance = null;
        private static readonly object padlock = new object();
        private frmUpdateStation(){
            InitializeComponent();
        }

        public static frmUpdateStation GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmUpdateStation();
                    }
                    return instance;
                }
            }
        }

        private void frmUpdateStation_Load(object sender, EventArgs e){
            dgvUpdateStation.DataSource = Station.loadStationsNoFutureRes();
            DataTable dtbl = Utility.returnTable("SELECT STATIONNO FROM STATIONS WHERE STATIONNO NOT IN (SELECT STATIONNO FROM RESERVATIONS WHERE resdate >= sysdate AND ACTIVE != 'C') ORDER BY STATIONNO");

            cboStationNo.DisplayMember = "STATIONNO";
            cboStationNo.DataSource = dtbl;
            cboStationNo.Enabled = true;

            Utility.populateAnyCbo(cboStationType, "SELECT STATIONTYPES FROM STATIONUTILITY WHERE STATIONTYPES IS NOT NULL", "STATIONTYPES");
            Utility.populateAnyCbo(cboStationCapacity, "SELECT STATIONCAPACITY FROM STATIONUTILITY WHERE STATIONCAPACITY IS NOT NULL", "STATIONCAPACITY");
            Utility.populateAnyCbo(cboStationStatus, "SELECT STATIONSTATUS FROM STATIONUTILITY WHERE STATIONSTATUS IS NOT NULL", "STATIONSTATUS");
        }
        private void dgvUpdateStation_CellClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex == -1) return;

            if (dgvUpdateStation.SelectedCells.Count > 0){ 
                    dgvUpdateStation.CurrentRow.Selected = true;
                    cboStationNo.Text = dgvUpdateStation.Rows[e.RowIndex].Cells["STATIONNO"].Value.ToString();
                    cboStationCapacity.Text = dgvUpdateStation.Rows[e.RowIndex].Cells["STATIONCAPACITY"].Value.ToString();
                
                if (dgvUpdateStation.Rows[e.RowIndex].Cells["STATIONTYPE"].Value.ToString() != ""){
                    String selectedType = dgvUpdateStation.Rows[e.RowIndex].Cells["STATIONTYPE"].Value.ToString().Substring(0, 1);
                    if(selectedType == "B"){cboStationType.Text = "B - Balcony";}
                    if(selectedType == "C"){cboStationType.Text = "C - Centre";}
                    if(selectedType == "W"){cboStationType.Text = "W - Window";}
                }
            }
        }
        private void btnUpdateStation_Click(object sender, EventArgs e){
            if (cboStationNo.SelectedItem == null || cboStationCapacity.SelectedItem == null || cboStationStatus.SelectedItem == null || cboStationType.SelectedItem == null){
                MessageBox.Show("Please select a value for every field");
            }
            else{
                char stationTypeInput = Convert.ToChar(cboStationType.Text.Substring(0, 1));
                Station station = StationFactory.CreateStation(stationTypeInput);

                station.setStationNo(Convert.ToInt32(cboStationNo.Text));
                station.setStationCapacity(Convert.ToInt32(cboStationCapacity.Text));
                station.setStationStatus(Convert.ToChar(cboStationStatus.Text));

                station.updateStation();
                dgvUpdateStation.DataSource = Station.loadStationsNoFutureRes();
            }
        }

    }
}
