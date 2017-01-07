namespace CHARS.LMS.Setup
{
    partial class SetWriter
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
            this.txtWritername = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(5, 19);
            this.pan.Size = new System.Drawing.Size(381, 178);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(378, 174);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.txtScriptName);
            this.grbEntryData.Controls.Add(this.label3);
            this.grbEntryData.Controls.Add(this.txtWritername);
            this.grbEntryData.Controls.Add(this.txtCode);
            this.grbEntryData.Controls.Add(this.label2);
            this.grbEntryData.Controls.Add(this.label1);
            this.grbEntryData.Size = new System.Drawing.Size(371, 111);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 129);
            this.grbControl.Size = new System.Drawing.Size(363, 40);
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
            this.btnClose.Location = new System.Drawing.Point(278, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(181, 0);
            this.lblHeader.Size = new System.Drawing.Size(43, 16);
            this.lblHeader.Text = "Writer";
            this.lblHeader.Visible = true;
            // 
            // txtWritername
            // 
            this.txtWritername.BackColor = System.Drawing.Color.AliceBlue;
            this.txtWritername.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtWritername.Location = new System.Drawing.Point(105, 42);
            this.txtWritername.Name = "txtWritername";
            this.txtWritername.Size = new System.Drawing.Size(245, 21);
            this.txtWritername.TabIndex = 58;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtCode.Location = new System.Drawing.Point(105, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(245, 21);
            this.txtCode.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Writer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Writer Code :";
            // 
            // txtScriptName
            // 
            this.txtScriptName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtScriptName.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtScriptName.Location = new System.Drawing.Point(105, 68);
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(245, 21);
            this.txtScriptName.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "Script Name :";
            // 
            // SetWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(395, 207);
            this.Name = "SetWriter";
            this.Text = "SetWriter";
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

        private System.Windows.Forms.TextBox txtWritername;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.Label label3;
    }
}