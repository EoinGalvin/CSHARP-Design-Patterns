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

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmStationAnalysis : Form
    {
        private static frmStationAnalysis instance = null;
        private static readonly object padlock = new object();
        private frmStationAnalysis(){
            InitializeComponent();
        }
        public static frmStationAnalysis GetForm
        {
            get
            {
                lock (padlock) 
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmStationAnalysis();
                    }
                    return instance;
                }
            }
        }
        private void frmStationAnalysis_Load(object sender, EventArgs e){
            DataTable dtbl = Utility.returnTable("SELECT STATIONNO, COUNT(STATIONNO) AS TOTAL from RESERVATIONS GROUP BY STATIONNO");

            //CHART CODE
            chtData.DataSource = dtbl;
            chtData.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chtData.Series[0].XValueMember = "STATIONNO";
            chtData.Series[0].YValueMembers = "TOTAL";
            chtData.Series[0].IsValueShownAsLabel = true;
            chtData.Titles.Add("Station Popularity");
            // Data grid code
            dgvStationAnalysis.DataSource = dtbl;
        }
    }
}
