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
    public partial class SetPublishTime : SetBase
    {
         Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        CHARS.LMS.BOL.PublishTimes mPublishTimes = new CHARS.LMS.BOL.PublishTimes();    
        private bool saveState = true;
    
  
        public SetPublishTime()
        {
            InitializeComponent();
            clearUI();
            loadReference();            
            saveState = true;
            controlUI();            
        }
        public SetPublishTime(long aASK)
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
                mPublishTimes = new CHARS.LMS.BOL.PublishTimes();
                mPublishTimes.Ask = aAsk.ToString();
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("LMS_Category", mCategory);
                mPublishTimes = (PublishTimes)mMasterBLL.selectObjbyAskobj("LMS_Publish_Time", mPublishTimes);               
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
                if (mPublishTimes.Ask == "0")
                {
                    mPublishTimes.Ask = mUtility.getStrAsk().ToString();
                }
                mPublishTimes.Code = txtCode.Text.Trim();
                mPublishTimes.Description = txtDescription.Text.Trim();
                mPublishTimes.TS = ApplicationMember.mUserLevel;
                mPublishTimes.UD  = ApplicationMember.mLoginUserAsk;                               
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
                mUtility.clearTextBox(txtCode, txtDescription);
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
                txtCode.Text = mPublishTimes.Code;
                txtDescription.Text = mPublishTimes.Description;
               // txtDispalySequence.Text = mPublisher.DisplaySequence;                               
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
                //mPublishTimes = CHARS.LMS.BOL.PublishTimes();
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

                        if (mMasterBLL.saveObj("LMS_Publish_Time", mPublishTimes))
                        {
                            //lblHeader.Text = Constant.save_successful_message;                           
                            MessageBox.Show(Constant.save_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            saveState = false;
                        }
                    }
                    else
                    {

                        if (mMasterBLL.updateObj("LMS_Publish_Time", mPublishTimes))
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
                    if (mMasterBLL.deleteObj("LMS_Publish_Time", mPublishTimes, 1))
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




    }
}