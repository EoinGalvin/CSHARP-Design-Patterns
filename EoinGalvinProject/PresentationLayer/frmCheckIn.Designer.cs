namespace RestaurantSystem.PresentationLayer
{
    partial class frmCheckIn
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
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.cboResID = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckIn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Location = new System.Drawing.Point(12, 12);
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.Size = new System.Drawing.Size(776, 328);
            this.dgvCheckIn.TabIndex = 5;
            this.dgvCheckIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIn_CellClick);
            // 
            // cboResID
            // 
            this.cboResID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResID.FormattingEnabled = true;
            this.cboResID.Location = new System.Drawing.Point(12, 374);
            this.cboResID.Name = "cboResID";
            this.cboResID.Size = new System.Drawing.Size(121, 21);
            this.cboResID.TabIndex = 13;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(139, 374);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(121, 21);
            this.btnCheckIn.TabIndex = 14;
            this.btnCheckIn.Text = "Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.cboResID);
            this.Controls.Add(this.dgvCheckIn);
            this.Name = "frmCheckIn";
            this.Text = "Reservation Check-In";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.ComboBox cboResID;
        private System.Windows.Forms.Button btnCheckIn;
    }
}