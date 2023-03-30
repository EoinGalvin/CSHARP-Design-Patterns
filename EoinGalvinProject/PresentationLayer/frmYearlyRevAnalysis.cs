using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using RestaurantSystem.BusinessLayer;
using EoinGalvinProject.BusinessLayer.ReservationAbstractFactory;

namespace RestaurantSystem.PresentationLayer
{
    public partial class frmYearlyRevAnalysis : Form
    {
        private static frmYearlyRevAnalysis instance = null;
        private static readonly object padlock = new object();
        private frmYearlyRevAnalysis()
        {
            InitializeComponent();
        }
        public static frmYearlyRevAnalysis GetForm
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmYearlyRevAnalysis();
                    }
                    return instance;
                }
            }
        }

        private void frmYearlyRevAnalysis_Load(object sender, EventArgs e)
        {
            Utility.populateAnyCbo(cboYear, "select distinct to_char(resdate,'YY') AS YEARS FROM RESERVATIONS", "YEARS");
        }

        private void btnGenGraph_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboYear.Text))
            {
                MessageBox.Show("Please select a year");
            }
            else { 
                DataTable dtbl = Reservation.getRevenueData(Convert.ToInt32(cboYear.Text));
                Decimal[] revenue = new Decimal[12];
                String[] months = new String[12] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

                //Chart code 
                for (int i = 0; i < dtbl.Rows.Count; i++){
                    if (dtbl.Rows[i]["MONTH"].ToString() == "01") { revenue[0] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "02") { revenue[1] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "03") { revenue[2] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "04") { revenue[3] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "05") { revenue[4] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "06") { revenue[5] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "07") { revenue[6] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "08") { revenue[7] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "09") { revenue[8] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "10") { revenue[9] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "11") { revenue[10] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                    if (dtbl.Rows[i]["MONTH"].ToString() == "12") { revenue[11] = Decimal.Parse((dtbl.Rows[i]["TOTAL"].ToString())); }
                }
                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtData.Series[0].LegendText = "Income in €";
                chtData.Series[0].Points.DataBindXY(months, revenue);
                chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

                chtData.Series[0].Label = "#VALY";
                if (chtData.Titles.Count == 0)
                {
                    chtData.Titles[0] = chtData.Titles.Add("Yearly Revenue");
                }
                chtData.Visible = true;

                //Data grid  code
           
                DataTable dtblRevAnalysis = new DataTable();
                dtblRevAnalysis.Columns.Add("Month");
                dtblRevAnalysis.Columns.Add("Revenue");

                for (int i = 0; i < revenue.Length; i++)
                {
                    DataRow row = dtblRevAnalysis.NewRow();
                    row["Revenue"] = revenue[i];
                    row["Month"] = months[i];
                    dtblRevAnalysis.Rows.Add(row);
                }
                dgvRevenue.DataSource = dtblRevAnalysis;
            }
        }
    }
}