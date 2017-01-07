namespace CHARS.LMS.Setup
{
    partial class setRent
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
            this.dgvSetRent = new System.Windows.Forms.DataGridView();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvailableBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetRent)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(758, 454);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(740, 442);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.cboMemberID);
            this.grbEntryData.Controls.Add(this.dtpRentDate);
            this.grbEntryData.Controls.Add(this.label5);
            this.grbEntryData.Controls.Add(this.txtAvailableBook);
            this.grbEntryData.Controls.Add(this.label4);
            this.grbEntryData.Controls.Add(this.label3);
            this.grbEntryData.Controls.Add(this.label2);
            this.grbEntryData.Controls.Add(this.txtRemark);
            this.grbEntryData.Controls.Add(this.label1);
            this.grbEntryData.Controls.Add(this.txtRentID);
            this.grbEntryData.Controls.Add(this.dgvSetRent);
            this.grbEntryData.Size = new System.Drawing.Size(730, 362);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 377);
            this.grbControl.Size = new System.Drawing.Size(730, 47);
            this.grbControl.Enter += new System.EventHandler(this.grbControl_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(173, 18);
            this.toolTipbase.SetToolTip(this.btnDelete, "Click to delete");
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(2, 18);
            this.toolTipbase.SetToolTip(this.btnNew, "Click to prepare new item");
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 18);
            this.toolTipbase.SetToolTip(this.btnSave, "Click to save");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(645, 17);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(70, 16);
            this.lblHeader.Text = "Rent Setup";
            // 
            // dgvSetRent
            // 
            this.dgvSetRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetRent.Location = new System.Drawing.Point(6, 148);
            this.dgvSetRent.Name = "dgvSetRent";
            this.dgvSetRent.Size = new System.Drawing.Size(718, 208);
            this.dgvSetRent.TabIndex = 0;
            // 
            // cboMemberID
            // 
            this.cboMemberID.BackColor = System.Drawing.Color.AliceBlue;
            this.cboMemberID.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(98, 35);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(200, 23);
            this.cboMemberID.TabIndex = 26;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpRentDate.Location = new System.Drawing.Point(98, 58);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(200, 21);
            this.dtpRentDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Available Book";
            // 
            // txtAvailableBook
            // 
            this.txtAvailableBook.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAvailableBook.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtAvailableBook.Location = new System.Drawing.Point(98, 105);
            this.txtAvailableBook.Name = "txtAvailableBook";
            this.txtAvailableBook.Size = new System.Drawing.Size(200, 21);
            this.txtAvailableBook.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Remark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rent Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Member ID";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRemark.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtRemark.Location = new System.Drawing.Point(98, 79);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 21);
            this.txtRemark.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "RentID";
            // 
            // txtRentID
            // 
            this.txtRentID.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRentID.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtRentID.Location = new System.Drawing.Point(98, 12);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(200, 21);
            this.txtRentID.TabIndex = 17;
            // 
            // setRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 517);
            this.Name = "setRent";
            this.Text = "setRent";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.setRent_Load);
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSetRent;
        private System.Windows.Forms.ComboBox cboMemberID;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvailableBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRentID;
    }
}