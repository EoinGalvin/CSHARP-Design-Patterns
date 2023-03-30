namespace RestaurantSystem.PresentationLayer
{
    partial class frmAddStation
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
            this.lblStationNumber = new System.Windows.Forms.Label();
            this.lblShowNumber = new System.Windows.Forms.Label();
            this.lblStationType = new System.Windows.Forms.Label();
            this.cboStationType = new System.Windows.Forms.ComboBox();
            this.lblStationCapacity = new System.Windows.Forms.Label();
            this.cboStationCapacity = new System.Windows.Forms.ComboBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStationNumber
            // 
            this.lblStationNumber.AutoSize = true;
            this.lblStationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationNumber.ForeColor = System.Drawing.Color.Black;
            this.lblStationNumber.Location = new System.Drawing.Point(32, 62);
            this.lblStationNumber.Name = "lblStationNumber";
            this.lblStationNumber.Size = new System.Drawing.Size(166, 25);
            this.lblStationNumber.TabIndex = 4;
            this.lblStationNumber.Text = "Station Number:";
            // 
            // lblShowNumber
            // 
            this.lblShowNumber.BackColor = System.Drawing.Color.White;
            this.lblShowNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNumber.Location = new System.Drawing.Point(213, 51);
            this.lblShowNumber.Name = "lblShowNumber";
            this.lblShowNumber.Size = new System.Drawing.Size(76, 36);
            this.lblShowNumber.TabIndex = 18;
            // 
            // lblStationType
            // 
            this.lblStationType.AutoSize = true;
            this.lblStationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationType.ForeColor = System.Drawing.Color.Black;
            this.lblStationType.Location = new System.Drawing.Point(59, 136);
            this.lblStationType.Name = "lblStationType";
            this.lblStationType.Size = new System.Drawing.Size(139, 25);
            this.lblStationType.TabIndex = 19;
            this.lblStationType.Text = "Station Type:";
            // 
            // cboStationType
            // 
            this.cboStationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationType.FormattingEnabled = true;
            this.cboStationType.Location = new System.Drawing.Point(213, 140);
            this.cboStationType.Name = "cboStationType";
            this.cboStationType.Size = new System.Drawing.Size(121, 21);
            this.cboStationType.TabIndex = 20;
            // 
            // lblStationCapacity
            // 
            this.lblStationCapacity.AutoSize = true;
            this.lblStationCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationCapacity.ForeColor = System.Drawing.Color.Black;
            this.lblStationCapacity.Location = new System.Drawing.Point(32, 211);
            this.lblStationCapacity.Name = "lblStationCapacity";
            this.lblStationCapacity.Size = new System.Drawing.Size(175, 25);
            this.lblStationCapacity.TabIndex = 21;
            this.lblStationCapacity.Text = "Station Capacity:";
            // 
            // cboStationCapacity
            // 
            this.cboStationCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationCapacity.FormattingEnabled = true;
            this.cboStationCapacity.Location = new System.Drawing.Point(213, 215);
            this.cboStationCapacity.Name = "cboStationCapacity";
            this.cboStationCapacity.Size = new System.Drawing.Size(121, 21);
            this.cboStationCapacity.TabIndex = 22;
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(213, 280);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(121, 47);
            this.btnAddStation.TabIndex = 25;
            this.btnAddStation.Text = "Create Station";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // frmAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.cboStationCapacity);
            this.Controls.Add(this.lblStationCapacity);
            this.Controls.Add(this.cboStationType);
            this.Controls.Add(this.lblStationType);
            this.Controls.Add(this.lblShowNumber);
            this.Controls.Add(this.lblStationNumber);
            this.Name = "frmAddStation";
            this.Text = " Add Station";
            this.Load += new System.EventHandler(this.frmAddStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStationNumber;
        private System.Windows.Forms.Label lblShowNumber;
        private System.Windows.Forms.Label lblStationType;
        private System.Windows.Forms.ComboBox cboStationType;
        private System.Windows.Forms.Label lblStationCapacity;
        private System.Windows.Forms.ComboBox cboStationCapacity;
        private System.Windows.Forms.Button btnAddStation;
    }
}