using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.COMMON.BOL;
using CHARS.HR.COMMON.General;
using CHARS.LMS.BOL;
using CHARS.HR.COMMON;
using System.IO;

namespace CHARS.LMS.Process
{
    public partial class proRent : SetBase
    {
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        CHARS.LMS.BOL.RentHeaderInfo mReturnHeader = new RentHeaderInfo();
        CHARS.LMS.BOL.RentDetailInfo mReturnDetail = new RentDetailInfo();
        DataGridViewComboBoxColumn cmbBook = new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn cmbRentStatus = new DataGridViewComboBoxColumn();
        string CategoryName = "";

        public proRent()
        {
            InitializeComponent();
            Utility mUtility = new Utility();
            MasterBLL mMasterBLL = new MasterBLL();
            loadReference();
             
        }
        private bool saveState = true;

        private void loadReference()
        {
            loadMember();

        }

        private void clearUI()
        {
            try
            {
                mUtility.clearTextBox(txtRentID, txtRemark);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadMember()
        {
            cboMember.DisplayMember = "Member Code";
            cboMember.ValueMember = "ASK";
            cboMember.DataSource = mMasterBLL.selectDataTable("LMS_Member", "");
        }

        private void loadBook()
        {
            cmbBook.DisplayMember = "Description";
            cmbBook.ValueMember = "ASK";
            cmbBook.DataSource = mMasterBLL.selectDataTable("lms_book", "");

        }
        private void loadRentStatus()
        {
            cmbRentStatus.DisplayMember = "Description";
            cmbRentStatus.ValueMember = "ASK";
            cmbRentStatus.DataSource = mMasterBLL.selectDataTable("lms_Rent_Status", "");

        }

        private void loadCategory()
        {
            if (dgvRent.CurrentRow.Cells[1].Value != null)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@BookASK", dgvRent.CurrentCell.Value.ToString());
                DataTable dtCategory = mMasterBLL.executeSelectProcedure("GetCategory", dic);
                if (dtCategory.Rows.Count > 0)
                {
                    dgvRent.CurrentRow.Cells["Categorysyskey"].Value = dtCategory.Rows[0]["CategoryName"].ToString();

                }
            }

        }


        private void controlUI()
        {
            try
            {
                if (saveState)
                {
                    mUtility.visibleButton(false, btnDelete);
                }
                else
                {
                    mUtility.visibleButton(true, btnDelete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void proRent_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {

            loadBook();
            loadRentStatus();
            dgvRent.Columns.Add("Rentsyskey", "RentID");
            dgvRent.Columns.Add(cmbBook);
            cmbBook.Width = 250;
            dgvRent.Columns.Add("Categorysyskey", "Category");
            dgvRent.Columns.Add("RentDate", "RentDate");
            dgvRent.Columns.Add("ExpireDate", "ExpireDate");
            dgvRent.Columns.Add(cmbRentStatus);
            dgvRent.Columns.Add("ReturnDate", "ReturnDate");
            dgvRent.Columns.Add("OverDueDate", "OverDueDate");
            dgvRent.Columns[0].Visible = false;
            dgvRent.Columns["RentDate"].Resizable = DataGridViewTriState.False;
            dgvRent.Columns["Categorysyskey"].Resizable = DataGridViewTriState.False;
            dgvRent.Columns["ExpireDate"].Resizable = DataGridViewTriState.False;
            dgvRent.Columns["ReturnDate"].Resizable = DataGridViewTriState.False;
            dgvRent.Columns["OverDueDate"].Resizable = DataGridViewTriState.False;
            dgvRent.Columns[0].Resizable = DataGridViewTriState.False;
            cmbBook.Resizable = DataGridViewTriState.False;
            cmbBook.AutoComplete = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                //mBook = Book();
                clearUI();
                //loadReference();
                //setSampledata();
                //setToolTip();
                saveState = true;
                controlUI(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRent.CurrentRow.Cells[1].Value != null)
            {
                if (dgvRent.CurrentCell.OwningColumn == dgvRent.Columns["RentDate"])
                {
                    //Initialized a new DateTimePicker Control  
                    dgvdtpRentDate = new DateTimePicker();

                    //Adding DateTimePicker control into DataGridView   
                    dgvRent.Controls.Add(dgvdtpRentDate);

                    // Setting the format (i.e. 2014-10-10)  
                    dgvdtpRentDate.Format = DateTimePickerFormat.Short;

                    // It returns the retangular area that represents the Display area for a cell  
                    Rectangle oRectangle = dgvRent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    //Setting area for DateTimePicker Control  
                    dgvdtpRentDate.Size = new Size(oRectangle.Width, oRectangle.Height);

                    // Setting Location  
                    dgvdtpRentDate.Location = new Point(oRectangle.X, oRectangle.Y);

                    //// An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                    //dgvdtpRentDate.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                    //// An event attached to dateTimePicker Control which is fired when any date is selected  
                    //dgvdtpRentDate.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                    // Now make it visible  
                    dgvdtpRentDate.Visible = true;
                }
                else if (dgvRent.CurrentCell.OwningColumn == dgvRent.Columns["ExpireDate"])
                {
                    //Initialized a new DateTimePicker Control  
                    dgvdtpExpireDate = new DateTimePicker();

                    //Adding DateTimePicker control into DataGridView   
                    dgvRent.Controls.Add(dgvdtpExpireDate);

                    // Setting the format (i.e. 2014-10-10)  
                    dgvdtpExpireDate.Format = DateTimePickerFormat.Short;

                    // It returns the retangular area that represents the Display area for a cell  
                    Rectangle oRectangle = dgvRent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    //Setting area for DateTimePicker Control  
                    dgvdtpExpireDate.Size = new Size(oRectangle.Width, oRectangle.Height);

                    // Setting Location  
                    dgvdtpExpireDate.Location = new Point(oRectangle.X, oRectangle.Y);

                    //// An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                    //dgvdtpRentDate.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                    //// An event attached to dateTimePicker Control which is fired when any date is selected  
                    //dgvdtpRentDate.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                    // Now make it visible  
                    dgvdtpExpireDate.Visible = true;
                }
                else if (dgvRent.CurrentCell.OwningColumn == dgvRent.Columns["ReturnDate"])
                {
                    //Initialized a new DateTimePicker Control  
                    dgvdtpReturnDate = new DateTimePicker();

                    //Adding DateTimePicker control into DataGridView   
                    dgvRent.Controls.Add(dgvdtpReturnDate);

                    // Setting the format (i.e. 2014-10-10)  
                    dgvdtpReturnDate.Format = DateTimePickerFormat.Short;

                    // It returns the retangular area that represents the Display area for a cell  
                    Rectangle oRectangle = dgvRent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    //Setting area for DateTimePicker Control  
                    dgvdtpReturnDate.Size = new Size(oRectangle.Width, oRectangle.Height);

                    // Setting Location  
                    dgvdtpReturnDate.Location = new Point(oRectangle.X, oRectangle.Y);

                    //// An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                    //dgvdtpRentDate.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                    //// An event attached to dateTimePicker Control which is fired when any date is selected  
                    //dgvdtpRentDate.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                    // Now make it visible  
                    dgvdtpReturnDate.Visible = true;
                }
                else if (dgvRent.CurrentCell.OwningColumn == dgvRent.Columns["OverDueDate"])
                {
                    //Initialized a new DateTimePicker Control  
                    dgvdtpOverDueDate = new DateTimePicker();

                    //Adding DateTimePicker control into DataGridView   
                    dgvRent.Controls.Add(dgvdtpOverDueDate);

                    // Setting the format (i.e. 2014-10-10)  
                    dgvdtpOverDueDate.Format = DateTimePickerFormat.Short;

                    // It returns the retangular area that represents the Display area for a cell  
                    Rectangle oRectangle = dgvRent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    //Setting area for DateTimePicker Control  
                    dgvdtpOverDueDate.Size = new Size(oRectangle.Width, oRectangle.Height);

                    // Setting Location  
                    dgvdtpOverDueDate.Location = new Point(oRectangle.X, oRectangle.Y);

                    //// An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                    //dgvdtpRentDate.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                    //// An event attached to dateTimePicker Control which is fired when any date is selected  
                    //dgvdtpRentDate.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                    // Now make it visible  
                    dgvdtpOverDueDate.Visible = true;
                }
            }
        }

        private void dgvRent_Resize(object sender, EventArgs e)
        {

        }

        private void dgvRent_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvRent_ColumnDividerWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvRent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRent.CurrentCell == dgvRent.CurrentRow.Cells[1])
            {
                loadCategory();
            }
        }

        private void dgvRent_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRent.CurrentCell == dgvRent.CurrentRow.Cells[1])
            {
                loadCategory();
            }
        }

        private bool isValid()
        {
            return true;
        }
                
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
               
                    #region BindHeader
                    if (mReturnHeader.Ask == "0")
                    {
                        mReturnHeader.Ask = mUtility.getStrAsk().ToString();
                    }

                    mReturnHeader.TS = ApplicationMember.mUserLevel;
                    mReturnHeader.UD = ApplicationMember.mLoginUserAsk;
                    mReturnHeader.Code = txtRentID.Text.Trim();
                    mReturnHeader.MemberID = Convert.ToString(cboMember.SelectedValue);
                    mReturnHeader.RentDate = Utility.getDateString(dtpRentDate.Value);
                    mReturnHeader.Remark = txtRemark.Text;
                    #endregion

                    if (saveState)
                    {
                        //if (mMasterBLL.saveObj("SYS_MENU", mMenu))
                        if (mMasterBLL.saveObj("LMS_Tra_Rent_Header", mReturnHeader))
                        {
                            #region Bind and Save Detail
                            for(int i=0; i < dgvRent.Rows.Count; i++)

                            {
                                if (dgvRent.Rows[i].Cells[1].Value != null)
                                {
                                    if (mReturnDetail.Ask == "0")
                                    {
                                        mReturnDetail.Ask = mUtility.getStrAsk().ToString();
                                    }

                                    mReturnDetail.TS = ApplicationMember.mUserLevel;
                                    mReturnDetail.UD = ApplicationMember.mLoginUserAsk;
                                    mReturnDetail.BookID = Convert.ToString(dgvRent.Rows[i].Cells[1].Value);

                                    mReturnDetail.RentDate = Utility.getDateString(dgvdtpRentDate.Value);
                                    mReturnDetail.ExpireDate = Utility.getDateString(dgvdtpExpireDate.Value);
                                    mReturnDetail.RentStatus = Convert.ToString(dgvRent.Rows[i].Cells[5].Value);
                                    mReturnDetail.ReturnDate = Utility.getDateString(dgvdtpReturnDate.Value);
                                    mReturnDetail.OverDueDate = Utility.getDateString(dgvdtpOverDueDate.Value);

                                    if (mMasterBLL.saveObj("LMS_Tra_Rent_Detail", mReturnDetail))
                                    {
                                      
                                    }
                                }
                            }
                            lblHeader.Text = Constant.save_successful_message;
                            //this.Text = Constant.save_successful_message;
                            //lblHeader.Text = Constant.save_successful_message;
                            MessageBox.Show(Constant.save_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            saveState = false;
                            //mUtility.message(ref lblHeader);
                            #endregion


                        }
                    }
                    else
                    {
                        //if (mMasterBLL.updateObj("SYS_MENU", mMenu))
                        if (mMasterBLL.updateObj("LMS_Tra_Rent_Header", mReturnHeader))
                        {
                            lblHeader.Text = "";
                            //lblHeader.Text = Constant.update_successful_message;
                            //this.Text = Constant.update_successful_message;
                            //lblHeader.Text = Constant.update_successful_message;
                            MessageBox.Show(Constant.update_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            mUtility.message(ref lblHeader);

                        }
                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

         
    }
}
