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
    public partial class LstBook :LstBase
    {
        public LstBook()
        {           
            InitializeComponent();
            loadGrid();
            formatGrid();
            //setToolTip();
            cm = base.createContentMenu();
            pan.ContextMenu = cm;
        }
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
        //SysMenuHistory mSysMenuHistory = new SysMenuHistory();


        #region"Private Method"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                //this.dgvAgent.Columns[0].ToolTipText = mAgentToolTip.Ask.ToString();
                //this.dgvAgent.Columns[1].ToolTipText = mAgentToolTip.PersonAsk.ToString();
                //this.dgvAgent.Columns[2].ToolTipText = mAgentToolTip.AgentCode.ToString();
                //this.dgvAgent.Columns[3].ToolTipText = mAgentToolTip.AgentDescription.ToString();
                //this.dgvAgent.Columns[4].ToolTipText = mAgentToolTip.AgentPhone.ToString();
                //this.dgvAgent.Columns[5].ToolTipText = mAgentToolTip.AgentAddress.ToString();
                //this.dgvAgent.Columns[6].ToolTipText = mAgentToolTip.AgentEmail.ToString();
                //this.dgvAgent.Columns[7].ToolTipText = mAgentToolTip.AgentRemark.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void hideGridviewcolumn()
        {
            try
            {
                // this.dgvLibrary.Columns[0].Visible = false;
                mUtility.hideMenuDataGridViewColumn(false, dgvLibrary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void sequenceGridviewcolumn()
        {
            //this.dgvPerson.Columns[0].Visible = false;
        }
        private void loadGrid()
        {
            try
            {
                DataTable mm = new DataTable();
                dgvLibrary.DataSource = mMasterBLL.selectDataTable("LMS_Book", "");
                mUtility.setDataGridColumn(ref dgvLibrary);
                dgvLibrary.Columns[17].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void formatGrid()
        {
            try
            {              
                DataGridViewCellStyle dataGridViewCellStyleDate = new DataGridViewCellStyle();
                dataGridViewCellStyleDate.Format = "d";              
                dataGridViewCellStyleDate.NullValue = null;
                dgvLibrary.Columns[12].DefaultCellStyle = dataGridViewCellStyleDate;
                dgvLibrary.Columns[9].DefaultCellStyle = dataGridViewCellStyleDate;

                DataGridViewCellStyle dataGridViewCellStyleNumber = new DataGridViewCellStyle();
                dataGridViewCellStyleNumber.Alignment=DataGridViewContentAlignment.MiddleRight;
                dataGridViewCellStyleNumber.NullValue = null;
                dataGridViewCellStyleNumber.Alignment=DataGridViewContentAlignment.MiddleRight;
                dgvLibrary.Columns[13].DefaultCellStyle = dataGridViewCellStyleNumber;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region"Private Event"
        public void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                msetBook = new setBook();
                msetBook.ShowDialog();
                if (msetBook.DialogResult == DialogResult.Cancel)
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

        public void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibrary.Rows.Count > 0)
                {
                    
                    if (dgvLibrary.CurrentRow.Cells[0].Value != null)
                    {
                        setBook msetBook = new setBook((long)dgvLibrary.CurrentRow.Cells[0].Value);
                        msetBook.ShowDialog();
                        if (msetBook.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());              
            }

        }

        public void butFind_Click(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void dgvAgent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if ((int)e.ColumnIndex == dgvLibrary.Columns[1].Index)
            //{
            //    if (e.Value != null)
            //    {
            //        mPersonObj.Ask = e.Value.ToString();// Convert.ToInt64(e.Value);
            //        DataTable m = new DataTable();
            //        m = mMasterBLL.selectDataTablebyAsk("Person", mPersonObj);
            //        if (m.Rows.Count > 0)
            //        {
            //            e.Value = m.Rows[0][1].ToString();
            //        }
            //    }
            //}
        }

        

        #endregion

        public void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable l_Table = (DataTable)dgvLibrary.DataSource;
                DataTable l_PreviewData = new DataTable();
                l_PreviewData = l_Table.Copy();
                ds.Tables.Add(l_PreviewData);
                ds.Tables[0].TableName = "data";
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to preview");
                    return;
                }
                else
                {
                    Report.viewReport(ds, Application.StartupPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvLibrary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        

        public void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable l_ExcelTable = (DataTable)dgvLibrary.DataSource;
                #region Remove Columns
                //l_tbl = l_Table.Copy();
                //l_tbl.AcceptChanges();

                ////l_tbl.Columns.Remove("Ask");
                ////l_tbl.Columns.Remove("TS");
                ////l_tbl.Columns.Remove("UD");
                ////l_tbl.Columns.Remove("UDdd");
                //if (l_tbl.Columns.Contains("Ask"))
                //{
                //    l_tbl.Columns.Remove("Ask");
                //}

                #endregion
                #region Change Header
                //l_tbl.Columns["EmployeeID"].ColumnName = "ID";
                //l_tbl.Columns["EmpName"].ColumnName = "Name";
                //l_tbl.Columns["T1"].ColumnName = "Income Tax No.";
                //l_tbl.Columns["N4"].ColumnName = "Categorys";
                //l_tbl.Columns["N3"].ColumnName = "No. of Children";
                //l_tbl.Columns["N10"].ColumnName = "No. of Parent";
                //l_tbl.Columns["T3"].ColumnName = "Effective Date";
                //l_tbl.Columns["MaritalStatus"].ColumnName = "Marital Status";

                //foreach (DataRow dtrow in l_tbl.Rows)
                //{
                //    dtrow.BeginEdit();
                //    if (dtrow["Categorys"].ToString() != "0")
                //    {
                //        dtrow["Category"] = Enum.GetName(typeof(PMEnum.IncomeTaxPCBCategory), dtrow["Categorys"]).Replace("_", " ");
                //    }
                //    if (dtrow["Effective Date"].ToString() != "0")
                //    {
                //        dtrow["Effective Date"] = GeneralUtility.StringToDate(dtrow["Effective Date"].ToString());
                //    }
                //    dtrow.EndEdit();
                //}
                //l_tbl.Columns.Remove("Categorys");
                #endregion
                #region Arrange Columns
                //// yyt 06-02-2013 set order of columns 
                //l_tbl.Columns["ID"].SetOrdinal(0);
                //l_tbl.Columns["Name"].SetOrdinal(1);
                //l_tbl.Columns["Income Tax No."].SetOrdinal(2);
                //l_tbl.Columns["Marital Status"].SetOrdinal(2);
                //l_tbl.Columns["Category"].SetOrdinal(3);
                //l_tbl.Columns["No. Of Parent"].SetOrdinal(4);
                //l_tbl.Columns["No. Of Children"].SetOrdinal(5);
                //l_tbl.Columns["Effective Date"].SetOrdinal(6);
                #endregion

                if (l_ExcelTable.Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to export");
                    return;
                }
                else
                {
                    ExcelUtil excel = new ExcelUtil();
                    excel.exportToExcel(l_ExcelTable, dgvLibrary);
                }
                #region Write data
                //SaveFileDialog l_save = new SaveFileDialog();
                //l_save.FileName = System.Windows.Forms.Application.StartupPath + "\\" + "EmployeeIncomeTax.xls";
                //l_save.Filter = "xls files (*.xls)|*.xls|xlsx files (*.xlsx)|*.xlsx";
                //if (l_save.ShowDialog() == DialogResult.OK)
                //{

                //    System.IO.FileInfo l_Finfo = new System.IO.FileInfo(l_save.FileName);
                //    if (l_Finfo.Exists)
                //    {
                //        System.IO.File.Delete(l_save.FileName);

                //    }       
                //    //System.Diagnostics.Process.Start(l_save.FileName);                   

                //}


                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                mBook.Ask = dgvLibrary.CurrentRow.Cells[0].Value.ToString();
                HisBase L_HisBase = new HisBase("LMS_Book_History", mBook);
                L_HisBase.ShowDialog();
                if (L_HisBase.DialogResult == DialogResult.OK)
                {
                    L_HisBase.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvLibrary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvLibrary.Columns[5].Index)
            {
                if (e.Value != null)
                {
                    mLibrary.Ask = Convert.ToString(e.Value);
                    mLibrary = (Library)mMasterBLL.selectObjbyAskobj("LMS_Library", mLibrary);
                    e.Value = mLibrary.Code;
                }
            }
            if ((int)e.ColumnIndex == dgvLibrary.Columns[6].Index)
            {
                if (e.Value != null)
                {
                    mCategory.Ask = Convert.ToString(e.Value);
                    mCategory = (Category)mMasterBLL.selectObjbyAskobj("LMS_Category", mCategory);
                    e.Value = mCategory.Code;
                }
            }
            if ((int)e.ColumnIndex == dgvLibrary.Columns[7].Index)
            {
                if (e.Value != null)
                {
                    mWriter.Ask = Convert.ToString(e.Value);
                    mWriter = (Writer)mMasterBLL.selectObjbyAskobj("LMS_Writer", mWriter);
                    e.Value = mWriter.Code;
                }
            }
            if ((int)e.ColumnIndex == dgvLibrary.Columns[8].Index)
            {
                if (e.Value != null)
                {
                    mPublisher.Ask = Convert.ToString(e.Value);
                    mPublisher = (Publisher)mMasterBLL.selectObjbyAskobj("LMS_Publish", mPublisher);
                    e.Value = mPublisher.Code;
                }
            }
            if ((int)e.ColumnIndex == dgvLibrary.Columns[9].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString());
                }
            }
           if ((int)e.ColumnIndex == dgvLibrary.Columns[10].Index)
            {
                if (e.Value != null)
                {
                    mPublishTime.Ask = Convert.ToString(e.Value);
                    mPublishTime = (PublishTimes)mMasterBLL.selectObjbyAskobj("LMS_Publish_Time", mPublishTime);
                    e.Value = mPublishTime.Code;
                }
            }

            if ((int)e.ColumnIndex == dgvLibrary.Columns[12].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString());                    
                }
            }
            if ((int)e.ColumnIndex == dgvLibrary.Columns[14].Index)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = "New";
                    }
                    else if (e.Value.ToString() == "2")
                    {
                        e.Value = "Open";
                    }
                    else if (e.Value.ToString() == "3")
                    {
                        e.Value = "Rent";
                    }
                    if (e.Value.ToString() == "4")
                    {
                        e.Value = "Damage";
                    }
                }
            }
        }

        public void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelBase L_ExcelBase = new ExcelBase("LMS_Book");
                L_ExcelBase.ShowDialog();
                if (L_ExcelBase.DialogResult == DialogResult.OK)
                {
                    L_ExcelBase.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            loadGrid();
        }      

        private void LstMenu_Click(object sender, EventArgs e)
        {
            //ContentMenuUtil.createContentMenu(ref  pan, "go");
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FindBase L_FindBase = new FindBase("LMS_Book", new setBook());
                L_FindBase.ShowDialog();
                if (L_FindBase.DialogResult == DialogResult.OK)
                {
                    setBook msetBook = (setBook)L_FindBase.DynObject;                   
                    dgvLibrary.DataSource = mMasterBLL.searchData("LMS_Book", mBook);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public override void MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MenuItem mi = sender as MenuItem;
                if (mi != null)
                {
                    if (mi.Text == "New")
                    {
                        btnNew_Click(null, null);
                        //((LstMenu)form).btnNew_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "Edit")
                    {
                        //LstMenu lst = new LstMenu();
                        btnEdit_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "History")
                    {
                        //LstMenu lst = new LstMenu();
                        btnHistory_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "Import")
                    {
                        //LstMenu lst = new LstMenu();
                        btnImport_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "Export")
                    {
                        //LstMenu lst = new LstMenu();
                        btnExport_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "Preview")
                    {
                        //LstMenu lst = new LstMenu();
                        btnPreview_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "Search")
                    {
                        btnSearch_Click(null, null);
                        //LstMenu lst = new LstMenu();
                        // lst.btnSearch_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
                if (mi != null)
                {
                    if (mi.Text == "Refresh")
                    {
                        //LstMenu lst = new LstMenu();
                        btnRefresh_Click(null, null);
                    }
                    //MessageBox.Show(mi.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LstBook_Load(object sender, EventArgs e)
        {

        }
    }
}