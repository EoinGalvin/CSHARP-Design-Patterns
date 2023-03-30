namespace RestaurantSystem.PresentationLayer
{
    partial class frmAddReservation
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
            this.btnGetStations = new System.Windows.Forms.Button();
            this.labelResDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelTableNoRes = new System.Windows.Forms.Label();
            this.cboStationNo = new System.Windows.Forms.ComboBox();
            this.labelCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustNum = new System.Windows.Forms.Label();
            this.txtCustNum = new System.Windows.Forms.TextBox();
            this.labelSitting = new System.Windows.Forms.Label();
            this.cboSitting = new System.Windows.Forms.ComboBox();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.dgvAvailableStations = new System.Windows.Forms.DataGridView();
            this.grpResDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableStations)).BeginInit();
            this.grpResDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seating Required:";
            // 
            // cboCapacity
            // 
            this.cboCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapacity.FormattingEnabled = true;
            this.cboCapacity.Location = new System.Drawing.Point(202, 105);
            this.cboCapacity.Name = "cboCapacity";
            this.cboCapacity.Size = new System.Drawing.Size(65, 21);
            this.cboCapacity.TabIndex = 17;
            // 
            // btnGetStations
            // 
            this.btnGetStations.Location = new System.Drawing.Point(202, 137);
            this.btnGetStations.Name = "btnGetStations";
            this.btnGetStations.Size = new System.Drawing.Size(117, 40);
            this.btnGetStations.TabIndex = 18;
            this.btnGetStations.Text = "Get Available Stations";
            this.btnGetStations.UseVisualStyleBackColor = true;
            this.btnGetStations.Click += new System.EventHandler(this.btnGetStations_Click);
            // 
            // labelResDate
            // 
            this.labelResDate.AutoSize = true;
            this.labelResDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResDate.ForeColor = System.Drawing.Color.Black;
            this.labelResDate.Location = new System.Drawing.Point(12, 22);
            this.labelResDate.Name = "labelResDate";
            this.labelResDate.Size = new System.Drawing.Size(184, 25);
            this.labelResDate.TabIndex = 21;
            this.labelResDate.Text = "Reservation Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(202, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(117, 20);
            this.dtpDate.TabIndex = 22;
            // 
            // labelTableNoRes
            // 
            this.labelTableNoRes.AutoSize = true;
            this.labelTableNoRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableNoRes.ForeColor = System.Drawing.Color.Black;
            this.labelTableNoRes.Location = new System.Drawing.Point(31, 111);
            this.labelTableNoRes.Name = "labelTableNoRes";
            this.labelTableNoRes.Size = new System.Drawing.Size(166, 25);
            this.labelTableNoRes.TabIndex = 23;
            this.labelTableNoRes.Text = "Station Number:";
            // 
            // cboStationNo
            // 
            this.cboStationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationNo.FormattingEnabled = true;
            this.cboStationNo.Location = new System.Drawing.Point(206, 115);
            this.cboStationNo.Name = "cboStationNo";
            this.cboStationNo.Size = new System.Drawing.Size(65, 21);
            this.cboStationNo.TabIndex = 24;
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.ForeColor = System.Drawing.Color.Black;
            this.labelCustName.Location = new System.Drawing.Point(25, 27);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(172, 25);
            this.labelCustName.TabIndex = 25;
            this.labelCustName.Text = "Customer Name:";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(206, 32);
            this.txtCustName.MaxLength = 30;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(163, 20);
            this.txtCustName.TabIndex = 26;
            // 
            // lblCustNum
            // 
            this.lblCustNum.AutoSize = true;
            this.lblCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNum.ForeColor = System.Drawing.Color.Black;
            this.lblCustNum.Location = new System.Drawing.Point(6, 68);
            this.lblCustNum.Name = "lblCustNum";
            this.lblCustNum.Size = new System.Drawing.Size(191, 25);
            this.lblCustNum.TabIndex = 27;
            this.lblCustNum.Text = "Customer Number:";
            // 
            // txtCustNum
            // 
            this.txtCustNum.Location = new System.Drawing.Point(206, 73);
            this.txtCustNum.MaxLength = 10;
            this.txtCustNum.Name = "txtCustNum";
            this.txtCustNum.Size = new System.Drawing.Size(163, 20);
            this.txtCustNum.TabIndex = 28;
            // 
            // labelSitting
            // 
            this.labelSitting.AutoSize = true;
            this.labelSitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSitting.ForeColor = System.Drawing.Color.Black;
            this.labelSitting.Location = new System.Drawing.Point(44, 63);
            this.labelSitting.Name = "labelSitting";
            this.labelSitting.Size = new System.Drawing.Size(152, 25);
            this.labelSitting.TabIndex = 29;
            this.labelSitting.Text = "Time of sitting:";
            // 
            // cboSitting
            // 
            this.cboSitting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSitting.FormattingEnabled = true;
            this.cboSitting.Location = new System.Drawing.Point(202, 67);
            this.cboSitting.Name = "cboSitting";
            this.cboSitting.Size = new System.Drawing.Size(65, 21);
            this.cboSitting.TabIndex = 30;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(206, 154);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(117, 40);
            this.btnAddReservation.TabIndex = 31;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // dgvAvailableStations
            // 
            this.dgvAvailableStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableStations.Location = new System.Drawing.Point(12, 197);
            this.dgvAvailableStations.Name = "dgvAvailableStations";
            this.dgvAvailableStations.Size = new System.Drawing.Size(385, 241);
            this.dgvAvailableStations.TabIndex = 32;
            this.dgvAvailableStations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableStations_CellClick);
            // 
            // grpResDetails
            // 
            this.grpResDetails.Controls.Add(this.labelCustName);
            this.grpResDetails.Controls.Add(this.lblCustNum);
            this.grpResDetails.Controls.Add(this.btnAddReservation);
            this.grpResDetails.Controls.Add(this.labelTableNoRes);
            this.grpResDetails.Controls.Add(this.txtCustNum);
            this.grpResDetails.Controls.Add(this.cboStationNo);
            this.grpResDetails.Controls.Add(this.txtCustName);
            this.grpResDetails.Location = new System.Drawing.Point(413, 22);
            this.grpResDetails.Name = "grpResDetails";
            this.grpResDetails.Size = new System.Drawing.Size(375, 416);
            this.grpResDetails.TabIndex = 33;
            this.grpResDetails.TabStop = false;
            this.grpResDetails.Text = "Reservation Details";
            this.grpResDetails.Visible = false;
            // 
            // frmAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpResDetails);
            this.Controls.Add(this.dgvAvailableStations);
            this.Controls.Add(this.cboSitting);
            this.Controls.Add(this.labelSitting);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.labelResDate);
            this.Controls.Add(this.btnGetStations);
            this.Controls.Add(this.cboCapacity);
            this.Controls.Add(this.label1);
            this.Name = "frmAddReservation";
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.frmAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableStations)).EndInit();
            this.grpResDetails.ResumeLayout(false);
            this.grpResDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCapacity;
        private System.Windows.Forms.Button btnGetStations;
        private System.Windows.Forms.Label labelResDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labelTableNoRes;
        private System.Windows.Forms.ComboBox cboStationNo;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustNum;
        private System.Windows.Forms.TextBox txtCustNum;
        private System.Windows.Forms.Label labelSitting;
        private System.Windows.Forms.ComboBox cboSitting;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.DataGridView dgvAvailableStations;
        private System.Windows.Forms.GroupBox grpResDetails;
    }
}