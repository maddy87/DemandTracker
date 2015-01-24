using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.IO;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;




namespace IFTracker
{
    public partial class frmHome : Form
    {
        frmLoading frm = new frmLoading();
        SendConfirm frmSend = new SendConfirm();
        DataTable dt = new DataTable();
        DataTable dtCI = new DataTable();
        DataTable Exportdt = new DataTable();
        Func objFunc = new Func();

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            #region: ADJUST THE CONTROLS ON THE FORM 

            tbHome.Width = this.Width - 50;
            tbHome.Height = this.Height - 100;
            grpNewDemands.Width = tbHome.Width - 50;
            grpNewDemands.Height = tbHome.Height - 110;
            dgNewDemand.Width = grpNewDemands.Width - 25;
            dgNewDemand.Height = grpNewDemands.Height - 115;
            grpCI.Width = grpNewDemands.Width;
            grpCI.Height = grpNewDemands.Height;
            dgCI.Width = dgNewDemand.Width;
            dgCI.Height = dgNewDemand.Height;
            
            btnModify.Visible = false;
            btnModifyCI.Visible = false;
            btnUpdateStatus.Visible = false;
            btnUpdateCI.Visible = false;
            btnViewCompleteStory.Visible = false;
            btnEmailCI.Visible = false;
            Global.gTypeText = "NEW DEMAND";

            #endregion
            
            #region: GET DETAILS OF CURRENTLY LOGGED IN USER 
            
            Global.gCurrentUser = System.Environment.UserName.ToString();
            Global.gCurrentUser = Global.gCurrentUser.ToUpper();
            //MessageBox.Show(Global.gCurrentUser);
            Global.gCurrentFileName = "IFDT_V100.exe";
            
            #endregion
                
            #region : CREATING THE DATABASE CONNECTION ON LOAD USING THREADING 
            BackgroundWorker bgConnectDB = new BackgroundWorker();
            bgConnectDB.DoWork += new DoWorkEventHandler(bgConnectDB_DoWork);
            bgConnectDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgConnectDB_RunWorkerCompleted);
            bgConnectDB.RunWorkerAsync();
            frm.ShowDialog();
            #endregion

            #region : FILLING UP THE GRIDS WITH THE DESIRED INFORMATION 

