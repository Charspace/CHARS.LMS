namespace CHARS.LMS.Setup
{
    partial class SetPublisher
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(7, 18);
            this.pan.Size = new System.Drawing.Size(447, 154);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(442, 151);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.txtDescription);
            this.grbEntryData.Controls.Add(this.txtCode);
            this.grbEntryData.Controls.Add(this.label1);
            this.grbEntryData.Controls.Add(this.label2);
            this.grbEntryData.Size = new System.Drawing.Size(432, 93);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(2, 107);
            this.grbControl.Size = new System.Drawing.Size(434, 40);
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
            this.btnClose.Location = new System.Drawing.Point(349, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(205, -1);
            this.lblHeader.Size = new System.Drawing.Size(60, 16);
            this.lblHeader.Text = "Publisher";
            this.lblHeader.Visible = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtDescription.Location = new System.Drawing.Point(101, 46);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 21);
            this.txtDescription.TabIndex = 66;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtCode.Location = new System.Drawing.Point(101, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(304, 21);
            this.txtCode.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "Code :";
            // 
            // SetPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 183);
            this.Name = "SetPublisher";
            this.Text = "SetPublisher";
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

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}