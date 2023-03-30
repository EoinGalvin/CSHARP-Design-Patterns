namespace RestaurantSystem.PresentationLayer
{
    partial class frmDeleteStation
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
            this.dgvDeleteStation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStationNo = new System.Windows.Forms.ComboBox();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteStation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeleteStation
            // 
            this.dgvDeleteStation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDeleteStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteStation.Location = new System.Drawing.Point(12, 12);
            this.dgvDeleteStation.Name = "dgvDeleteStation";
            this.dgvDeleteStation.Size = new System.Drawing.Size(423, 426);
            this.dgvDeleteStation.TabIndex = 3;
            this.dgvDeleteStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeleteStation_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(460, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tables that do not have a future reservation";
            // 
            // cboStationNo
            // 
            this.cboStationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationNo.FormattingEnabled = true;
            this.cboStationNo.Location = new System.Drawing.Point(464, 60);
            this.cboStationNo.Name = "cboStationNo";
            this.cboStationNo.Size = new System.Drawing.Size(121, 21);
            this.cboStationNo.TabIndex = 5;
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(464, 120);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(121, 47);
            this.btnDeleteStation.TabIndex = 26;
            this.btnDeleteStation.Text = "Delete Station";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // frmDeleteStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.cboStationNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDeleteStation);
            this.Name = "frmDeleteStation";
            this.Text = "Delete Station";
            this.Load += new System.EventHandler(this.frmDeleteStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeleteStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStationNo;
        private System.Windows.Forms.Button btnDeleteStation;
    }
}