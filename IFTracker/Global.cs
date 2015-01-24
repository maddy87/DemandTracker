using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IFTracker
{
    public static class Global
    {
        //Declaring Global Variables to be used in the application

        //GLOBAL VALUE FOR STORING THE CURRENT USER NAME.
        public static string gCurrentUser;

        //VALUE FOR MAINTAINING THE VERSIONING INFORMATION
        public static string gCurrentFileName;

        
        // DB LOCATION
        
        public static string gIFDT_connnectionString = "Provider=Microsoft.Jet.OleDB.4.0;Data Source =D:\\IFT\\IFDT.mdb";

        //GLOBAL VARIABLE FOR DISPLAYING THE STATUS OF THE CURRENT OPERATION.
        public static string gDisplayText;

        //GLOBAL DATA INCLUDED FOR DATABASE CONNECTION
        public static OleDbConnection GlobalConnection = new OleDbConnection(Global.gIFDT_connnectionString);

        //GLOBAL VAIRABLE TO STORE THE MORE INFO WALA INFORMATION.
        public static string gMoreInfo;


        //ALL CURRENT GLOBAL VARIABLES

        public static string gCurrRequest; //NEW , MODIFY , UPDATE
        public static string gType;
        public static string gCurrType; // DONT WANNA MESS UP WITH THE ALREADY GLOBAL TYPE VARIABLE
        public static string gCurrRFS;
        public static string gCurrND;
        public static string gCurrNDCI;
        public static string gCurrBlock;
        public static string gCurrRAGStatus;
        public static string gCurrDept;
        public static string gCurrLampID;
        public static string gCurrTechnologies;
        public static string gCurrCompetency;
        public static string gCurrDBASQL;
        public static string gCurrDBAORA;
        public static string gCurrDBABO;
        public static string gCurrInformatica;
        public static string gCurrCitrixArch;
        public static string gCurrCitrixDev;
        public static string gCurrWeblogic;
        public static string gCurrIIS;
        public static string gCurrDocumentum;
        public static string gCurrSnTSolEng;
        public static string gCurrSnTSolBuilder;
        public static string gCurrSnTSolArch;
        public static string gCurrJBOSS;
        public static string gCurrWebsphere;
        public static string gCurrProjectName;
        public static string gCurrDescription;
        public static string gCurrCurrentStatus;
        public static string gCurrKeyrisk;
        public static string gCurrProjectTeam;
        public static string gCurrServiceLines;
        public static string gCurrProjectManager;
        public static string gCurrProjectStaff;
        public static string gCurrOnsite;
        public static string gCurrOffshore;
        public static string gCurrProjectStatus;
        public static string gCurrCustomer;
        public static string gCurrExpecStart;
        public static string gCurrExpecFinish;
        public static string gCurrActualStart;
        public static string gCurrActualFinish;
        public static string gCurrRegisteredDate;
        public static string gCITicket;
        public static int gCurrUpdateNo;
        public static int gMoreInfoCount;
        public static string gCurrLastUpdatedDate;
        public static string gExportFilename;
        public static int gExportProgressStatus;
        //GLOBAL DATA FOR THE STATIC EMAIL TEMPLATE;

       #region: DEFINING STATIC EMAIL CONTENT FOR MAIL NOTIFICATIONS

       public static string gTypeText = "NOT INITIALIZED";
      
       

       public static string gEmailHeader =   "<html>" +
                           "<body>" +
                           "<table border='0'cellpadding='0' cellspacing='0' style='width:700px'>" +
                           "<tr>" +
                            "<td>" +
                            "<table style='width:100%;' border=0 cellspacing=0 cellpadding=0 >" +
                              " <tr>" +
                                "<td valign='bottom' align='left' style='color: #4C4C4C;background-color: #B1A5B6;padding: 5px 5px 5px 5px'>" +
                                 
                                //"<td align='right' style='color: #4C4C4C;background-color: #B1A5B6;padding: 8px; font-family:Tahoma; font-size:17pt;color:#4C4C4C'><BR></td> " +
                              "</tr>" +
                            "</table>" +
                           "</td>" +
                          "</tr><td style='font-size: 8pt; font-family: Tahoma;padding: 1px;'><BR></td></tr>" +
                          "</tr><td style='font-size: 8pt; font-family: Tahoma; background-color: #92B0E2; padding: 5px;'><BR></td></tr>" +
                          "</tr><td style='font-size: 8pt; font-family: Tahoma;padding: 1px;'><BR></td></tr>" +
                          "<tr><td align='left' style='color: #4C4C4C;background-color: #B1A5B6;padding: 8px; font-family:Verdana; font-size:15pt;color:#484888' >INFLIGHT NEW DEMANDS/CATALOGUE ITEMS</td></tr> " ;


        //public static string gEmailBodyNoti = "" +
        //                    "<tr>" +
        //                     "<td colspan=2><span style='font-family: Tahoma;font-size: 10pt'><BR><br><br>" +
        //                      " <table width='100%' style='font-family: Tahoma;font-size: 10pt'>" +
        //                      //NEW DEMAND / CATALOGUE ITEM
        //                      " <tr>" +
        //                         "<td valign='Top'><b>'"+Global.gTypeText+"'</b></td>" +
        //                         "<td valign='Top'> <b>'"+Global.gCurrNDCI+"'</b><BR><BR></td>" +
        //                       "</tr>" +
        //                      //RFS ID
        //                       " <tr>" +
        //                         "<td valign='Top'><b>RFS ID <b></td>" +
        //                         "<td valign='Top'> <b>'" + Global.gCurrRFS + "'</b><BR><BR></td>" +
        //                       "</tr>" +
        //                      //PROJECT NAME
        //                       " <tr>" +
        //                         "<td valign='Top'><b>PROJECT NAME </b></td>" +
        //                         "<td valign='Top'> <b>'" + Global.gCurrProjectName + "'</b><BR><BR></td>" +
        //                       "</tr>" +
        //                      //DESCRIPTION
        //                      " <tr>" +
        //                         "<td valign='Top'><b>DESCRIPTION </b></td>" +
        //                         "<td valign='Top'> <b>'" + Global.gCurrDescription + "'</b><BR><BR></td>" +
        //                       "</tr>" +
        //                      //SERVICE LINES
        //                         " <tr>" +
        //                         "<td valign='Top'><b>SERVICE LINES </b></td>" +
        //                         "<td valign='Top'> <b>'" + Global.gCurrServiceLines + "'</b><BR><BR></td>" +
        //                       "</tr>" +
        //                      //PROJECT MANAGER
        //                      " <tr>" +
        //                         "<td valign='Top'><b>PROJECT MANAGER</b></td>" +
        //                         "<td valign='Top'> <b>'" + Global.gCurrProjectManager + "'</b><BR><BR></td>" +
        //                       "</tr>" +
                                                            
        //                      "</table><BR><BR></span>" +
        //                    "</td>" +
        //                   "</tr>";
                        
                          
         
       public static string gEmailFooter =  "<tr>" +
                           "<td colspan=2  style='font-size: 8pt; font-family: Tahoma; background-color: #92B0E2; padding: 5px;'>" +
                           "For questions regarding this information please contact the " +
                           "<a style='color: #4C4C4C;' href='mailto:rajesh.shetty@Ikran.com' target=_blank> InFlight Team </a>" +
                           "<br /> </td>" +
                           "</tr>" +
                           "</tr><td style='font-size: 8pt; font-family: Tahoma;padding: 1px;'><BR></td></tr>" +
                           "</tr><td style='font-size: 8pt; font-family: Tahoma;padding: 3px;background-color: #B1A5B6'><BR></td></tr>" +
                           "</table></body></html>";
     #endregion

       
           
    }
   }
