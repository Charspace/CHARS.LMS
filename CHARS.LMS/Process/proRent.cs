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


namespace CHARS.LMS.Process
{
    public partial class proRent : LstBase
    {
        public proRent()
        {
            ContextMenu cm = null;
            Utility mUtility = new Utility();
            MasterBLL mMasterBLL = new MasterBLL();
            setBook msetBook = new setBook();
            //MenuStatus mMenuStatus = new MenuStatus();
            Library mLibrary = new Library();
            Writer mWriter = new Writer();
            Category mCategory = new Category();
            Publisher mPublisher = new Publisher();
            PublishTimes mPublishTime = new PublishTimes();
            Book mBook = new Book();
        }

        private void proRent_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

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