namespace CHARS.LMS.List
{
    partial class LstPublisher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvPublisher);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvPublisher, 0);
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
            // dgvPublisher
            // 
            this.dgvPublisher.AllowUserToAddRows = false;
            this.dgvPublisher.AllowUserToDeleteRows = false;
            this.dgvPublisher.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPublisher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPublisher.Location = new System.Drawing.Point(3, 16);
            this.dgvPublisher.MultiSelect = false;
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.RowHeadersVisible = false;
            this.dgvPublisher.RowTemplate.Height = 24;
            this.dgvPublisher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublisher.Size = new System.Drawing.Size(778, 374);
            this.dgvPublisher.TabIndex = 21;
            this.dgvPublisher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellDoubleClick);
            // 
            // LstPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Name = "LstPublisher";
            this.Text = "LstPublisher";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublisher;
    }
}