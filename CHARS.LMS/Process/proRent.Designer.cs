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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.dgvtxtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbtnAddBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvtxtRentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(760, 657);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.txtAdress);
            this.grbList.Controls.Add(this.dgvRent);
            this.grbList.Controls.Add(this.dtpRentDate);
            this.grbList.Controls.Add(this.txtMemberID);
            this.grbList.Controls.Add(this.txtRemark);
            this.grbList.Controls.Add(this.txtRentID);
            this.grbList.Controls.Add(this.label5);
            this.grbList.Controls.Add(this.label4);
            this.grbList.Controls.Add(this.label3);
            this.grbList.Controls.Add(this.label2);
            this.grbList.Controls.Add(this.label1);
            this.grbList.Size = new System.Drawing.Size(760, 657);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.label1, 0);
            this.grbList.Controls.SetChildIndex(this.label2, 0);
            this.grbList.Controls.SetChildIndex(this.label3, 0);
            this.grbList.Controls.SetChildIndex(this.label4, 0);
            this.grbList.Controls.SetChildIndex(this.label5, 0);
            this.grbList.Controls.SetChildIndex(this.txtRentID, 0);
            this.grbList.Controls.SetChildIndex(this.txtRemark, 0);
            this.grbList.Controls.SetChildIndex(this.txtMemberID, 0);
            this.grbList.Controls.SetChildIndex(this.dtpRentDate, 0);
            this.grbList.Controls.SetChildIndex(this.dgvRent, 0);
            this.grbList.Controls.SetChildIndex(this.txtAdress, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(84, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(-3, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(607, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(259, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(521, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 611);
            this.grbControl.Size = new System.Drawing.Size(754, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(172, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(435, 14);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rent ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rent Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remark ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // txtRentID
            // 
            this.txtRentID.Location = new System.Drawing.Point(82, 23);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(203, 20);
            this.txtRentID.TabIndex = 10;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(82, 107);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(203, 29);
            this.txtRemark.TabIndex = 13;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(82, 49);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(203, 20);
            this.txtMemberID.TabIndex = 14;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(82, 75);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(203, 20);
            this.dtpRentDate.TabIndex = 15;
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtBookID,
            this.dgvbtnAddBook,
            this.dgvtxtRentDate,
            this.dgvtxtExpireDate,
            this.dgvtxtStatus});
            this.dgvRent.Location = new System.Drawing.Point(16, 204);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.Size = new System.Drawing.Size(732, 401);
            this.dgvRent.TabIndex = 17;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(82, 141);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(203, 57);
            this.txtAdress.TabIndex = 18;
            // 
            // dgvtxtBookID
            // 
            this.dgvtxtBookID.HeaderText = "Book ID";
            this.dgvtxtBookID.Name = "dgvtxtBookID";
            // 
            // dgvbtnAddBook
            // 
            this.dgvbtnAddBook.HeaderText = "Add Book";
            this.dgvbtnAddBook.Name = "dgvbtnAddBook";
            // 
            // dgvtxtRentDate
            // 
            this.dgvtxtRentDate.HeaderText = "Rent Date";
            this.dgvtxtRentDate.Name = "dgvtxtRentDate";
            this.dgvtxtRentDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtRentDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtExpireDate
            // 
            this.dgvtxtExpireDate.HeaderText = "ExpireDate";
            this.dgvtxtExpireDate.Name = "dgvtxtExpireDate";
            this.dgvtxtExpireDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtExpireDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtStatus
            // 
            this.dgvtxtStatus.HeaderText = "Status";
            this.dgvtxtStatus.Name = "dgvtxtStatus";
            // 
            // proRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 657);
            this.Name = "proRent";
            this.Text = "proRent";
            this.Load += new System.EventHandler(this.proRent_Load);
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBookID;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnAddBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStatus;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}