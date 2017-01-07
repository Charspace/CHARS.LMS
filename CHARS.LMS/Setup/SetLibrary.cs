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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace CHARS.LMS.Setup
{
    public partial class SetLibrary : SetBase
    {
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        Library mLibrary = new Library();
    
        private bool saveState = true;
    
  
        public SetLibrary()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            saveState = true;
            controlUI();
            mLibrary = new Library();
        }
        public SetLibrary(string aASK)
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
            //loadLibrary();
            //loadCategory();
            //loadWriter();
            //loadPublisher();
            //loadPublishTime();
           
        }
        private void loadLibrary()
        {
            //cboLibrary.DisplayMember = "Code";
            //cboLibrary.ValueMember = "ASK";
            //cboLibrary.DataSource = mMasterBLL.selectDataTable("LMS_Library", "");
        }
        private void loadCategory()
        {
            //cboCategory.DisplayMember = "Category Code";
            //cboCategory.ValueMember = "ASK";
            //cboCategory.DataSource = mMasterBLL.selectDataTable("LMS_Category", "");
        }
        private void loadWriter()
        {
            //cboWriter.DisplayMember = "Writer Code";
            //cboWriter.ValueMember = "ASK";
            //cboWriter.DataSource = mMasterBLL.selectDataTable("lMS_Writer", "");
        }
        private void loadPublisher()
        {
            //cboPublisher.DisplayMember = "Publisher Code";
            //cboPublisher.ValueMember = "ASK";
            //cboPublisher.DataSource = mMasterBLL.selectDataTable("LMS_Publish", "");
        }
        private void loadPublishTime()
        {
            //cboPublishTimes.DisplayMember = "Publish Time";
            //cboPublishTimes.ValueMember = "ASK";
            //cboPublishTimes.DataSource = mMasterBLL.selectDataTable("LMS_Publish_Time", "");
        }

        public void bindForm(string aAsk)
        {
            try
            {
                mLibrary = new Library();
                mLibrary.Ask = aAsk.ToString();
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("LMS_Book", mLibrary);
                mLibrary = (CHARS.LMS.BOL.Library)mMasterBLL.selectObjbyAskobj("LMS_Library", mLibrary);               
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
                //if (cboLibrary.SelectedIndex == -1 || cboLibrary.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboLibrary);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboLibrary);
                //}
                //if (cboCategory.SelectedIndex == -1 || cboCategory.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboCategory);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboCategory);
                //}

                //if (cboWriter.SelectedIndex == -1 || cboWriter.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboWriter);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboWriter);
                //}


                //if (cboPublisher.SelectedIndex == -1 || cboPublisher.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPublisher);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboPublisher);
                //}


                //if (cboPublishTimes.SelectedIndex == -1 || cboPublishTimes.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPublishTimes);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboPublishTimes);
                //}

                //if (cboBookStatus.SelectedIndex == -1 || cboBookStatus.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboBookStatus);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboBookStatus);
                //}

                if (txtLibraryCode.TextLength == 0 || txtLibraryCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtLibraryCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtLibraryCode);
                }
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return false;
        }
        private void bindLObj()
        {
            try
            {
                mLibrary = new Library();
                if (mLibrary.Ask == "0")
                {
                    mLibrary.Ask = mUtility.getStrAsk().ToString();
                }
                mLibrary.TS = ApplicationMember.mUserLevel;
                mLibrary.UD = ApplicationMember.mLoginUserAsk;
                mLibrary.Code = txtLibraryCode.Text.Trim();
                mLibrary.Description = txtLibraryDesc.Text.Trim();
                mLibrary.RendDuration = txtRentDuration.Text.Trim();
                mLibrary.Email = txtEmail.Text.Trim();
                mLibrary.FacebookPage = txtFacebookpage.Text.Trim();
                mLibrary.Founder = txtFounder.Text.Trim();
                mLibrary.FoundDate = Utility.getDateString(dtpFoundDate.Value);
                if (cboFontName.SelectedIndex != -1)
                {
                    mLibrary.FontNamer = cboFontName.SelectedText.ToString();
                }
                else
                {
                    mLibrary.FontNamer = "MM3";
                }
                mLibrary.FontSize =  nmcFontSize.Value.ToString();

                mLibrary.Purpose = txtPurpose.Text.Trim();
                mLibrary.Address = txtaddress.Text.Trim();
                //mLibrary.City = cboCity.SelectedValue.ToString();
                //mLibrary.Township = cboTownship.SelectedValue.ToString();
                //mLibrary.Division = cboDivision.SelectedValue.ToString();
                //mLibrary.Country = cboCountry.SelectedValue.ToString();
                if (ptBImage.Image == null)
                {
                    mLibrary.Logo = null;
                }
                else
                {
                    mLibrary.Logo = Utility.convertImageToString(ptBImage.Image);
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
               mUtility.clearTextBox(txtLibraryCode, txtLibraryDesc, txtRentDuration, txtEmail,txtFacebookpage,txtWebsite
                   ,txtFounder,txtPurpose,txtaddress);
               mUtility.clearComboBox(cboCity, cboCountry, cboDivision, cboFontName, cboTownship);
               dtpFoundDate.Value = DateTime.Now;
               ptBImage.Image = null;
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
                txtLibraryCode.Text=mLibrary.Code;
                txtLibraryDesc.Text=mLibrary.Description ;
                txtRentDuration.Text = mLibrary.RendDuration;
                txtEmail.Text = mLibrary.Email ;
                txtFacebookpage.Text=mLibrary.FacebookPage ;
                txtFounder.Text = mLibrary.Founder;
                dtpFoundDate.Value = Utility.getDateVale(mLibrary.FoundDate);
                cboFontName.SelectedValue =  mLibrary.FontNamer ;
                nmcFontSize.Value =Convert.ToDecimal( mLibrary.FontSize) ;
                txtPurpose.Text = mLibrary.Purpose;
                txtaddress.Text=mLibrary.Address;
                cboCity.SelectedValue = mLibrary.City;
                cboTownship.SelectedValue = mLibrary.Township;
                cboDivision.SelectedValue = mLibrary.Division;
                cboCountry.SelectedValue= mLibrary.Country ;
                if ( mLibrary.Logo.Length >0 )
                {
                    ptBImage.Image = Utility.convertStringToImage(mLibrary.Logo);
                }
                else
                {
                    ptBImage.Image = null;
                }              
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
                mLibrary = new Library();
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
                        if (mMasterBLL.saveObj("LMS_Library", mLibrary))
                        {                            
                            MessageBox.Show(Constant.save_successful_message, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("LMS_Library", mLibrary))
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
                Book l_Book = new Book();
                l_Book.Library = mLibrary.Ask;
                if (!mMasterBLL.isExistData("LMS_Book", l_Book, 6))
                {
                    if (MessageBox.Show(Constant.delete_successful_message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bindLObj();
                        if (mMasterBLL.deleteObj("LMS_Library", mLibrary, 1))
                        {
                            clearUI();
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Can't delete. It is already used");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //try
            //{
            //    if (MessageBox.Show(Constant.delete_successful_message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        bindLObj();
            //        if (mMasterBLL.deleteObj("LMS_Library", mLibrary, 1))
            //        {
            //            clearUI();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
       

      
        #endregion

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


        private void btnClear_Click(object sender, EventArgs e)
        {
            //ptBImage.Image = null;
            ptBImage.Image = global::CHARS.LMS.Properties.Resources.lib;
        }


        
    }
}