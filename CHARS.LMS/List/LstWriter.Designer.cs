namespace CHARS.LMS.List
{
    partial class LstWriter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWriter = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriter)).BeginInit();
            this.SuspendLayout();
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvWriter);
            this.grbList.Enter += new System.EventHandler(this.grbList_Enter);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvWriter, 0);
            // 
            // btnSearch
            // 
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnHistory
            // 
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvWriter
            // 
            this.dgvWriter.AllowUserToAddRows = false;
            this.dgvWriter.AllowUserToDeleteRows = false;
            this.dgvWriter.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvWriter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWriter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWriter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWriter.Location = new System.Drawing.Point(3, 16);
            this.dgvWriter.MultiSelect = false;
            this.dgvWriter.Name = "dgvWriter";
            this.dgvWriter.ReadOnly = true;
            this.dgvWriter.RowHeadersVisible = false;
            this.dgvWriter.RowTemplate.Height = 24;
            this.dgvWriter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWriter.Size = new System.Drawing.Size(778, 374);
            this.dgvWriter.TabIndex = 20;
            // 
            // LstWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Name = "LstWriter";
            this.Text = "LstWriter";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWriter;
    }
}