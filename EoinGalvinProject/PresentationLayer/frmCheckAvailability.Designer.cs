namespace RestaurantSystem.PresentationLayer
{
    partial class frmCheckAvailability
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCapacity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboSitting = new System.Windows.Forms.ComboBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.dgvAvailableStations = new System.Windows.Forms.DataGridView();
            this.chkCapacitySelected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableStations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacity Required:";
            // 
            // cboCapacity
            // 
            this.cboCapacity.BackColor = System.Drawing.Color.White;
            this.cboCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapacity.FormattingEnabled = true;
            this.cboCapacity.Location = new System.Drawing.Point(223, 108);
            this.cboCapacity.Name = "cboCapacity";
            this.cboCapacity.Size = new System.Drawing.Size(62, 21);
            this.cboCapacity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reservation Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time of sitting (7,9):";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDate.Location = new System.Drawing.Point(223, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(141, 20);
            this.dtpDate.TabIndex = 15;
            // 
            // cboSitting
            // 
            this.cboSitting.BackColor = System.Drawing.Color.White;
            this.cboSitting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSitting.FormattingEnabled = true;
            this.cboSitting.Items.AddRange(new object[] {
            "7",
            "9"});
            this.cboSitting.Location = new System.Drawing.Point(223, 70);
            this.cboSitting.Name = "cboSitting";
            this.cboSitting.Size = new System.Drawing.Size(62, 21);
            this.cboSitting.TabIndex = 16;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.BackColor = System.Drawing.Color.White;
            this.btnCheckAvailability.Location = new System.Drawing.Point(223, 140);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(141, 45);
            this.btnCheckAvailability.TabIndex = 19;
            this.btnCheckAvailability.Text = "View Available Stations";
            this.btnCheckAvailability.UseVisualStyleBackColor = false;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // dgvAvailableStations
            // 
            this.dgvAvailableStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableStations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableStations.GridColor = System.Drawing.Color.Black;
            this.dgvAvailableStations.Location = new System.Drawing.Point(28, 226);
            this.dgvAvailableStations.Name = "dgvAvailableStations";
            this.dgvAvailableStations.ReadOnly = true;
            this.dgvAvailableStations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAvailableStations.Size = new System.Drawing.Size(733, 202);
            this.dgvAvailableStations.TabIndex = 20;
            // 
            // chkCapacitySelected
            // 
            this.chkCapacitySelected.AutoSize = true;
            this.chkCapacitySelected.Location = new System.Drawing.Point(370, 145);
            this.chkCapacitySelected.Name = "chkCapacitySelected";
            this.chkCapacitySelected.Size = new System.Drawing.Size(112, 17);
            this.chkCapacitySelected.TabIndex = 22;
            this.chkCapacitySelected.Text = "Capacity Selected";
            this.chkCapacitySelected.UseVisualStyleBackColor = true;
            this.chkCapacitySelected.CheckedChanged += new System.EventHandler(this.chkCapacitySelected_CheckedChanged);
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkCapacitySelected);
            this.Controls.Add(this.dgvAvailableStations);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.cboSitting);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCapacity);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckAvailability";
            this.Text = "Check Availability";
            this.Load += new System.EventHandler(this.frmCheckAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboSitting;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.DataGridView dgvAvailableStations;
        private System.Windows.Forms.CheckBox chkCapacitySelected;
    }
}