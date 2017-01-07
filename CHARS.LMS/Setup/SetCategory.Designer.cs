namespace CHARS.LMS.Setup
{
    partial class SetCategory
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
            this.txtDispalySequence = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbllibraryCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(4, 19);
            this.pan.Size = new System.Drawing.Size(419, 190);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(413, 187);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.label2);
            this.grbEntryData.Controls.Add(this.label1);
            this.grbEntryData.Controls.Add(this.lbllibraryCode);
            this.grbEntryData.Controls.Add(this.txtDispalySequence);
            this.grbEntryData.Controls.Add(this.txtDescription);
            this.grbEntryData.Controls.Add(this.txtCode);
            this.grbEntryData.Size = new System.Drawing.Size(404, 128);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 142);
            this.grbControl.Size = new System.Drawing.Size(406, 40);
            // 
            // btnDelete
            // 
            this.toolTipbase.SetToolTip(this.btnDelete, "Click to delete");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnClose.Location = new System.Drawing.Point(321, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(193, 1);
            this.lblHeader.Size = new System.Drawing.Size(59, 16);
            this.lblHeader.Text = "Category";
            this.lblHeader.Visible = true;
            // 
            // txtDispalySequence
            // 
            this.txtDispalySequence.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDispalySequence.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.txtDispalySequence.Location = new System.Drawing.Point(146, 68);
            this.txtDispalySequence.Name = "txtDispalySequence";
            this.txtDispalySequence.Size = new System.Drawing.Size(230, 20);
            this.txtDispalySequence.TabIndex = 57;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(146, 41);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 21);
            this.txtDescription.TabIndex = 56;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.txtCode.Location = new System.Drawing.Point(146, 17);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(230, 20);
            this.txtCode.TabIndex = 55;
            // 
            // lbllibraryCode
            // 
            this.lbllibraryCode.AutoSize = true;
            this.lbllibraryCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllibraryCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllibraryCode.Location = new System.Drawing.Point(8, 19);
            this.lbllibraryCode.Name = "lbllibraryCode";
            this.lbllibraryCode.Size = new System.Drawing.Size(85, 15);
            this.lbllibraryCode.TabIndex = 100;
            this.lbllibraryCode.Text = "Category Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 101;
            this.label1.Text = "Category Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 102;
            this.label2.Text = "Display Sequence :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SetCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 217);
            this.Name = "SetCategory";
            this.Text = "SetCategory";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDispalySequence;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbllibraryCode;
    }
}