namespace RestaurantSystem.PresentationLayer
{
    partial class frmUpdateStation
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
            this.dgvUpdateStation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStationNo = new System.Windows.Forms.ComboBox();
            this.cboStationCapacity = new System.Windows.Forms.ComboBox();
            this.cboStationStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStation = new System.Windows.Forms.Button();
            this.cboStationType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateStation
            // 
            this.dgvUpdateStation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpdateStation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUpdateStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateStation.Location = new System.Drawing.Point(24, 22);
            this.dgvUpdateStation.Name = "dgvUpdateStation";
            this.dgvUpdateStation.Size = new System.Drawing.Size(434, 320);
            this.dgvUpdateStation.TabIndex = 1;
            this.dgvUpdateStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateStation_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(480, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Station Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(480, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Station Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(480, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "StationType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(480, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Station Status";
            // 
            // cboStationNo
            // 
            this.cboStationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationNo.FormattingEnabled = true;
            this.cboStationNo.Location = new System.Drawing.Point(667, 26);
            this.cboStationNo.Name = "cboStationNo";
            this.cboStationNo.Size = new System.Drawing.Size(121, 21);
            this.cboStationNo.TabIndex = 21;
            // 
            // cboStationCapacity
            // 
            this.cboStationCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationCapacity.FormattingEnabled = true;
            this.cboStationCapacity.Location = new System.Drawing.Point(667, 87);
            this.cboStationCapacity.Name = "cboStationCapacity";
            this.cboStationCapacity.Size = new System.Drawing.Size(121, 21);
            this.cboStationCapacity.TabIndex = 22;
            // 
            // cboStationStatus
            // 
            this.cboStationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationStatus.FormattingEnabled = true;
            this.cboStationStatus.Location = new System.Drawing.Point(667, 211);
            this.cboStationStatus.Name = "cboStationStatus";
            this.cboStationStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStationStatus.TabIndex = 24;
            // 
            // btnUpdateStation
            // 
            this.btnUpdateStation.Location = new System.Drawing.Point(667, 274);
            this.btnUpdateStation.Name = "btnUpdateStation";
            this.btnUpdateStation.Size = new System.Drawing.Size(121, 47);
            this.btnUpdateStation.TabIndex = 26;
            this.btnUpdateStation.Text = "UpdateStation";
            this.btnUpdateStation.UseVisualStyleBackColor = true;
            this.btnUpdateStation.Click += new System.EventHandler(this.btnUpdateStation_Click);
            // 
            // cboStationType
            // 
            this.cboStationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationType.FormattingEnabled = true;
            this.cboStationType.Location = new System.Drawing.Point(667, 149);
            this.cboStationType.Name = "cboStationType";
            this.cboStationType.Size = new System.Drawing.Size(121, 21);
            this.cboStationType.TabIndex = 27;
            // 
            // frmUpdateStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboStationType);
            this.Controls.Add(this.btnUpdateStation);
            this.Controls.Add(this.cboStationStatus);
            this.Controls.Add(this.cboStationCapacity);
            this.Controls.Add(this.cboStationNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUpdateStation);
            this.Name = "frmUpdateStation";
            this.Text = "Update Station";
            this.Load += new System.EventHandler(this.frmUpdateStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStationNo;
        private System.Windows.Forms.ComboBox cboStationCapacity;
        private System.Windows.Forms.ComboBox cboStationStatus;
        private System.Windows.Forms.Button btnUpdateStation;
        private System.Windows.Forms.ComboBox cboStationType;
    }
}