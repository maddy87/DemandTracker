using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;
//using Outlook = Microsoft.Office.Interop.Outlook;

namespace IFTracker
{
    public partial class SendConfirm : Form
    {
        public SendConfirm()
        {
            InitializeComponent();
        }

        private void SendConfirm_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            txtSubject.Text = "MiddleWare Inflight - COMPLETE STORY FOR " + Global.gCurrND;
            
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (txtCc.Text == "")
            {
                txtCc.Text = "rajesh.shetty@Ikran.com";
            }
            BackgroundWorker bg_View = new BackgroundWorker();
            bg_View.DoWork += new DoWorkEventHandler(bg_View_DoWork);
            bg_View.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_View_RunWorkerCompleted);
            if (txtTo.Text == "")
            {
                MessageBox.Show("A VALID EMAIL ID PLEASE");
            }
            else
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Sending Email ... ";
                bg_View.RunWorkerAsync();
                
            }
            
            
           
        }

        void bg_View_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            lblStatus.Text = "EMAIL SENT SUCCESSFULLY";
            Thread.Sleep(2000);
            this.Dispose();
            this.Close();

        }

        void bg_View_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            //string sRoot = Application.StartupPath.ToString();
            //string sFilename = sRoot + "\\CompleteStory-" + Global.gCurrND + ".html";

            //System.IO.File.Create(sRoot + "\\CompleteStory-" + Global.gCurrND + ".html");
            //File.WriteAllText(sFilename, "<html><BODY>TEST</BODY></HTML>");
            ////StreamWriter sr = new StreamWriter(sFilename);
            ////sr.Write("<html><BODY>TEST</BODY></HTML>");


            #region: GET ALL DETAILS FOR THIS ND

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Select * from Master where NewDemandNo = '" + Global.gCurrND + "'";
            cmd.Connection = Global.GlobalConnection;
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {

                    Global.gCurrType = dr[0].ToString();
                    Global.gCurrND = dr[1].ToString();
                    Global.gCurrLampID = dr[2].ToString();
                    Global.gCurrRFS = dr[3].ToString();
                    Global.gCurrDept = dr[4].ToString();
                    Global.gCurrRegisteredDate = dr[5].ToString();
                    Global.gCurrProjectName = dr[6].ToString();
                    Global.gCITicket = dr[7].ToString();
                    Global.gCurrBlock = dr[8].ToString();
                    Global.gCurrRAGStatus = dr[9].ToString();
                    Global.gCurrExpecStart = dr[10].ToString();
                    Global.gCurrExpecFinish = dr[11].ToString();
                    Global.gCurrActualStart = dr[12].ToString();
                    Global.gCurrActualFinish = dr[13].ToString();
                    Global.gCurrProjectStatus = " PROJECT STATUS : " + dr[14].ToString();
                    Global.gCurrDescription = dr[15].ToString();
                    Global.gCurrCurrentStatus = dr[16].ToString();
                    Global.gCurrCustomer = dr[17].ToString();
                    Global.gCurrServiceLines = dr[18].ToString();
                    Global.gCurrTechnologies = dr[19].ToString();
                    Global.gCurrProjectStaff = dr[20].ToString();
                    Global.gCurrOnsite = dr[21].ToString();
                    Global.gCurrOffshore = dr[22].ToString();
                    Global.gCurrCompetency = dr[23].ToString();
                    Global.gCurrProjectTeam = dr[24].ToString();
                    Global.gCurrKeyrisk = dr[25].ToString();
                    Global.gCurrDBASQL = dr[26].ToString();
                    Global.gCurrDBAORA = dr[27].ToString();
                    Global.gCurrDBABO = dr[28].ToString();
                    Global.gCurrInformatica = dr[29].ToString();
                    Global.gCurrCitrixArch = dr[30].ToString();
                    Global.gCurrCitrixDev = dr[31].ToString();
                    Global.gCurrWeblogic = dr[32].ToString();
                    Global.gCurrWebsphere = dr[33].ToString();
                    Global.gCurrIIS = dr[34].ToString();
                    Global.gCurrDocumentum = dr[35].ToString();
                    Global.gCurrSnTSolEng = dr[36].ToString();
                    Global.gCurrSnTSolBuilder = dr[37].ToString();
                    Global.gCurrSnTSolArch = dr[38].ToString();
                    Global.gCurrJBOSS = dr[39].ToString();
                    Global.gCurrProjectManager = dr[40].ToString();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }


            # endregion

            #region: GET ALL THE UPDATES RELATED TO THE ND
            string sUpdatesHistory = "";
            OleDbCommand cmdUpdates = new OleDbCommand("select LastUpdatedDate,CurrentStatus from UpdateTracker where NewDemandNo = '" + Global.gCurrND + "' order by UpdateNo", Global.GlobalConnection);
            OleDbDataReader drUpdates = cmdUpdates.ExecuteReader();

            //sUpdatesHistory = " <tr>" +
            //                      "<td valign='Top'><b>UPDATES HISTORY</b></td>" +
            //                      "<td valign='Top'>" +
            //                       "<table width='100%' style='font-family: Tahoma;font-size: 10pt'>" +
            //                        "<th>" +
            //                         "<td>UPDATED DATE</td>" +
            //                         "<td>STATUS UPDATE</td>" +
            //                        "</th>";

            for (; ; )
            {
                try
                {
                    drUpdates.Read();
                    sUpdatesHistory = sUpdatesHistory + "<tr>" +
                                       "<td>" + drUpdates[0].ToString() + "</td>" +
                                       "<td>" + drUpdates[1].ToString() + "</td>" +
                                      "</tr>";
                    //MessageBox.Show(drUpdates[0].ToString());
                    //MessageBox.Show(drUpdates[1].ToString());
                }
                catch (Exception ex)
                {
                    //sUpdatesHistory = sUpdatesHistory + 
                    //                  "</table>" +
                    //                  "</td>" +
                    //                  "</tr>";
                    break;
                }


            }
            //while (drUpdates.Read())
            //{
            //    MessageBox.Show(drUpdates[0].ToString());
            //    MessageBox.Show(drUpdates[1].ToString());
            //}

            //while (drUpdates.Read())
            //{
            //    MessageBox.Show(drUpdates[0].ToString());
            //    MessageBox.Show(drUpdates[1].ToString());
            //}
            #endregion

            #region: EMAILING THE COMPLETE STORY


            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("172.19.98.22", 25);

                mail.From = new MailAddress("InFlightNewDemands@Ikran.com");
                mail.To.Add(txtTo.Text.Trim());
                mail.CC.Add(txtCc.Text.Trim());
                
                mail.Subject = txtSubject.Text;

                mail.IsBodyHtml = true;
                string htmlBody;
                string sEmailBodyNoti;



                sEmailBodyNoti = "" +
                                "<tr>" +
                                "<td colspan=2><span style='font-family: Tahoma;font-size: 10pt'><BR><br><br>" +
                                " <table width='100%' style='font-family: Tahoma;font-size: 10pt'>" +
                    //NEW DEMAND / CATALOGUE ITEM
                              " <tr>" +
                                 "<td valign='Top'><b>" + Global.gTypeText + "</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrND + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //LAMP ID
                               " <tr>" +
                                 "<td valign='Top'><b>LAMP ID<b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrLampID + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //RFS ID
                               " <tr>" +
                                 "<td valign='Top'><b>RFS ID<b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrRFS + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //DEPARTMENT
                               " <tr>" +
                                 "<td valign='Top'><b>DEPARTMENT<b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrDept + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //REGISTERED DATE
                               " <tr>" +
                                 "<td valign='Top'><b>REGISTERED DATE<b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrRegisteredDate + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //PROJECT NAME
                               " <tr>" +
                                 "<td valign='Top'><b>PROJECT NAME</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrProjectName + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //TICKET ID
                               " <tr>" +
                                 "<td valign='Top'><b>TICKET ID</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCITicket + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //BLOCK
                               " <tr>" +
                                 "<td valign='Top'><b>BLOCK</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrBlock + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //RAG STATUS
                               " <tr>" +
                                 "<td valign='Top'><b>RAG STATUS</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrRAGStatus + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //EXPECTED START DATE
                               " <tr>" +
                                 "<td valign='Top'><b>EXPECTED START DATE</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrExpecStart + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //EXPECTED FINISH DATE
                               " <tr>" +
                                 "<td valign='Top'><b>EXPECTED FINISH DATE</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrExpecFinish + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //ACTUAL START DATE
                               " <tr>" +
                                 "<td valign='Top'><b>ACTUAL DATE</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrActualStart + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //ACTUAL FINISH DATE
                               " <tr>" +
                                 "<td valign='Top'><b>ACTUAL FINISH</b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrActualFinish + "'</b><BR><BR></td>" +
                               "</tr>" +
                    //PROJECT STATUS
                                " <tr>" +
                                  "<td valign='Top'><b>PROJECT STATUS</b></td>" +
                                  "<td valign='Top'> <b>'" + Global.gCurrProjectStatus + "'</b><BR><BR></td>" +
                                "</tr>" +
                    //DESCRIPTION
                                " <tr>" +
                                "<td valign='Top'><b>DESCRIPTION </b></td>" +
                                "<td valign='Top'> <b>'" + Global.gCurrDescription + "'</b><BR><BR></td>" +
                                "</tr>" +
                    //CURRENT STATUS 
                                " <tr>" +
                                "<td valign='Top'><b>CURRENT STATUS </b></td>" +
                                "<td valign='Top'> <b>'" + Global.gCurrCurrentStatus + "'</b><BR><BR></td>" +
                                "</tr>" +

                    //UPDATES HISTORY
                               "<tr>" +
                               "<td valign='Top'><b>UPDATES HISTORY</b></td>" +
                               "<td>" +
                                "<table width='100%' style='font-family: Tahoma;font-size: 10pt'border=1>" +
                                  "<tr>" +
                                   "<td>UPDATED DATE</td>" +
                                   "<td>STATUS UPDATE</td>" +
                                 "</tr>" + sUpdatesHistory +
                                "</table>" +
                               "</td>" +
                               "</tr>" +

                    //CUSTOMER CONTACTS
                                " <tr>" +
                                "<td valign='Top'><b>CUSTOMER CONTACTS </b></td>" +
                                "<td valign='Top'> <b>'" + Global.gCurrCustomer + "'</b><BR><BR></td>" +
                                "</tr>" +
                    //SERVICE LINES
                                " <tr>" +
                                "<td valign='Top'><b>SERVICE LINES </b></td>" +
                                "<td valign='Top'> <b>'" + Global.gCurrServiceLines + "'</b><BR><BR></td>" +
                                "</tr>" +

                    //PROJECT MANAGER
                                " <tr>" +
                                "<td valign='Top'><b>PROJECT MANAGER</b></td>" +
                                "<td valign='Top'> <b>'" + Global.gCurrProjectManager + "'</b><BR><BR></td>" +
                                "</tr>" +
                                "</table><BR><BR></span>" +
                                "</td>" +
                                "</tr>";



                htmlBody = Global.gEmailHeader + sEmailBodyNoti + Global.gEmailFooter;

                mail.Body = htmlBody;

                // mail.Subject = "TEST MAIL";

                //mail.Body = htmlBody;
                //SmtpServer.Port = 587;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                //SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail); 
                //MessageBox.Show("EMAIL SENT SUCCESSFULLY";
                //MessageBox.Show("Email Sent"); 
                //return iRet;
            }

            catch (Exception ex)
            {
                //iRet = 1;
                //return iRet;
                //throw ex;
                //lblStatus.Text = " ERROR SENDING MAIL" + ex.Message.ToString() ;
                MessageBox.Show(" ERROR SENDING MAIL" + ex.Message.ToString()) ;
            }

            #endregion

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();

        }

        
    }
}
