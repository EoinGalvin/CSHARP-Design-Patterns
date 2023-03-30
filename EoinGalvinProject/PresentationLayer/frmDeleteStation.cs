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
    public partial class frmDeleteStation : Form
    {
        private static frmDeleteStation instance = null;
        private static readonly object padlock = new object();
        private frmDeleteStation()
        {
            InitializeComponent();
        }
        public static frmDeleteStation GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmDeleteStation();
                    }
                    return instance;
                }
            }
        }

        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            int stationNo = 0;
            if (cboStationNo.SelectedItem != null){
                stationNo = Convert.ToInt32(cboStationNo.Text);
            }
            else{
                MessageBox.Show("Please select a station");
            }
            Station.deleteStation(stationNo);
            setUI();
        }

        private void frmDeleteStation_Load(object sender, EventArgs e){
            setUI();
        }
        private void dgvDeleteStation_CellClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex == -1) return;
            dgvDeleteStation.CurrentRow.Selected = true;
            cboStationNo.Text = dgvDeleteStation.Rows[e.RowIndex].Cells["STATIONNO"].Value.ToString();
        }
        private void setUI(){
            dgvDeleteStation.DataSource = Utility.returnTable("SELECT * FROM STATIONS WHERE STATIONNO NOT IN (SELECT STATIONNO FROM RESERVATIONS WHERE resdate >= sysdate AND ACTIVE != 'C') ORDER BY STATIONNO");
            DataTable dtbl = Utility.returnTable("SELECT STATIONNO FROM STATIONS WHERE STATIONNO NOT IN (SELECT STATIONNO FROM RESERVATIONS WHERE resdate >= sysdate AND ACTIVE != 'C') ORDER BY STATIONNO");

            cboStationNo.DisplayMember = "STATIONNO";
            cboStationNo.DataSource = dtbl;
            cboStationNo.Enabled = true;
        }
    }
}
