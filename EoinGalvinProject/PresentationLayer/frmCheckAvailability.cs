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
    public partial class frmCheckAvailability : Form
    {
        private static frmCheckAvailability instance = null;
        private static readonly object padlock = new object();

        DataTable dtbl = new DataTable();
        DataTable dtblSpecified = new DataTable();
        private frmCheckAvailability(){
            InitializeComponent();
        }
        public static frmCheckAvailability GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmCheckAvailability();
                    }
                    return instance;
                }
            }
        }

        private void frmCheckAvailability_Load(object sender, EventArgs e){
            Utility.populateAnyCbo(cboCapacity, "SELECT STATIONCAPACITY FROM STATIONUTILITY WHERE STATIONCAPACITY IS NOT NULL", "STATIONCAPACITY");
            Utility.populateAnyCbo(cboSitting, "SELECT SITTING FROM RESERVATIONUTILITY WHERE SITTING IS NOT NULL", "SITTING");
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e){
            if (cboCapacity.SelectedItem == null || dtpDate.Value == null || cboSitting == null){
                MessageBox.Show("Please select a value for every field");
            }
            else if (dtpDate.Value <= DateTime.Now.Date){
                dgvAvailableStations.DataSource = null;
                MessageBox.Show("Please select a date greater than " + DateTime.Now.Date.ToString().Substring(0, 10));
                chkCapacitySelected.Checked = false;
            }
            else{
                int specifiedCapacity = Convert.ToInt32(cboCapacity.Text);
                dtbl = Station.getAvailableStations(dtpDate.Value, Convert.ToInt32(cboSitting.Text), specifiedCapacity,true);
                dgvAvailableStations.DataSource = dtbl;

                setSpecifiedDtbl(specifiedCapacity);
                chkCapacitySelected.Checked = false;
            }
        }

        private void chkCapacitySelected_CheckedChanged(object sender, EventArgs e){
            if (chkCapacitySelected.Checked){
                dgvAvailableStations.DataSource = dtblSpecified;
            }
            else{
                dgvAvailableStations.DataSource = dtbl;
            }
        }

        private void setSpecifiedDtbl(int specifiedCapacity)
        {
            dtblSpecified = dtbl.Copy();

            List<DataRow> toDelete = new List<DataRow>();

            foreach (DataRow row in dtblSpecified.Rows)
            {
                if (Convert.ToInt32(row["STATIONCAPACITY"]) != specifiedCapacity)
                {
                    toDelete.Add(row);
                }
            }
            foreach (DataRow row in toDelete)
            {
                dtblSpecified.Rows.Remove(row);
            }
        }
    }
}