            BackgroundWorker bgFillData = new BackgroundWorker();
            bgFillData.DoWork += new DoWorkEventHandler(bgFillData_DoWork);
            bgFillData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgFillData_RunWorkerCompleted);
            bgFillData.RunWorkerAsync();
            Global.gDisplayText = "Loading New Demands ... ";
            frm.ShowDialog();
            #endregion

        }

        void bgFillData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            dgNewDemand.DataSource = dt;
            dgCI.DataSource = dtCI;
            frm.Close();
            //frm.Dispose();
            
        }

        void bgFillData_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");

            #region: RETRIEVING ND's 
            string type = "ND";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select [NewDemandNo] AS ND,LampID,RFS,Department ,RegisteredDate,[ProjectName],Block,RAGSTATUS,ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus from Master where Type = '" + type + "' ORDER BY NewDemandNo";//,Description,CurrentStatus 
            //cmd.CommandText = "select [NewDemandNo] AS ND,LampID,RFS,Department ,RegisteredDate,[ProjectName],Block,RAGSTATUS,ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus from Master where Type = '" + type + "' ORDER BY ExpectedStart";//,Description,CurrentStatus 
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = Global.GlobalConnection;
            da.Fill(dt);
            #endregion

            #region: RETRIEVING CI's 
            type = "CI";
            OleDbCommand cmdCI = new OleDbCommand();
            cmdCI.CommandText = "select [NewDemandNo] AS ND,[TicketID] AS CI_TicketID,LampID,RFS,Department ,RegisteredDate,[ProjectName],Block,RAGSTATUS,ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus from Master where Type = '" + type + "' ORDER BY NewDemandNo";//,Description,CurrentStatus 
            //cmdCI.CommandText = "select TicketID from Master where Type = '" + type + "' ORDER BY NewDemandNo";//,Description,CurrentStatus 
            OleDbDataAdapter daCI = new OleDbDataAdapter(cmdCI);
            daCI.SelectCommand = cmdCI;
            daCI.SelectCommand.Connection = Global.GlobalConnection;
            daCI.Fill(dtCI);
            #endregion

        }

        void bgConnectDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frm.Close();
        }

        void bgConnectDB_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Global.gDisplayText = "Connecting to Database ... ";
                Global.GlobalConnection.Open();
            }
            catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            //throw new Exception("The method or operation is not implemented.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.gType = "ND";
            Global.gTypeText = "NEW DEMAND";
            frmAdd frm = new frmAdd();
            frm.Text = "ADD NEW DEMAND";
            Global.gCurrRequest = "NEW";
            frm.Show();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.GlobalConnection.Close();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            int iRet = objFunc.SendEmail();

            if (iRet == 1)
            {
                MessageBox.Show("Something here is not right.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Email has been sent Successfully.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

        }

        private void dgNewDemand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateStatus.Visible = true;
            btnModify.Visible = true;
            btnViewCompleteStory.Visible = true;
            
            Global.gCurrND = dgNewDemand.CurrentRow.Cells[0].Value.ToString();
            btnModify.Text = " MODIFY " + dgNewDemand.CurrentRow.Cells[0].Value.ToString();
            btnUpdateStatus.Visible = true;
            btnUpdateStatus.Text = " UPDATE STATUS OF " + dgNewDemand.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Global.gType = "ND";
            Global.gCurrRequest = "MODIFY";
            Global.gTypeText = "NEW DEMAND";
            frmAdd frm = new frmAdd();
            frm.Show();
            
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            Global.gType = "ND";
            Global.gTypeText = "NEW DEMAND";
            Global.gCurrRequest = "UPDATE";
            frmUpdateStatus frm = new frmUpdateStatus();
            frm.Show();
        }

        #region: EMAIL  ME THE COMPLETE STORY

        private void btnViewCompleteStory_Click(object sender, EventArgs e)
        {
            Global.gType = "ND";
            Global.gTypeText = "NEW DEMAND";
            frmSend.ShowDialog();
            
        }

      

        #endregion

        private void btnAddCI_Click(object sender, EventArgs e)
        {
            Global.gType = "CI";
            Global.gTypeText = "CATALOGUE ITEM";
            frmAdd frm = new frmAdd();
            frm.Text = "ADD NEW CATALOGUE ITEM";
            Global.gCurrRequest = "NEW";
            frm.Show();
        }

        private void btnModifyCI_Click(object sender, EventArgs e)
        {
            Global.gType = "CI";
            Global.gTypeText = "CATALOGUE ITEM";
            Global.gCurrRequest = "MODIFY";
            frmAdd frm = new frmAdd();
            frm.Show();
        }

        private void dgCI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.gCurrND = dgCI.CurrentRow.Cells[0].Value.ToString();
            Global.gCITicket = dgCI.CurrentRow.Cells[1].Value.ToString();
            btnUpdateCI.Visible = true;
            btnUpdateCI.Text = "UPDATE " + Global.gCITicket;
            btnModifyCI.Visible = true;
            btnModifyCI.Text = "MODIFY " + Global.gCITicket;
            btnEmailCI.Visible = true;
        }

        private void btnUpdateCI_Click(object sender, EventArgs e)
        {
            Global.gType = "CI";
            Global.gTypeText = "CATALOGUE ITEM";
            Global.gCurrRequest = "UPDATE";
            frmUpdateStatus frm = new frmUpdateStatus();
            frm.Show();
        }

        private void btnEmailCI_Click(object sender, EventArgs e)
        {
            Global.gType = "CI";
            Global.gTypeText = "CATALOGUE ITEM";
            frmSend.ShowDialog();
        }

        #region: REFRESHING ND's
        public void RefreshND()
        {
            dt.Clear();          
            string type = "ND";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select [NewDemandNo] AS ND,LampID,RFS,Department ,RegisteredDate,[ProjectName],Block,RAGSTATUS,ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus from Master where Type = '" + type + "' ORDER BY NewDemandNo";//,Description,CurrentStatus 
            //cmd.CommandText = "select [NewDemandNo] AS ND,LampID,RFS,Department ,RegisteredDate,[ProjectName],Block,RAGSTATUS,ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus from Master where Type = '" + type + "' ORDER BY ExpectedStart";//,Description,CurrentStatus 
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = Global.GlobalConnection;
            da.Fill(dt);
            dgNewDemand.DataSource = dt;
            
    
        }
        #endregion

        #region: REFRESHING CI'S
        public void RefreshCI()
        {
            dtCI.Clear();
            string type = "CI";
            OleDbCommand cmdCI = new OleDbCommand();
            cmdCI.CommandText = "select [NewDemandNo] AS ND,[TicketID] AS CI_TicketID,LampID,RFS,Department ,RegisteredDate,[ProjectName],Block,RAGSTATUS,ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus from Master where Type = '" + type + "' ORDER BY NewDemandNo";//,Description,CurrentStatus 
            //cmdCI.CommandText = "select TicketID from Master where Type = '" + type + "' ORDER BY NewDemandNo";//,Description,CurrentStatus 
            OleDbDataAdapter daCI = new OleDbDataAdapter(cmdCI);
            daCI.SelectCommand = cmdCI;
            daCI.SelectCommand.Connection = Global.GlobalConnection;
            daCI.Fill(dtCI);
            dgCI.DataSource = dtCI;
            
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshND();
        }

        private void brnRefreshCI_Click(object sender, EventArgs e)
        {
            RefreshCI();
        }

        private void btnExportND_Click(object sender, EventArgs e)
        {
            Global.gTypeText = "NEW DEMAND";
            Exportdt = dt;
            #region: REQUEST THE USER TO PROVIDE A FILENAME FOR THE EXPORTED DATA
            int iDoNothing = 0;
            saveFile.Filter = "Excel (*.xls)|*.xls";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (!saveFile.FileName.Equals(string.Empty))
                {
                    FileInfo f = new FileInfo(saveFile.FileName);
                    if (f.Extension.Equals(".xls"))
                    {
                        Global.gExportFilename = saveFile.FileName;
                        iDoNothing = 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid file type");
                    }
                }
                else
                {
                    MessageBox.Show("You did pick a location to save file to");
                }
            }
            else
            {
                //DoNothing = 1;
            }

            if (iDoNothing == 1)
            {
                Global.gDisplayText = "Exporting ND Info ...";
                BackgroundWorker bg_ExportND = new BackgroundWorker();
                bg_ExportND.DoWork += new DoWorkEventHandler(bg_ExportND_DoWork);
                bg_ExportND.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_ExportND_RunWorkerCompleted);
                //frm.ShowDialog();
                btnExportND.Enabled = false;
                btnExportND.Text = "EXPORTING ...... ";
                bg_ExportND.RunWorkerAsync();
            }
            
            #endregion
        }

        void bg_ExportND_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            MessageBox.Show("COMPLETE");
            //frm.Close();
            Global.gDisplayText = "Export Process Complete";
            if (Global.gTypeText == "NEW DEMAND")
            {
                btnExportND.Text = "EXPORT ND INFORMATION TO EXCEL";
                btnExportND.Enabled = true;
            }
            else
            {
                btnExportNDData.Text = "EXPORT ND INFORMATION TO EXCEL";
                btnExportNDData.Enabled = true;
            }

        }

        void bg_ExportND_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            ExportAvailability();
        }

        #region: FILLS THE CELLS INDIVIDUALLY
        public void fillExcelCell(Excel.Worksheet worksheet, int row, int col, string value, string style)
        {
            #region: INSERTING DATA INTO THE EXCEL SHEETS
            Excel.Range rng = (Excel.Range)worksheet.Cells[row, col];
            rng.Select();
            rng.Value2 = value;
            rng.Columns.EntireColumn.AutoFit();
            rng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            rng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rng.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
            #endregion

            #region: APPLYING THE APPROPRIATE STYLE TO HEADINGS AND COLUMNS

            if (style == "Headings")
            {

                rng.Font.Name = "Arial";
                rng.Font.Size = 14;
                rng.Font.Color = (255 << 16) | (255 << 8) | 255;
                rng.Interior.Color = (0 << 16) | (0 << 8) | 0;
                rng.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            }
            else
            {
                rng.Font.Name = "Arial";
                rng.Font.Size = 10;
                rng.Font.Color = (0 << 16) | (0 << 8) | 0;
                rng.Interior.Color = (192 << 16) | (192 << 8) | 192;
                rng.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            }


            #endregion



        }
        #endregion
        
        #region: EXPORTING THE AVAILABILITY INFORAMTION (INDEPENDENT THREAD)

        private void ExportAvailability()
        {

            #region: INITIALIZE THE LABELS TO PROVIDE THE STATUS OF COMPLETION

            //MessageBox.Show("KINDLY WAIT TILL THE EXPORT PROCESS GETS COMPLETED", "EXPORTING AVAILABILITY INFORMATION");

            int iExportProgress = 0;

            
            Excel.Application xl = new Excel.Application();
            xl.Visible = false;
            //Open the excel sheet
            //Excel.Workbook wb = xl.Workbooks.Open(GlobalData.gExportFilename, 0, false, 5, System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false, System.Reflection.Missing.Value, false, false, false);
            Object MissingValue = System.Reflection.Missing.Value;
            Excel.Workbook wb = xl.Workbooks.Add(MissingValue);
            xl.Application.DisplayAlerts = false;
            Excel.Sheets wsheets = wb.Sheets;
            //Selecting the first sheet
            Excel.Worksheet xlwsheet = (Excel.Worksheet)wsheets[1];

            int iSheetName;
            int iRow;
            int iColumn;
            string style;

            #endregion

            #region: CREATING COLUMNS AND ROWS WORKBOOK STYLES
            //Creates 2 Custom styles for the workbook These styles are
            //  styleColumnHeadings
            //  styleRows
            //These 2 styles are used when filling the individual Excel cells with the
            //DataView values. If the current cell relates to a DataView column heading
            //then the style styleColumnHeadings will be used to render the current cell.
            //If the current cell relates to a DataView row then the style styleRows will
            //be used to render the current cell.


            //Style styleColumnHeadings

            //////////////////////////////////////////////////////
            //try
            //{
            //    styleColumnHeadings = workbook.Styles["styleColumnHeadings"];
            //}
            //// Style doesn't exist yet.
            //catch
            //{
            //    styleColumnHeadings = workbook.Styles.Add("styleColumnHeadings", Type.Missing);
            //    styleColumnHeadings.Font.Name = "Arial";
            //    styleColumnHeadings.Font.Size = 14;
            //    styleColumnHeadings.Font.Color = (255 << 16) | (255 << 8) | 255;
            //    styleColumnHeadings.Interior.Color = (0 << 16) | (0 << 8) | 0;
            //    styleColumnHeadings.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            //}

            //// Style styleRows
            //try
            //{

            //    styleRows = workbook.Styles["styleRows"];
            //}
            //// Style doesn't exist yet.
            //catch
            //{
            //    styleRows = workbook.Styles.Add("styleRows", Type.Missing);
            //    styleRows.Font.Name = "Arial";
            //    styleRows.Font.Size = 10;
            //    styleRows.Font.Color = (0 << 16) | (0 << 8) | 0;
            //    styleRows.Interior.Color = (192 << 16) | (192 << 8) | 192;
            //    styleRows.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            //}

            #endregion

            #region: FILLING DATA INTO EXCEL SHEETS

            #region: FILLING THE COLUMN HEADINGS FIRST;
            style = "Headings";
            for (int i = 1; i < Exportdt.Columns.Count; i++)
            {
                fillExcelCell(xlwsheet, 1, i, Exportdt.Columns[i].ToString(), style);
            }

            #endregion


            #region: FILLING THE REMAINING ROWS VALUES HEADINGS FIRST;
            style = "Rows";
            for (int j = 0; j < Exportdt.Rows.Count; j++)
            {
                for (int i = 1; i < Exportdt.Columns.Count; i++)
                {
                    fillExcelCell(xlwsheet, j + 2, i, Exportdt.Rows[j][i].ToString(), style);
                }

                iExportProgress = (100 / Exportdt.Rows.Count) * j + 2;
                //lblExportProgress.Text = iExportProgress + "% COMPLETE"; ---> CROSS THREAD HENCE BAD DOUGHNUT FOR YOU
                Global.gExportProgressStatus = iExportProgress;

            }
            #endregion

            wb.SaveAs(Global.gExportFilename, Excel.XlFileFormat.xlWorkbookNormal, MissingValue, MissingValue, MissingValue, MissingValue, Excel.XlSaveAsAccessMode.xlExclusive, MissingValue, MissingValue, MissingValue, MissingValue, MissingValue);

            xl.Quit();

            GC.Collect();

            //MessageBox.Show("ExportProcess Completed");
            #endregion

            //}
            //else
            //{
            //DO NOTHING
            //}

        }

        #endregion

        private void btnExportNDData_Click(object sender, EventArgs e)
        {
            Global.gTypeText = "CATALOGUE ITEM";
            Exportdt = dtCI;
            #region: REQUEST THE USER TO PROVIDE A FILENAME FOR THE EXPORTED DATA
            int iDoNothing = 0;
            saveFile.Filter = "Excel (*.xls)|*.xls";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (!saveFile.FileName.Equals(string.Empty))
                {
                    FileInfo f = new FileInfo(saveFile.FileName);
                    if (f.Extension.Equals(".xls"))
                    {
                        Global.gExportFilename = saveFile.FileName;
                        iDoNothing = 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid file type");
                    }
                }
                else
                {
                    MessageBox.Show("You did pick a location to save file to");
                }
            }
            else
            {
                //DoNothing = 1;
            }

            if (iDoNothing == 1)
            {
                Global.gDisplayText = "Exporting ci Info ...";
                BackgroundWorker bg_ExportND = new BackgroundWorker();
                bg_ExportND.DoWork += new DoWorkEventHandler(bg_ExportND_DoWork);
                bg_ExportND.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_ExportND_RunWorkerCompleted);
                //frm.ShowDialog();
                btnExportNDData.Enabled = false;
                btnExportNDData.Text = "EXPORTING ...... ";
                bg_ExportND.RunWorkerAsync();
            }

            #endregion
        }
    }
}