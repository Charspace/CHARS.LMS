using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.General;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.COMMON.BOL;
using CHARS.HR.COMMON.BOL.SYS;
using CHARS.LMS.Setup;
using CHARS.LMS.BOL;

namespace CHARS.LMS.List
{
    public partial class LstRent : LstBase
    {
        MasterBLL mMasterBLL = new MasterBLL();
        Utility mUtility = new Utility();
        RentHeaderInfo mRent = new RentHeaderInfo();
        Member mMember = new Member();
        CHARS.LMS.Process.proRent msetRent = new CHARS.LMS.Process.proRent();

        public LstRent()
        {
            InitializeComponent();
            loadReference();
            loadGrid();
           
            //setToolTip();
        }

        private void loadGrid()
        {
            try
            {
                DataTable mm = new DataTable();
                dgvRent.DataSource = mMasterBLL.selectDataTable("LMS_Tra_Rent_Header", "");
                mUtility.setDataGridColumn(ref dgvRent);
                //dgvRent.Columns[17].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadReference()
        {
          
         
          

        }

        private bool isValid()
        {
            try
            {
                bool valid = true;
                //errorProvider1.Clear();
                //if (cboMemberID.SelectedIndex == -1 || cboMemberID.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorProvider1, cboMemberID);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorProvider1, cboMemberID);
                //}
              
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void bindLObj()
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bindUI()
        {
            try
            {
                
                //txtCode.Text = mBook.Code;
                //txtDescription.Text = mBook.Description;
                //cboCategory.SelectedValue = mBook.Category;
                //cboWriter.SelectedValue = mBook.Writer;
                //cboPublisher.SelectedValue = mBook.Publisher;
                //cboPublishTimes.SelectedValue = mBook.PublishTimes;
                //dtpPublishDate.Value = Utility.getDateVale(mBook.PublishDate);
                //cboBookStatus.SelectedValue = mBook.BookStatus;
                //txtRentDuration.Text = mBook.RentDuration;
                //txtDonator.Text = mBook.Donator;
                //dtpDonationDate.Value = Utility.getDateVale(mBook.DonationDate);
                //txtBookValue.Text = mBook.BookValue;
                //txtRemark.Text = mBook.Remark;
                //ptBImage.Image = null;                
                //byte[] mPicture = new byte[50];
                //mPicture = Convert.ToByte(mBook.Picture);
                //ptBImage.Image = mPicture;   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void LstRent_Load(object sender, EventArgs e)
        {

        }

        private void clearUI()
        {
            try
            {
                // mUtility.clearTextBox(txtMenuName, txtMenuUrl, txtMenuPannel, txtMenuTab,txtMenuClass,txtMenuDisplaySequence);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {            
            try
            {
                
                //txtRentID.Clear();
                //txtRentID.Focus();
                //txtAvailableBook.Clear();
                //txtRemark.Clear();
                //mBook = Book();
                clearUI();
                //loadReference();
                //setSampledata();
                //setToolTip();      
               
                msetRent = new CHARS.LMS.Process.proRent();
                msetRent.ShowDialog();
                if (msetRent.DialogResult == DialogResult.Cancel)
                {
                    loadGrid();
                }

                ContentMenuUtil contentMenu = new ContentMenuUtil(new LstMenu());
                contentMenu.createContentMenu(ref pan, "go");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}