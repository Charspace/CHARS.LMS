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

namespace CHARS.LMS.Setup
{
    public partial class setRent : SetBase
    {
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();

        public setRent()
        {
            InitializeComponent();
            Utility mUtility = new Utility();
            MasterBLL mMasterBLL = new MasterBLL();
        }
        private bool saveState = true;
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

        private void setRent_Load(object sender, EventArgs e)
        {

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

        private void grbControl_Enter(object sender, EventArgs e)
        {

        }
    }
}