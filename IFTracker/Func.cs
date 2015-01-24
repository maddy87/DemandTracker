using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace IFTracker
{
    public class Func
    {


        public int SendEmail()
        {
            int iRet = 0;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("172.19.98.22", 25);

                mail.From = new MailAddress("InFlightNewDemands@Ikran.com");
                mail.To.Add("rajesh.shetty@Ikran.com");
                mail.Subject = "Test Mail - 1";

                mail.IsBodyHtml = true;
                string htmlBody;
                string sEmailBodyNoti;

                #region: STATIC EMAIL CONTENT

                //htmlBody = "<html><body><table style='background:#92B0E2;width:100%;' border=0 cellspacing=0 cellpadding=0>" +
                //    "<td>test test test</td>tr></tr></table></body>";


                //htmlBody =  "<html>" +
                //           "<body>" +
                //           "<table border='0'cellpadding='0' cellspacing='0' style='width:700px'>" +
                //           "<tr>" +
                //            "<td>" +
                //            "<table style='width:100%;' border=0 cellspacing=0 cellpadding=0 >" +
                //              " <tr>" +
                //                "<td valign='bottom' align='left' style='color: #4C4C4C;background-color: #B1A5B6;padding: 5px 5px 5px 5px'>" +
                //                 "<img alt='' hspace='0' src='"+Application.StartupPath.ToString() + "\\images\\AZ.bmp' align='baseline' border='0' ></td> " +
                //                "<td align='right' style='color: #4C4C4C;background-color: #B1A5B6;padding: 8px; font-family:Tahoma; font-size:17pt;color:#4C4C4C'><BR></td> " +
                //              "</tr>" +
                //            "</table>" +
                //           "</td>" +
                //          "</tr>" +
                //          "<tr>" +
                //           "<td colspan=2><span style='font-family: Tahoma;font-size: 10pt'><BR><br><br>" +
                //              " <table width='100%' style='font-family: Tahoma;font-size: 10pt'>" +
                //               " <tr>" +
                //                  "<td valign='Top'><b> Attention:</b></td>" +
                //                  "<td valign='Top'> <b>Vishal Iyer</b></td>" +
                //               "</tr>" +
                //               "<tr>" +
                //                 "<td valign='Top'><b> Summary: </b></td>" +
                //                 "<td valign='Top'> You have requested <b>Sun Microsystems Java Runtime Environment (JRE) 1.6.0.13 (Update 13)</b> to be installed on the following Vista computer(s): <br /><br />  <b>INPUOVINFOS0389<br></b>  <br/ ><br />  Please note that application provisioning requests are processed in the order in which they are received, and could take up to two weeks from the date of request to be resolved.  <br/ ><br />  You will shortly receive a Remedy (Service Desk) incident number for your request." +
                //                                   "You can use this number to track the status of your request with the Service Desk. <br/><br/>" +
                //                                   "<b>Please note:</b> If you are submitting a request for an application that was missed at the" +
                //                                   "time of your Vista upgrade – there will be no charge for the license if the Vista version is the" +
                //                                   "same as the version installed on your TOPAZ workstation. If the Vista version is higher than the " +
                //                                   "Topaz version, and the license is locally purchased and not covered under a formal upgrade contract," +
                //                                   "you will be asked to submit a license request. </br></br>The license validation will be undertaken by" +
                //                                   "the IBM Asset Admin Team in parallel to the installation of the Application. You will be notified, either" +
                //                                   "directly or via your local License Procurement Team, if a license is required. To ensure Ikran remains" +
                //                                   "legally and contractually compliant with the Software Vendors, you will need to process the license request " +
                //                                   "within 30 days of notification. Failure to address the license purchase request within 30 days will result in" +
                //                                   "the software being uninstalled. <br/><br/> If you have any questions regarding the content of this email, please" +
                //                                   "contact your local Service Desk. Please have your Remedy incident number available for reference." +
                //               "</tr>" +
                //             "</table><BR><BR></span>" +
                //            "</td>" +
                //           "</tr>" +
                //           "<tr>" +
                //           "<td colspan=2  style='font-size: 8pt; font-family: Tahoma; background-color: #92B0E2; padding: 5px;'>" +
                //           "For questions regarding your application installation request, please contact the" +
                //           "<a style='color: #4C4C4C;' href='mailto:rajesh.shetty@Ikran.com' target=_blank>InFlight Team</a>" +
                //           "<br /> </td>" +
                //           "</tr>" +
                //           "</table></body></html>";

                //mail.Body = htmlBody;

                #endregion

                sEmailBodyNoti = "" +
                              "<tr>" +
                             "<td colspan=2><span style='font-family: Tahoma;font-size: 10pt'><BR><br><br>" +
                              " <table width='100%' style='font-family: Tahoma;font-size: 10pt'>" +
                              //NEW DEMAND / CATALOGUE ITEM
                              " <tr>" +
                                 "<td valign='Top'><b>'"+Global.gTypeText+"'</b></td>" +
                                 "<td valign='Top'> <b>'"+Global.gCurrNDCI+"'</b><BR><BR></td>" +
                               "</tr>" +
                              //RFS ID
                               " <tr>" +
                                 "<td valign='Top'><b>RFS ID <b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrRFS + "'</b><BR><BR></td>" +
                               "</tr>" +
                              //PROJECT NAME
                               " <tr>" +
                                 "<td valign='Top'><b>PROJECT NAME </b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrProjectName + "'</b><BR><BR></td>" +
                               "</tr>" +
                              //DESCRIPTION
                              " <tr>" +
                                 "<td valign='Top'><b>DESCRIPTION </b></td>" +
                                 "<td valign='Top'> <b>'" + Global.gCurrDescription + "'</b><BR><BR></td>" +
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

                mail.Subject = "TEST MAIL";

                //mail.Body = htmlBody;
                //SmtpServer.Port = 587;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                //SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("Email Sent"); 
                return iRet;
            }

            catch(Exception ex)
            {
                iRet = 1;
                return iRet;
            }
        }
    }


}
