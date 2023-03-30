namespace RestaurantSystem.PresentationLayer
{
    partial class frmStationAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStationAnalysis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // chtData
            // 
            this.chtData.BorderlineColor = System.Drawing.Color.SeaGreen;
            chartArea1.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtData.Legends.Add(legend1);
            this.chtData.Location = new System.Drawing.Point(263, 12);
            this.chtData.Name = "chtData";
            this.chtData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtData.Series.Add(series1);
            this.chtData.Size = new System.Drawing.Size(506, 408);
            this.chtData.TabIndex = 2;
            this.chtData.Text = "chtRevenue";
            // 
            // dgvStationAnalysis
            // 
            this.dgvStationAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationAnalysis.Location = new System.Drawing.Point(17, 12);
            this.dgvStationAnalysis.Name = "dgvStationAnalysis";
            this.dgvStationAnalysis.Size = new System.Drawing.Size(240, 408);
            this.dgvStationAnalysis.TabIndex = 3;
            // 
            // frmStationAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStationAnalysis);
            this.Controls.Add(this.chtData);
            this.Name = "frmStationAnalysis";
            this.Text = "Station Analysis";
            this.Load += new System.EventHandler(this.frmStationAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.DataGridView dgvStationAnalysis;
    }
}