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


namespace CHARS.LMS.Setup
{
    public partial class SetCategory : SetBase
    {
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        CHARS.LMS.BOL.Category mCategory = new CHARS.LMS.BOL.Category();    
        private bool saveState = true;
    
  
        public SetCategory()
        {
            InitializeComponent();
            clearUI();
            loadReference();            
            saveState = true;
            controlUI();            
        }
        public SetCategory(long aASK)
        {
            InitializeComponent();
            clearUI();
            loadReference();         
            bindForm(aASK);
            saveState = false;
            controlUI();           
        } 


        #region"Private Method"
        private void loadReference()
        {
                      
        }
        

        public void bindForm(long aAsk)
        {
            try
            {
                mCategory = new CHARS.LMS.BOL.Category();
                mCategory.Ask = aAsk.ToString();
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("LMS_Category", mCategory);
                mCategory = (Category)mMasterBLL.selectObjbyAskobj("LMS_Category", mCategory);               
                bindUI();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();
                if (txtCode.TextLength == 0 || txtCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtCode);
                }
                if (txtDispalySequence.TextLength == 0 || txtDispalySequence.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtDispalySequence);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtDispalySequence);
                }              
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
                if (mCategory.Ask == "0")
                {
                    mCategory.Ask = mUtility.getStrAsk().ToString();
                }
                mCategory.Code = txtCode.Text.Trim();
                mCategory.Description = txtDescription.Text.Trim();
                mCategory.TS = ApplicationMember.mUserLevel;
                mCategory.UD  = ApplicationMember.mLoginUserAsk;
                mCategory.DisplaySequence = txtDispalySequence.Text.Trim();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void clearUI()
        {
            try
            {
                mUtility.clearTextBox(txtCode, txtDescription, txtDispalySequence);
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
                txtCode.Text = mCategory.Code;
                txtDescription.Text = mCategory.Description;
                txtDispalySequence.Text = mCategory.DisplaySequence;                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        #endregion

        #region"Private Event"
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
               // mCategory = CHARS.LMS.BOL.Category();
                clearUI();               
                saveState = true;
                controlUI(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    bindLObj();
                    if (saveState)
                    {
                       
                        if (mMasterBLL.saveObj("LMS_Category", mCategory))
                        {
                            //lblHeader.Text = Constant.save_successful_message;                           
                            MessageBox.Show(Constant.save_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            saveState = false;
                        }
                    }
                    else
                    {

                        if (mMasterBLL.updateObj("LMS_Category", mCategory))
                        {                            
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(Constant.delete_successful_message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindLObj();
                    if (mMasterBLL.deleteObj("LMS_Category", mCategory, 1))
                    {
                        clearUI();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void setBook_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }




    }
}