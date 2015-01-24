using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IFTracker
{
    public partial class frmUpdateStatus : Form
    {
        int iUpdateNoPrev = 0;
        int iUpdateNoNext = 0;
        int iUpdateCurrent = 0;
        int iMaxUpdateNo;
        int iCurrentUpdateNo;
        
        public frmUpdateStatus()
        {
            InitializeComponent();
        }

        private void frmUpdateStatus_Load(object sender, EventArgs e)
        {
            BackgroundWorker bg_GetNDDetails = new BackgroundWorker();
            bg_GetNDDetails.DoWork +=new DoWorkEventHandler(bg_GetNDDetails_DoWork);
            bg_GetNDDetails.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_GetNDDetails_RunWorkerCompleted);
            bg_GetNDDetails.RunWorkerAsync();
        }

        #region: GET THE CURRENT ND/CI DETAILS FOR THE FORM 

        void bg_GetNDDetails_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");

            lblND.Text = "UPDATE STATUS FOR " + Global.gCurrND;
            lblProjectName.Text = Global.gCurrProjectName;
            lblDescp.Text = Global.gCurrDescription;
            txtPreviousUpdates.Text = Global.gCurrCurrentStatus;
            lblLastUpdated.Text = "LAST UPDATED DATE : " + Global.gCurrLastUpdatedDate;
            lblTicketID.Text = "CI TICKET ID " + Global.gCITicket;

        }

        void bg_GetNDDetails_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");

            int iNewUpdateNo = 0;

            #region: GETTING THE MAX UPDATE NO FOR THAT ND 

            OleDbCommand cmdGetMax = new OleDbCommand();
            cmdGetMax.CommandText = "select MAX(UpdateNo)from UpdateTracker where NewDemandNo = '" + Global.gCurrND + "'";
            cmdGetMax.Connection = Global.GlobalConnection;
            OleDbDataReader dr1 = cmdGetMax.ExecuteReader();

            try
            {
                while (dr1.Read())
                {
                    iCurrentUpdateNo = Convert.ToInt32(dr1[0].ToString());
                    iMaxUpdateNo = iCurrentUpdateNo;
                    iUpdateNoPrev = iMaxUpdateNo - 1;
                    iUpdateNoNext = iUpdateNoPrev + 1;
                    if(iCurrentUpdateNo == 1)
                    {
                                iUpdateNoPrev = iCurrentUpdateNo - 1;
                    }

                }

            }
            catch (Exception ex)
            {
                iCurrentUpdateNo = 1;
            }

            #endregion

            #region: LOADING FORM WITH THE DETAILS OF THE CURRENT ND 

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select Type,NewDemandNo,ProjectName,TicketID,Description,CurrentStatus,ServiceLines,Technologies " +
                              ",PM from Master where NewDemandNo = '" + Global.gCurrND +"' ";
            cmd.Connection = Global.GlobalConnection;
            OleDbDataReader dr = cmd.ExecuteReader();
                      
            

            while (dr.Read())
            {
                Global.gCurrType = dr[0].ToString();
                //Global.gCurrND= dr[0].ToString();
                Global.gCurrProjectName = dr[2].ToString();
                //Global.gCITicket = dr[3].ToString();
                //Global.gCurrUpdateNo = Convert.ToInt32(dr[4].ToString());
                Global.gCurrDescription = dr[4].ToString();
                Global.gCurrCurrentStatus = dr[5].ToString();
                Global.gCurrServiceLines = dr[6].ToString();
                Global.gCurrTechnologies = dr[7].ToString();
                //Global.gCurrLastUpdatedDate = dr[8].ToString();
                Global.gCurrProjectManager = dr[8].ToString();

            }

            #endregion

            #region: GETTING THE LAST UPDATED DATE DETAILS

            OleDbCommand cmdGetDate = new OleDbCommand();
            cmdGetDate.CommandText = "select LastUpdatedDate from UpdateTracker where NewDemandNo = '" + Global.gCurrND + "' and UpdateNo = " +iMaxUpdateNo;
            cmdGetDate.Connection = Global.GlobalConnection;
            OleDbDataReader dr2 = cmdGetDate.ExecuteReader();

            try
            {
                while (dr2.Read())
                {
                    Global.gCurrLastUpdatedDate =  dr2[0].ToString();
                }

            }
            catch (Exception ex)
            {
              ///  iCurrentUpdateNo = 1;
                throw ex;
            }

            #endregion

            
        }

        #endregion


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            BackgroundWorker bg_UpdateTracker = new BackgroundWorker();
            bg_UpdateTracker.DoWork += new DoWorkEventHandler(bg_UpdateTracker_DoWork);
            bg_UpdateTracker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_UpdateTracker_RunWorkerCompleted);
            bg_UpdateTracker.RunWorkerAsync();

           
        }

        void bg_UpdateTracker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            MessageBox.Show("STATUS FOR " + Global.gCurrND + " UPDATED ");
            this.Close();
        }

        void bg_UpdateTracker_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");

            #region: INSERT DETAILS INTO UPDATETRACKER TABLE 
            int iNewUpdate = iCurrentUpdateNo++;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = cmd.CommandText = "insert into UpdateTracker(Type,NewDemandNo,ProjectName,TicketID,UpdateNo,Description,CurrentStatus, " +
                               " ServiceLines,Technologies,LastUpdatedDate,PM) values('" + Global.gType + "','" + Global.gCurrND + "','" + lblProjectName.Text + "' " +
                               " ,'" + Global.gCITicket + "','" + iCurrentUpdateNo + "','" + lblDescp.Text + "','" + txtNewUpdate.Text + "','" + Global.gCurrServiceLines + "' " +
                               " ,'" + Global.gCurrTechnologies + "','" + DateTime.Now.ToString() + "','" + Global.gCurrProjectManager + "')";

            cmd.Connection = Global.GlobalConnection;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            #endregion

            #region: INSERT DETAILS INTO MASTER TABLE 

            OleDbCommand cmdUpdate = new OleDbCommand();
            cmdUpdate.CommandText = "Update Master SET CurrentStatus = '"+txtNewUpdate.Text+"' where NewDemandNo = '"+Global.gCurrND+"'";
            cmdUpdate.Connection = Global.GlobalConnection;

            try
            {
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            #endregion

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            
                //if (iUpdateNoPrev == iMaxUpdateNo)
                //{
                //    btnNext.Enabled = false;
                //    MessageBox.Show("HERE 1");
                //    iUpdateNoPrev--;
                //}
                //else
                //{//DO NOTHING
                //}

                iUpdateNoPrev = iUpdateNoNext - 1;
                //MessageBox.Show("HERE " + iUpdateNoPrev + " " + iUpdateNoNext + " " + iCurrentUpdateNo );
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
                OleDbCommand cmdGetMax = new OleDbCommand();
                cmdGetMax.CommandText = "Select CurrentStatus,LastUpdatedDate from UpdateTracker where NewDemandNo = '"+Global.gCurrND+"' and UpdateNo = "+iUpdateNoPrev;
                cmdGetMax.Connection = Global.GlobalConnection;
                OleDbDataReader dr1 = cmdGetMax.ExecuteReader();

                try
                {
                    while (dr1.Read())
                    {

                        txtPreviousUpdates.Text = dr1[0].ToString();
                        lblLastUpdated.Text = "LAST UPDATED DATE : " + dr1[1].ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    
                }
                
                if (iUpdateNoPrev <= 1)
                {
                    btnPrev.Enabled = false;
                    //MessageBox.Show("HERE");
                }
                else
                {
                    iUpdateNoNext--;
                }
           //iUpdateNoNext = iUpdateNoPrev + 1;
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
                //if (iUpdateNoNext == 1)
                //{
                //    btnPrev.Enabled = false;
                //    MessageBox.Show("HERE 1");
                //    iUpdateNoNext++;
                //}
                //else
                //{
                   
                 //}
                    iUpdateNoNext = iUpdateNoPrev + 1 ; 
                    //MessageBox.Show("HERE " + iUpdateNoPrev + " " + iUpdateNoNext + " " + iCurrentUpdateNo);
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                    OleDbCommand cmdGetMax = new OleDbCommand();
                    cmdGetMax.CommandText = "select CurrentStatus,LastUpdatedDate from UpdateTracker where NewDemandNo = '" + Global.gCurrND + "' and UpdateNo = " + iUpdateNoNext;
                    cmdGetMax.Connection = Global.GlobalConnection;
                    OleDbDataReader dr1 = cmdGetMax.ExecuteReader();

                    try
                    {
                        while (dr1.Read())
                        {

                            txtPreviousUpdates.Text = dr1[0].ToString();
                            lblLastUpdated.Text = "LAST UPDATED DATE : " + dr1[1].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        

                    }
                

                if (iUpdateNoNext == iMaxUpdateNo)
                {
                    btnNext.Enabled = false;
                    //MessageBox.Show("HERE");
                }
                else
                {
                    //DO NOTHING
                    //iUpdateNoNext = iUpdateNoNext + 1;
                    iUpdateNoPrev++;
                }

          
            //iUpdateNoPrev++;
        }

        private void lblProjectName_Click(object sender, EventArgs e)
        {

        }

        private void lblPreviousUpdates_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescp_Click(object sender, EventArgs e)
        {

        }

        private void lblLastUpdated_Click(object sender, EventArgs e)
        {

        }

        private void txtNewUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreviousUpdates_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblND_Click(object sender, EventArgs e)
        {

        }
    }
}