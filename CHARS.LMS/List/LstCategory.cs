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
    public partial class LstCategory : LstBase
    {
        public LstCategory()
        {           
            InitializeComponent();
            loadGrid();
            cm = base.createContentMenu();
            pan.ContextMenu = cm;
        }
        ContextMenu cm = null;
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        SetCategory mSetCategory = new SetCategory();       
        SysMenuHistory mSysMenuHistory = new SysMenuHistory();


        #region"Private Method"
        private void loadGrid()
        {
            try
            {
                DataTable mm = new DataTable();
                dgvCategory.DataSource = mMasterBLL.selectDataTable("LMS_Category", "");
                mUtility.setDataGridColumn(ref dgvCategory);             

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
                mSetCategory = new SetCategory();
                mSetCategory.ShowDialog();
                if (mSetCategory.DialogResult == DialogResult.Cancel)
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
                if (dgvCategory.Rows.Count > 0)
                {
                    
                    if (dgvCategory.CurrentRow.Cells[0].Value != null)
                    {
                       SetMenu msetBook = new SetMenu((long)dgvCategory.CurrentRow.Cells[0].Value);
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
              

        #endregion

        public void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable l_Table = (DataTable)dgvCategory.DataSource;
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

           

        public void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable l_ExcelTable = (DataTable)dgvCategory.DataSource;
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
                    excel.exportToExcel(l_ExcelTable, dgvCategory);
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

    

        public void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                mSysMenuHistory.Ask = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                HisBase L_HisBase = new HisBase("SYS_MENU_History", mSysMenuHistory);
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

       
        public void btnImport_Click(object sender, EventArgs e)
        {
            try
            {                
                ExcelBase L_ExcelBase = new ExcelBase();//("SYS_MENU_History", mSysMenuHistory);
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
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FindBase L_FindBase = new FindBase("SYS_MENU", new SysMenu());
                L_FindBase.ShowDialog();
                if (L_FindBase.DialogResult == DialogResult.OK)
                {
                    Category mCategory = (Category)L_FindBase.DynObject;                    
                    dgvCategory.DataSource = mMasterBLL.searchData("LMS_Category", mCategory);

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

       
        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if ((int)e.ColumnIndex == dgvCategory.Columns[10].Index)
            //{
            //    if (e.Value != null)
            //    {
            //        //mMenuStatus.Ask = e.Value.ToString();
            //        DataTable m = new DataTable();
            //        //m = mMasterBLL.selectDataTablebyAsk("SYS_MENU_STAUS", mMenuStatus);
            //        if (m.Rows.Count > 0)
            //        {
            //            e.Value = m.Rows[0][3].ToString();
            //        }
            //    }
            //}
        }
    }
}