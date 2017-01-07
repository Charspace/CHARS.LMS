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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace CHARS.LMS.Setup
{
    public partial class setBook :SetBase 
    {
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        Book mBook = new Book();
    
        private bool saveState = true;
    
  
        public setBook()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            saveState = true;
            controlUI();
            mBook = new Book();
        }
        public setBook(long aASK)
        {
            InitializeComponent();
            clearUI();
            loadReference();            
            bindForm(aASK);
            saveState = false;
            controlUI();           
        } 


        #region"Private Method"
        public static byte[] imageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void loadReference()
        {
            loadLibrary();
            loadCategory();
            loadWriter();
            loadPublisher();
            loadPublishTime();
           
        }
        private void loadLibrary()
        {
            cboLibrary.DisplayMember = "Code";
            cboLibrary.ValueMember = "ASK";
            cboLibrary.DataSource = mMasterBLL.selectDataTable("LMS_Library", "");
        }
        private void loadCategory()
        {
            cboCategory.DisplayMember = "Category Code";
            cboCategory.ValueMember = "ASK";
            cboCategory.DataSource = mMasterBLL.selectDataTable("LMS_Category", "");
        }
        private void loadWriter()
        {
            cboWriter.DisplayMember = "Writer Code";
            cboWriter.ValueMember = "ASK";
            cboWriter.DataSource = mMasterBLL.selectDataTable("lMS_Writer", "");
        }
        private void loadPublisher()
        {
            cboPublisher.DisplayMember = "Publisher Code";
            cboPublisher.ValueMember = "ASK";
            cboPublisher.DataSource = mMasterBLL.selectDataTable("LMS_Publish", "");
        }
        private void loadPublishTime()
        {
            cboPublishTimes.DisplayMember = "Publish Time";
            cboPublishTimes.ValueMember = "ASK";
            cboPublishTimes.DataSource = mMasterBLL.selectDataTable("LMS_Publish_Time", "");
        }

        public void bindForm(long aAsk)
        {
            try
            {
                mBook = new Book();
                mBook.Ask = aAsk.ToString();
                DataTable l_databale = new DataTable();
                l_databale = mMasterBLL.Findby("LMS_Book", mBook);
                mBook = (Book)mMasterBLL.selectObjbyAskobj("LMS_Book", mBook);               
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
                if (cboLibrary.SelectedIndex == -1 || cboLibrary.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboLibrary);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboLibrary);
                }
                if (cboCategory.SelectedIndex == -1 || cboCategory.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboCategory);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboCategory);
                }

                if (cboWriter.SelectedIndex == -1 || cboWriter.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboWriter);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboWriter);
                }


                if (cboPublisher.SelectedIndex == -1 || cboPublisher.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPublisher);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboPublisher);
                }


                if (cboPublishTimes.SelectedIndex == -1 || cboPublishTimes.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPublishTimes);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboPublishTimes);
                }

                if (cboBookStatus.SelectedIndex == -1 || cboBookStatus.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboBookStatus);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboBookStatus);
                }
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
                if (mBook.Ask == "0")
                {
                    mBook.Ask = mUtility.getStrAsk().ToString();
                }
                mBook.TS = ApplicationMember.mUserLevel;
                mBook.UD = ApplicationMember.mLoginUserAsk;
                mBook.Code = txtCode.Text.Trim();
                mBook.Library = cboLibrary.SelectedValue.ToString() ;
                mBook.Category = cboCategory.SelectedValue.ToString();
                mBook.Writer = cboWriter.SelectedValue.ToString();
                mBook.Publisher = cboPublisher.SelectedValue.ToString();
                mBook.PublishTimes = cboPublishTimes.SelectedValue.ToString();
                mBook.Description = txtDescription.Text.Trim();
                mBook.PublishDate = Utility.getDateString(dtpDonationDate.Value);
                mBook.BookStatus = cboBookStatus.SelectedIndex.ToString();
                mBook.RentDuration = txtRentDuration.Text.Trim();
                mBook.Donator = txtDonator.Text.Trim();
                mBook.DonationDate = Utility.getDateString(dtpDonationDate.Value);
                mBook.BookValue = txtBookValue.Text.Trim();
                mBook.Remark = txtRemark.Text.Trim();
                if (ptBImage.Image == null)
                {
                    mBook.Picture = null;
                }
                else
                {
                    mBook.Picture = Convert.ToString(imageToByteArray(ptBImage.Image));
                }
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
               // mUtility.clearTextBox(txtMenuName, txtMenuUrl, txtMenuPannel, txtMenuTab,txtMenuClass,txtMenuDisplaySequence);
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
                cboLibrary.SelectedValue = mBook.Library;
                txtCode.Text = mBook.Code;
                txtDescription.Text = mBook.Description;
                cboCategory.SelectedValue = mBook.Category;
                cboWriter.SelectedValue = mBook.Writer;
                cboPublisher.SelectedValue = mBook.Publisher;
                cboPublishTimes.SelectedValue = mBook.PublishTimes;
                dtpPublishDate.Value = Utility.getDateVale(mBook.PublishDate);
                cboBookStatus.SelectedValue = mBook.BookStatus;
                txtRentDuration.Text = mBook.RentDuration;
                txtDonator.Text = mBook.Donator;
                dtpDonationDate.Value = Utility.getDateVale(mBook.DonationDate);
                txtBookValue.Text = mBook.BookValue;
                txtRemark.Text = mBook.Remark;
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
        private void setToolTip()
        {
            try
            {
               // toolTipbase.SetToolTip(txtMenuName, mAgentToolTip.AgentCode);
                //toolTipbase.SetToolTip(txtAgentCode, mAgentToolTip.AgentCode);
                //toolTipbase.SetToolTip(txtAgentDescription, mAgentToolTip.AgentDescription);
                //toolTipbase.SetToolTip(txtAgentPhone, mAgentToolTip.AgentPhone);
                //toolTipbase.SetToolTip(rtxtAgentAddress, mAgentToolTip.AgentAddress);
                //toolTipbase.SetToolTip(txtAgentEmail, mAgentToolTip.AgentEmail);
                //toolTipbase.SetToolTip(rtxtAgentRemark, mAgentToolTip.AgentRemark);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void setSampledata()
        {
            try
            {
                //mUtility.setComboBoxSampleData(cboPerson, mAgentSample.PersonAsk);
                //mUtility.setTextBoxSampleData(txtAgentCode, mAgentSample.AgentCode);
                //mUtility.setTextBoxSampleData(txtAgentDescription, mAgentSample.AgentDescription);
                //mUtility.setTextBoxSampleData(txtAgentPhone, mAgentSample.AgentPhone);
                //mUtility.setRichTextBoxSampleData(rtxtAgentAddress, mAgentSample.AgentAddress);
                //mUtility.setTextBoxSampleData(txtAgentEmail, mAgentSample.AgentEmail);
                //mUtility.setRichTextBoxSampleData(rtxtAgentRemark, mAgentSample.AgentRemark);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    bindLObj();
                    if (saveState)
                    {
                        //if (mMasterBLL.saveObj("SYS_MENU", mMenu))
                        if (mMasterBLL.saveObj("LMS_Book", mBook))
                        {
                            lblHeader.Text = Constant.save_successful_message;
                            //this.Text = Constant.save_successful_message;
                            //lblHeader.Text = Constant.save_successful_message;
                            MessageBox.Show(Constant.save_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            saveState = false;
                           //mUtility.message(ref lblHeader);
                        }
                    }
                    else
                    {
                        //if (mMasterBLL.updateObj("SYS_MENU", mMenu))
                        if (mMasterBLL.updateObj("LMS_Book", mBook))
                        {
                            lblHeader.Text= "";
                            //lblHeader.Text = Constant.update_successful_message;
                            //this.Text = Constant.update_successful_message;
                            //lblHeader.Text = Constant.update_successful_message;
                            MessageBox.Show(Constant.update_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            mUtility.message(ref lblHeader);

                        }
                        //CHARS.HR.COMMON.PL.Process.Proloading loading = new CHARS.HR.COMMON.PL.Process.Proloading();
                        //loading.ShowDialog();
                        //dd.Opacity = 20;
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
                    if (mMasterBLL.deleteObj("LMS_Book", mBook, 1))
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
        private void SetAgent_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboPerson_Enter(object sender, EventArgs e)
        {
          //  mUtility.enterComboBox(cboPerson, mAgentSample.PersonAsk);
        }

        private void txtAgentCode_Enter(object sender, EventArgs e)
        {
            //mUtility.enterTextbox(txtAgentCode, mAgentSample.AgentCode);
        }

        private void txtAgentDescription_Enter(object sender, EventArgs e)
        {
            //mUtility.enterTextbox(txtAgentDescription, mAgentSample.AgentDescription);
        }

        private void txtAgentPhone_Enter(object sender, EventArgs e)
        {
            //mUtility.enterTextbox(txtAgentPhone, mAgentSample.AgentPhone);
        }

        private void txtAgentEmail_Enter(object sender, EventArgs e)
        {
            //mUtility.enterTextbox(txtAgentEmail, mAgentSample.AgentEmail);
        }

        private void rtxtAgentAddress_Enter(object sender, EventArgs e)
        {
            //mUtility.enterRichTextbox(rtxtAgentAddress, mAgentSample.AgentAddress);
        }

        private void rtxtAgentRemark_Enter(object sender, EventArgs e)
        {
           // mUtility.enterRichTextbox(rtxtAgentRemark, mAgentSample.AgentRemark);
        }
        #endregion

        private void setBook_Load(object sender, EventArgs e)
        {

        }

        private void lnkCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            try
            {
                SetCategory L_SetCategory = new SetCategory();
                L_SetCategory.ShowDialog();
                if (L_SetCategory.DialogResult == DialogResult.Cancel)
                {
                    loadCategory();
                }
                ContentMenuUtil contentMenu = new ContentMenuUtil(new LstMenu());
                contentMenu.createContentMenu(ref pan, "go");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        
        }

        private void lnkWriter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SetWriter L_SetWriter = new SetWriter();
                L_SetWriter.ShowDialog();
                if (L_SetWriter.DialogResult == DialogResult.Cancel)
                {
                    loadWriter();
                }
                ContentMenuUtil contentMenu = new ContentMenuUtil(new LstMenu());
                contentMenu.createContentMenu(ref pan, "go");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lnkPublisher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SetPublisher L_SetPublisher = new SetPublisher();
                L_SetPublisher.ShowDialog();
                if (L_SetPublisher.DialogResult == DialogResult.Cancel)
                {
                    loadPublisher();
                }
                ContentMenuUtil contentMenu = new ContentMenuUtil(new LstMenu());
                contentMenu.createContentMenu(ref pan, "go");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lnkPublishTimes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SetPublishTime L_SetPublishTime = new SetPublishTime();
                L_SetPublishTime.ShowDialog();
                if (L_SetPublishTime.DialogResult == DialogResult.Cancel)
                {
                    loadPublishTime();
                }
                ContentMenuUtil contentMenu = new ContentMenuUtil(new LstMenu());
                contentMenu.createContentMenu(ref pan, "go");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "Image files (*.jpg, *.bmp, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.bmp; *.jpeg; *.jpe; *.jfif; *.png";
                //OFD.ShowDialog();
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    ptBImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptBImage.Image = new Bitmap(OFD.FileName);
                    ptBImage.Image = ResizeImage(ptBImage.Image, 150, 150);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "LMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grbEntryData_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ptBImage.Image = null;
        }

        
    }
}
