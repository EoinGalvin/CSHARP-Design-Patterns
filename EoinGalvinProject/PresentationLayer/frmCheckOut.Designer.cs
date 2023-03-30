namespace RestaurantSystem.PresentationLayer
{
    partial class frmCheckOut
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
            this.dgvCheckOut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboResID = new System.Windows.Forms.ComboBox();
            this.nudTotalCost = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalCost)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckOut
            // 
            this.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckOut.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckOut.Location = new System.Drawing.Point(12, 12);
            this.dgvCheckOut.Name = "dgvCheckOut";
            this.dgvCheckOut.Size = new System.Drawing.Size(776, 328);
            this.dgvCheckOut.TabIndex = 6;
            this.dgvCheckOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckOut_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reservation ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter Total cost:";
            // 
            // cboResID
            // 
            this.cboResID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResID.FormattingEnabled = true;
            this.cboResID.Location = new System.Drawing.Point(196, 360);
            this.cboResID.Name = "cboResID";
            this.cboResID.Size = new System.Drawing.Size(121, 21);
            this.cboResID.TabIndex = 24;
            // 
            // nudTotalCost
            // 
            this.nudTotalCost.DecimalPlaces = 2;
            this.nudTotalCost.Location = new System.Drawing.Point(196, 409);
            this.nudTotalCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTotalCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTotalCost.Name = "nudTotalCost";
            this.nudTotalCost.Size = new System.Drawing.Size(120, 20);
            this.nudTotalCost.TabIndex = 25;
            this.nudTotalCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(335, 409);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(74, 20);
            this.btnCheckOut.TabIndex = 26;
            this.btnCheckOut.Text = "Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.nudTotalCost);
            this.Controls.Add(this.cboResID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCheckOut);
            this.Name = "frmCheckOut";
            this.Text = "Reservation Check-out";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboResID;
        private System.Windows.Forms.NumericUpDown nudTotalCost;
        private System.Windows.Forms.Button btnCheckOut;
    }
}