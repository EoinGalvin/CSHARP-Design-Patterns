namespace RestaurantSystem.PresentationLayer
{
    partial class frmCancelReservation
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
            this.dgvCancelReservation = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cboResID = new System.Windows.Forms.ComboBox();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCancelReservation
            // 
            this.dgvCancelReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCancelReservation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCancelReservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCancelReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelReservation.Location = new System.Drawing.Point(12, 12);
            this.dgvCancelReservation.Name = "dgvCancelReservation";
            this.dgvCancelReservation.Size = new System.Drawing.Size(776, 328);
            this.dgvCancelReservation.TabIndex = 4;
            this.dgvCancelReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelReservation_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 377);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(175, 377);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 20);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(258, 377);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(77, 20);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cboResID
            // 
            this.cboResID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResID.FormattingEnabled = true;
            this.cboResID.Location = new System.Drawing.Point(446, 376);
            this.cboResID.Name = "cboResID";
            this.cboResID.Size = new System.Drawing.Size(121, 21);
            this.cboResID.TabIndex = 12;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(446, 418);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(121, 20);
            this.btnCancelReservation.TabIndex = 13;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // frmCancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.cboResID);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvCancelReservation);
            this.Name = "frmCancelReservation";
            this.Text = "Cancel Reservation";
            this.Load += new System.EventHandler(this.frmCancelReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCancelReservation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cboResID;
        private System.Windows.Forms.Button btnCancelReservation;
    }
}