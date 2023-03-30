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

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmAddStation : Form
    {
        private static frmAddStation instance = null;
        private static readonly object padlock = new object();

        private frmAddStation(){
            InitializeComponent();
        }

        public static frmAddStation GetForm
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null || instance.IsDisposed )
                    {
                        instance = new frmAddStation();
                    }
                    return instance;
                }
            }
        }

        private void frmAddStation_Load(object sender, EventArgs e){
            setUI();
        }
        private void btnAddStation_Click(object sender, EventArgs e){
            if (cboStationType.SelectedItem == null || cboStationCapacity.SelectedItem == null){
                MessageBox.Show("Please select a value for every field");
            }
            else{
                char stationTypeInput = Convert.ToChar(cboStationType.Text.Substring(0, 1));

                Station station = StationFactory.CreateStation(stationTypeInput);

                station.setStationNo(Convert.ToInt32(lblShowNumber.Text));
                station.setStationCapacity(Convert.ToInt32(cboStationCapacity.Text));
                station.setStationStatus(Convert.ToChar(cboStationType.Text.Substring(0, 1)));
                station.addStationToDB();
                MessageBox.Show("Table " + (Convert.ToInt32(lblShowNumber.Text)) + " has been added");
                setUI();
            }
        }
        private void setUI(){ 
            lblShowNumber.Text = Station.getNextStationId().ToString();
            Utility.populateAnyCbo(cboStationType, "SELECT STATIONTYPES FROM STATIONUTILITY WHERE STATIONTYPES IS NOT NULL", "STATIONTYPES");
            Utility.populateAnyCbo(cboStationCapacity, "SELECT STATIONCAPACITY FROM STATIONUTILITY WHERE STATIONCAPACITY IS NOT NULL", "STATIONCAPACITY");      
        }
    }
}
