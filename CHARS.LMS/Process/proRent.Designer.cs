namespace CHARS.LMS.Process
{
    partial class proRent
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
            this.cboMember = new System.Windows.Forms.ComboBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dgvdtpOverDueDate = new System.Windows.Forms.DateTimePicker();
            this.dgvdtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.dgvdtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(1009, 495);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(991, 495);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.dgvdtpReturnDate);
            this.grbEntryData.Controls.Add(this.dgvdtpExpireDate);
            this.grbEntryData.Controls.Add(this.dgvdtpOverDueDate);
            this.grbEntryData.Controls.Add(this.dgvdtpRentDate);
            this.grbEntryData.Controls.Add(this.cboMember);
            this.grbEntryData.Controls.Add(this.dgvRent);
            this.grbEntryData.Controls.Add(this.dtpRentDate);
            this.grbEntryData.Controls.Add(this.txtRemark);
            this.grbEntryData.Controls.Add(this.txtRentID);
            this.grbEntryData.Controls.Add(this.label4);
            this.grbEntryData.Controls.Add(this.label3);
            this.grbEntryData.Controls.Add(this.label2);
            this.grbEntryData.Controls.Add(this.label1);
            this.grbEntryData.Size = new System.Drawing.Size(968, 403);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 441);
            // 
            // btnDelete
            // 
            this.toolTipbase.SetToolTip(this.btnDelete, "Click to delete");
            // 
            // btnNew
            // 
            this.toolTipbase.SetToolTip(this.btnNew, "Click to prepare new item");
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.toolTipbase.SetToolTip(this.btnSave, "Click to save");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // cboMember
            // 
            this.cboMember.FormattingEnabled = true;
            this.cboMember.Location = new System.Drawing.Point(83, 39);
            this.cboMember.Name = "cboMember";
            this.cboMember.Size = new System.Drawing.Size(203, 23);
            this.cboMember.TabIndex = 27;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(83, 66);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(203, 23);
            this.dtpRentDate.TabIndex = 25;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(83, 98);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(203, 29);
            this.txtRemark.TabIndex = 24;
            // 
            // txtRentID
            // 
            this.txtRentID.Location = new System.Drawing.Point(83, 14);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(203, 23);
            this.txtRentID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Remark ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rent Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rent ID";
            // 
            // dgvdtpRentDate
            // 
            this.dgvdtpRentDate.Location = new System.Drawing.Point(469, 14);
            this.dgvdtpRentDate.Name = "dgvdtpRentDate";
            this.dgvdtpRentDate.Size = new System.Drawing.Size(190, 23);
            this.dgvdtpRentDate.TabIndex = 28;
            this.dgvdtpRentDate.Visible = false;
            // 
            // dgvdtpOverDueDate
            // 
            this.dgvdtpOverDueDate.Location = new System.Drawing.Point(469, 72);
            this.dgvdtpOverDueDate.Name = "dgvdtpOverDueDate";
            this.dgvdtpOverDueDate.Size = new System.Drawing.Size(190, 23);
            this.dgvdtpOverDueDate.TabIndex = 29;
            this.dgvdtpOverDueDate.Visible = false;
            // 
            // dgvdtpExpireDate
            // 
            this.dgvdtpExpireDate.Location = new System.Drawing.Point(469, 43);
            this.dgvdtpExpireDate.Name = "dgvdtpExpireDate";
            this.dgvdtpExpireDate.Size = new System.Drawing.Size(190, 23);
            this.dgvdtpExpireDate.TabIndex = 30;
            this.dgvdtpExpireDate.Visible = false;
            // 
            // dgvdtpReturnDate
            // 
            this.dgvdtpReturnDate.Location = new System.Drawing.Point(469, 95);
            this.dgvdtpReturnDate.Name = "dgvdtpReturnDate";
            this.dgvdtpReturnDate.Size = new System.Drawing.Size(190, 23);
            this.dgvdtpReturnDate.TabIndex = 31;
            this.dgvdtpReturnDate.Visible = false;
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(6, 132);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.Size = new System.Drawing.Size(946, 271);
            this.dgvRent.TabIndex = 26;
            this.dgvRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellClick);
            this.dgvRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellContentClick);
            this.dgvRent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellEndEdit);
            this.dgvRent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellEnter);
            this.dgvRent.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellLeave);
            this.dgvRent.ColumnDividerWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvRent_ColumnDividerWidthChanged);
            this.dgvRent.ColumnHeaderCellChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvRent_ColumnHeaderCellChanged);
            this.dgvRent.Resize += new System.EventHandler(this.dgvRent_Resize);
            // 
            // proRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 541);
            this.Name = "proRent";
            this.Text = "proRent";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.proRent_Load);
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMember;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dgvdtpRentDate;
        private System.Windows.Forms.DateTimePicker dgvdtpExpireDate;
        private System.Windows.Forms.DateTimePicker dgvdtpOverDueDate;
        private System.Windows.Forms.DateTimePicker dgvdtpReturnDate;
        private System.Windows.Forms.DataGridView dgvRent;
    }
}