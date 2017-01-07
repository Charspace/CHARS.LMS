namespace CHARS.LMS.List
{
    partial class LstRent
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
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvailableBook = new System.Windows.Forms.TextBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(826, 393);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvRent);
            this.grbList.Controls.Add(this.cboMemberID);
            this.grbList.Controls.Add(this.dtpRentDate);
            this.grbList.Controls.Add(this.label5);
            this.grbList.Controls.Add(this.txtAvailableBook);
            this.grbList.Controls.Add(this.label4);
            this.grbList.Controls.Add(this.label3);
            this.grbList.Controls.Add(this.label2);
            this.grbList.Controls.Add(this.txtRemark);
            this.grbList.Controls.Add(this.label1);
            this.grbList.Controls.Add(this.txtRentID);
            this.grbList.Size = new System.Drawing.Size(826, 393);
            this.grbList.Controls.SetChildIndex(this.txtRentID, 0);
            this.grbList.Controls.SetChildIndex(this.label1, 0);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.txtRemark, 0);
            this.grbList.Controls.SetChildIndex(this.label2, 0);
            this.grbList.Controls.SetChildIndex(this.label3, 0);
            this.grbList.Controls.SetChildIndex(this.label4, 0);
            this.grbList.Controls.SetChildIndex(this.txtAvailableBook, 0);
            this.grbList.Controls.SetChildIndex(this.label5, 0);
            this.grbList.Controls.SetChildIndex(this.dtpRentDate, 0);
            this.grbList.Controls.SetChildIndex(this.cboMemberID, 0);
            this.grbList.Controls.SetChildIndex(this.dgvRent, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(434, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(171, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(84, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(694, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(346, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(608, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 347);
            this.grbControl.Size = new System.Drawing.Size(820, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(259, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(522, 14);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtRentID
            // 
            this.txtRentID.Location = new System.Drawing.Point(99, 16);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(200, 20);
            this.txtRentID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RentID";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(99, 83);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 20);
            this.txtRemark.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rent Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Remark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Available Book";
            // 
            // txtAvailableBook
            // 
            this.txtAvailableBook.Location = new System.Drawing.Point(99, 109);
            this.txtAvailableBook.Name = "txtAvailableBook";
            this.txtAvailableBook.Size = new System.Drawing.Size(200, 20);
            this.txtAvailableBook.TabIndex = 13;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Location = new System.Drawing.Point(99, 62);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpRentDate.TabIndex = 15;
            // 
            // cboMemberID
            // 
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(99, 39);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(200, 21);
            this.cboMemberID.TabIndex = 16;
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(15, 138);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.Size = new System.Drawing.Size(765, 203);
            this.dgvRent.TabIndex = 17;
            // 
            // LstRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 393);
            this.Name = "LstRent";
            this.Text = "LstRent";
            this.Load += new System.EventHandler(this.LstRent_Load);
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.ComboBox cboMemberID;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvailableBook;
        private System.Windows.Forms.DataGridView dgvRent;
    }
}