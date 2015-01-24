using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace IFTracker
{
    public partial class frmAdd : Form
    {
        public static int iValidate;
        public static string sCurrND;
        frmMoreInfo frm = new frmMoreInfo();
        frmLoading frmLoad = new frmLoading();
        
        public frmAdd()
        {
            InitializeComponent();
            //SetMoreInfo();
         
        }

        public frmAdd(int iMoreInfoCount)
        {
            InitializeComponent();
            SetMoreInfo();
        }

        private void lblProposedStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            int iRet =  ValidateFormData();
            if (iRet == 1)
            {
                //Do Nothing
                lblErrReporting.Text = "PLEASE PROVIDE VALID DETAILS AND PUT 'NA' IF NO INFORMATION IS AVAILABLE";
            }
            else
            {
                lblErrReporting.Text = "";
                if (Global.gCurrRequest == "NEW")
                {
                    AddNewDemand();
                }
                else
                {
                    UpdateND();
                }
            }
            //MessageBox.Show(i);
            
        }

        public int ValidateFormData()
        {
            iValidate = 0;

            if (txtND.Text == "")
            {
                txtND.BackColor = System.Drawing.Color.Khaki;
                txtND.Focus();
                txtND.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtND.BackColor = System.Drawing.SystemColors.Window;
                txtND.Focus();

            }

            if (txtCITicket.Text == "")
            {
                txtCITicket.BackColor = System.Drawing.Color.Khaki;
                txtCITicket.Focus();
                txtCITicket.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtCITicket.BackColor = System.Drawing.SystemColors.Window;
                txtCITicket.Focus();

            }

            if (txtLampID.Text == "")
            {
                txtLampID.BackColor = System.Drawing.Color.Khaki;
                txtLampID.Focus();
                txtLampID.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtLampID.BackColor = System.Drawing.SystemColors.Window;
                txtLampID.Focus();
                
            }

            if (txtRFS.Text == "")
            {
                txtRFS.BackColor = System.Drawing.Color.Khaki;
                txtRFS.Focus();
                txtRFS.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtRFS.BackColor = System.Drawing.SystemColors.Window;
                txtRFS.Focus();

            }

            if (txtBlock.Text == "")
            {
                txtBlock.BackColor = System.Drawing.Color.Khaki;
                txtBlock.Focus();
                txtBlock.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtBlock.BackColor = System.Drawing.SystemColors.Window;
                txtBlock.Focus();

            }

            if (txtRAG.Text == "")
            {
                txtRAG.BackColor = System.Drawing.Color.Khaki;
                txtRAG.Focus();
                txtRAG.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtRAG.BackColor = System.Drawing.SystemColors.Window;
                txtRAG.Focus();

            }

            if (txtDept.Text == "")
            {
                txtDept.BackColor = System.Drawing.Color.Khaki;
                txtDept.Focus();
                txtDept.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtDept.BackColor = System.Drawing.SystemColors.Window;
                txtDept.Focus();

            }

            if (txtTechnologies.Text == "")
            {
                txtTechnologies.BackColor = System.Drawing.Color.Khaki;
                txtTechnologies.Focus();
                txtTechnologies.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtTechnologies.BackColor = System.Drawing.SystemColors.Window;
                txtTechnologies.Focus();

            }

            if (txtCompetency.Text == "")
            {
                txtCompetency.BackColor = System.Drawing.Color.Khaki;
                txtCompetency.Focus();
                txtCompetency.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtCompetency.BackColor = System.Drawing.SystemColors.Window;
                txtCompetency.Focus();

            }

            if (txtDBAORA.Text == "")
            {
                txtDBAORA.BackColor = System.Drawing.Color.Khaki;
                txtDBAORA.Focus();
                txtDBAORA.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtDBAORA.BackColor = System.Drawing.SystemColors.Window;
                txtDBAORA.Focus();

            }

            if (txtDBASQL.Text == "")
            {
                txtDBASQL.BackColor = System.Drawing.Color.Khaki;
                txtDBASQL.Focus();
                txtDBASQL.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtDBASQL.BackColor = System.Drawing.SystemColors.Window;
                txtDBASQL.Focus();

            }
            
            if (txtBO.Text == "")
            {
                txtBO.BackColor = System.Drawing.Color.Khaki;
                txtBO.Focus();
                txtBO.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtBO.BackColor = System.Drawing.SystemColors.Window;
                txtBO.Focus();
            }
            if (txtIIS.Text == "")
            {
                txtIIS.BackColor = System.Drawing.Color.Khaki;
                txtIIS.Focus();
                txtIIS.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtIIS.BackColor = System.Drawing.SystemColors.Window;
                txtIIS.Focus();
            }

            if (txtDocumentum.Text == "")
            {
                txtDocumentum.BackColor = System.Drawing.Color.Khaki;
                txtDocumentum.Focus();
                txtDocumentum.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtDocumentum.BackColor = System.Drawing.SystemColors.Window;
                txtDocumentum.Focus();
            }

            if (txtInformatica.Text == "")
            {
                txtInformatica.BackColor = System.Drawing.Color.Khaki;
                txtInformatica.Focus();
                txtInformatica.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtInformatica.BackColor = System.Drawing.SystemColors.Window;
                txtInformatica.Focus();
            }
            if (txtCitrixarch.Text == "")
            {
                txtCitrixarch.BackColor = System.Drawing.Color.Khaki;
                txtCitrixarch.Focus();
                txtCitrixarch.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtCitrixarch.BackColor = System.Drawing.SystemColors.Window;
                txtCitrixarch.Focus();
            }

            if (txtCitrixDev.Text == "")
            {
                txtCitrixDev.BackColor = System.Drawing.Color.Khaki;
                txtCitrixDev.Focus();
                txtCitrixDev.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtCitrixDev.BackColor = System.Drawing.SystemColors.Window;
                txtCitrixDev.Focus();
            }

            if (txtWeblogic.Text == "")
            {
                txtWeblogic.BackColor = System.Drawing.Color.Khaki;
                txtWeblogic.Focus();
                txtWeblogic.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtWeblogic.BackColor = System.Drawing.SystemColors.Window;
                txtWeblogic.Focus();
            }

            if (txtWeblogic.Text == "")
            {
                txtWebsphere.BackColor = System.Drawing.Color.Khaki;
                txtWebsphere.Focus();
                txtWebsphere.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtWebsphere.BackColor = System.Drawing.SystemColors.Window;
                txtWebsphere.Focus();
            }

            if (txtJBOSS.Text == "")
            {
                txtJBOSS.BackColor = System.Drawing.Color.Khaki;
                txtJBOSS.Focus();
                txtJBOSS.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtJBOSS.BackColor = System.Drawing.SystemColors.Window;
                txtJBOSS.Focus();
            }


            if (txtSnTArch.Text == "")
            {
                txtSnTArch.BackColor = System.Drawing.Color.Khaki;
                txtSnTArch.Focus();
                txtSnTArch.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtSnTArch.BackColor = System.Drawing.SystemColors.Window;
                txtSnTArch.Focus();
            }

            if (txtSnTSolB.Text == "")
            {
                txtSnTSolB.BackColor = System.Drawing.Color.Khaki;
                txtSnTSolB.Focus();
                txtSnTSolB.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtSnTSolB.BackColor = System.Drawing.SystemColors.Window;
                txtSnTSolB.Focus();
            }
            if (txtSnTSolE.Text == "")
            {
                txtSnTSolE.BackColor = System.Drawing.Color.Khaki;
                txtSnTSolE.Focus();
                txtSnTSolE.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtSnTSolE.BackColor = System.Drawing.SystemColors.Window;
                txtSnTSolE.Focus();
            }
            if (txtProjectName.Text == "")
            {
                txtProjectName.BackColor = System.Drawing.Color.Khaki;
                txtProjectName.Focus();
                txtProjectName.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtProjectName.BackColor = System.Drawing.SystemColors.Window;
                txtProjectName.Focus();
            }

            if (txtDescription.Text == "")
            {
                txtDescription.BackColor = System.Drawing.Color.Khaki;
                txtDescription.Focus();
                txtDescription.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtDescription.BackColor = System.Drawing.SystemColors.Window;
                txtDescription.Focus();
            }
            if (txtCurrentStatus.Text == "")
            {
                txtCurrentStatus.BackColor = System.Drawing.Color.Khaki;
                txtCurrentStatus.Focus();
                txtCurrentStatus.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
                txtCurrentStatus.Focus();
            }
            if (txtKeyRisk.Text == "")
            {
                txtKeyRisk.BackColor = System.Drawing.Color.Khaki;
                txtKeyRisk.Focus();
                txtKeyRisk.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtKeyRisk.BackColor = System.Drawing.SystemColors.Window;
                txtKeyRisk.Focus();
            }
            if (txtCustomerContacts.Text == "")
            {
                txtCustomerContacts.BackColor = System.Drawing.Color.Khaki;
                txtCustomerContacts.Focus();
                txtCustomerContacts.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtCustomerContacts.BackColor = System.Drawing.SystemColors.Window;
                txtCustomerContacts.Focus();
            }

            if (txtServiceLines.Text == "")
            {
                txtServiceLines.BackColor = System.Drawing.Color.Khaki;
                txtServiceLines.Focus();
                txtServiceLines.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtServiceLines.BackColor = System.Drawing.SystemColors.Window;
                txtServiceLines.Focus();
            }
            if (txtProjectTeam.Text == "")
            {
                txtProjectTeam.BackColor = System.Drawing.Color.Khaki;
                txtProjectTeam.Focus();
                txtProjectTeam.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtProjectTeam.BackColor = System.Drawing.SystemColors.Window;
                txtProjectTeam.Focus();
            }

            if (txtProjManager.Text == "")
            {
                txtProjManager.BackColor = System.Drawing.Color.Khaki;
                txtProjManager.Focus();
                txtProjManager.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtProjManager.BackColor = System.Drawing.SystemColors.Window;
                txtProjManager.Focus();
            }


            if (txtProposedStaff.Text == "")
            {
                txtProposedStaff.BackColor = System.Drawing.Color.Khaki;
                txtProposedStaff.Focus();
                txtProposedStaff.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtProposedStaff.BackColor = System.Drawing.SystemColors.Window;
                txtProposedStaff.Focus();
            }

            if (txtOnsite.Text == "")
            {
                txtOnsite.BackColor = System.Drawing.Color.Khaki;
                txtOnsite.Focus();
                txtOnsite.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtOnsite.BackColor = System.Drawing.SystemColors.Window;
                txtOnsite.Focus();
            }

            if (txtOffshore.Text == "")
            {
                txtOffshore.BackColor = System.Drawing.Color.Khaki;
                txtOffshore.Focus();
                txtOffshore.BorderStyle = BorderStyle.Fixed3D;
                iValidate = 1;
            }
            else
            {
                txtOffshore.BackColor = System.Drawing.SystemColors.Window;
                txtOffshore.Focus();
            }

            return iValidate;
        }

        private void txtDocumentum_TextChanged(object sender, EventArgs e)
        {

        }

        #region: REGISTERING A NEW DEMAND 
        public void AddNewDemand()
        {
            try
            {
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmdUpdateTracker = new OleDbCommand();

            ///Finally implementing DateTime .
            CultureInfo culture = new CultureInfo("en-US");
            DateTime dtExpStart = Convert.ToDateTime(txtExpectedStart.Text, culture);
            DateTime dtExpFinish = Convert.ToDateTime(txtExpectedFinish.Text, culture);
            DateTime dtActStart = Convert.ToDateTime(txtActualStart.Text, culture);
            DateTime dtActFinish = Convert.ToDateTime(txtActualFinish.Text, culture);
            DateTime dtRegDate = Convert.ToDateTime(txtRegisteredDate.Text, culture);

            #region: INSERTION OF DATA INTO THE MASTER TABLE AND UPDATE TRACKER TABLE

            int id = 0;
            //string tempND = "ND-999";

            if (Global.gTypeText == "NEW DEMAND")
            {

                cmd.CommandText = "insert into Master(Type,NewDemandNo,LampID,RFS,Department,RegisteredDate,ProjectName,TicketID,Block,RAGStatus, " +
                                  "ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus,Description,CurrentStatus, " +
                                  "CustomerContacts,ServiceLines,Technologies,ProposedStaffing,Onsite,Offshore,CompetencyLevelRequired," +
                                  "ProjectTeam,KeyRisks,DBASQL,DBAORA,BO,Informatica,CitrixArchitect,CitrixDevelopers,Weblogic,Websphere," +
                                  "IIS,Documentum,SnTSolutionEngg,SntSolutionBuilder,SntArchitect,JBOSS,PM) values " +
                                  "('" + Global.gType + "','" + lblNDNo.Text + "','" + txtLampID.Text + "','" + txtRFS.Text + "' " +
                                  ",'" + txtDept.Text + "','" + dtRegDate + "','" + txtProjectName.Text + "','" + txtCITicket.Text + "' " +
                                  ",'" + txtBlock.Text + "','" + txtRAG.Text + "','" + dtExpStart + "','" + dtExpFinish + "','" + dtActStart + "' " +
                                  ",'" + dtActFinish + "','" + cmbProjectStatus.Text + "','" + txtDescription.Text + "','" + txtCurrentStatus.Text + "' " +
                                  ",'" + txtCustomerContacts.Text + "','" + txtServiceLines.Text + "','" + txtTechnologies.Text + "','" + txtProposedStaff.Text + "' " +
                                  ",'" + txtOnsite.Text + "','" + txtOffshore.Text + "','" + txtCompetency.Text + "','" + txtProjectTeam.Text + "','" + txtKeyRisk.Text + "' " +
                                  ",'" + txtDBASQL.Text + "','" + txtDBAORA.Text + "','" + txtBO.Text + "','" + txtInformatica.Text + "','" + txtCitrixarch + "' " +
                                  ",'" + txtCitrixDev.Text + "','" + txtWeblogic.Text + "','" + txtWebsphere.Text + "','" + txtIIS.Text + "','" + txtDocumentum.Text + "' " +
                                  ",'" + txtSnTSolE.Text + "','" + txtSnTSolB.Text + "','" + txtSnTArch.Text + "','" + txtJBOSS.Text + "','" + txtProjManager.Text + "') ";

                string sUpdatedDT = "02-02-2011";// DateTime.Now.ToString();

                /////////// THIS WILL REQUIRE THAT I WILL HAVE TO ENTER DATA FOR ALL THE CURRENT ND'S PRESENT IN INFLIGHT TRACKER

                int UpdateNo = 0;
                cmdUpdateTracker.CommandText = "insert into UpdateTracker(Type,NewDemandNo,ProjectName,TicketID,UpdateNo,Description,CurrentStatus, " +
                                   " ServiceLines,Technologies,LastUpdatedDate,PM) values('" + Global.gType + "','" + lblNDNo.Text + "','" + txtProjectName.Text + "' " +
                                   " ,'" + txtCITicket.Text + "','" + UpdateNo + "','" + txtDescription.Text + "','" + txtCurrentStatus.Text + "','" + txtServiceLines.Text + "' " +
                                   " ,'" + txtTechnologies.Text + "','" + DateTime.Now.ToShortDateString() + "','" + txtProjManager.Text + "')";

            }
            else
            {

                cmd.CommandText = "insert into Master(Type,NewDemandNo,LampID,RFS,Department,RegisteredDate,ProjectName,TicketID,Block,RAGStatus, " +
                                "ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus,Description,CurrentStatus, " +
                                "CustomerContacts,ServiceLines,Technologies,ProposedStaffing,Onsite,Offshore,CompetencyLevelRequired," +
                                "ProjectTeam,KeyRisks,DBASQL,DBAORA,BO,Informatica,CitrixArchitect,CitrixDevelopers,Weblogic,Websphere," +
                                "IIS,Documentum,SnTSolutionEngg,SntSolutionBuilder,SntArchitect,JBOSS,PM) values " +
                                "('" + Global.gType + "','" + txtND.Text + "','" + txtLampID.Text + "','" + txtRFS.Text + "' " +
                                ",'" + txtDept.Text + "','" + dtRegDate + "','" + txtProjectName.Text + "','" + txtCITicket.Text + "' " +
                                ",'" + txtBlock.Text + "','" + txtRAG.Text + "','" + dtExpStart + "','" + dtExpFinish + "','" + dtActStart + "' " +
                                ",'" + dtActFinish + "','" + cmbProjectStatus.Text + "','" + txtDescription.Text + "','" + txtCurrentStatus.Text + "' " +
                                ",'" + txtCustomerContacts.Text + "','" + txtServiceLines.Text + "','" + txtTechnologies.Text + "','" + txtProposedStaff.Text + "' " +
                                ",'" + txtOnsite.Text + "','" + txtOffshore.Text + "','" + txtCompetency.Text + "','" + txtProjectTeam.Text + "','" + txtKeyRisk.Text + "' " +
                                ",'" + txtDBASQL.Text + "','" + txtDBAORA.Text + "','" + txtBO.Text + "','" + txtInformatica.Text + "','" + txtCitrixarch + "' " +
                                ",'" + txtCitrixDev.Text + "','" + txtWeblogic.Text + "','" + txtWebsphere.Text + "','" + txtIIS.Text + "','" + txtDocumentum.Text + "' " +
                                ",'" + txtSnTSolE.Text + "','" + txtSnTSolB.Text + "','" + txtSnTArch.Text + "','" + txtJBOSS.Text + "','" + txtProjManager.Text + "') ";

                string sUpdatedDT = "02-02-2011";// DateTime.Now.ToString();

                /////////// THIS WILL REQUIRE THAT I WILL HAVE TO ENTER DATA FOR ALL THE CURRENT ND'S PRESENT IN INFLIGHT TRACKER

                int UpdateNo = 0;
                cmdUpdateTracker.CommandText = "insert into UpdateTracker(Type,NewDemandNo,ProjectName,TicketID,UpdateNo,Description,CurrentStatus, " +
                                   " ServiceLines,Technologies,LastUpdatedDate,PM) values('" + Global.gType + "','" + txtND.Text + "','" + txtProjectName.Text + "' " +
                                   " ,'" + txtCITicket.Text + "','" + UpdateNo + "','" + txtDescription.Text + "','" + txtCurrentStatus.Text + "','" + txtServiceLines.Text + "' " +
                                   " ,'" + txtTechnologies.Text + "','" + DateTime.Now.ToShortDateString() + "','" + txtProjManager.Text + "')";

            }
            cmd.Connection = Global.GlobalConnection;
            cmdUpdateTracker.Connection = Global.GlobalConnection;
            ///conn.Open();
            
                cmd.ExecuteNonQuery();
                //MessageBox.Show("NEW DEMAND ADDEDD SUCCESSFULLY");
                cmdUpdateTracker.ExecuteNonQuery();
                if (Global.gType == "ND")
                {
                 MessageBox.Show("NEW DEMAND ADDEDD SUCCESSFULLY");
                }
                else
                {
                 MessageBox.Show("NEW CI ADDEDD SUCCESSFULLY");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UNABLE TO MODIFY THE ND", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {


            }

            #endregion
        }

        #endregion

        private void btnTechMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 1;
            Global.gMoreInfo = txtTechnologies.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
                        
        }

        private void btnCompeMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 2;
            Global.gMoreInfo = txtCompetency.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
        }

        private void btnTeamMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 3;
            Global.gMoreInfo = txtProjectTeam.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
        }

        private void btnStaffMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 4;
            Global.gMoreInfo = txtProposedStaff.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
        }

        private void btnDescpMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 5;
            Global.gMoreInfo = txtDescription.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
        }

        private void btnCurrentMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 6;
            Global.gMoreInfo = txtCurrentStatus.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
        }

        private void btnRiskMORE_Click(object sender, EventArgs e)
        {
            Global.gMoreInfoCount = 7;
            Global.gMoreInfo = txtKeyRisk.Text;
            frm.ShowDialog();
            //ShowMoreInfo();
        }
        

        private void frmAdd_Load(object sender, EventArgs e)
        {
            //CHECK IF THE REQUEST IS TO ADD A NEW DEMAND OR EDIT/MODIFY AN EXISTING ONE

            //lblTicketId.Visible = false;
            //txtCITicket.Visible = false;

            if (Global.gCurrRequest == "NEW")
            {

                if (Global.gTypeText == "NEW DEMAND")
                {
                    BackgroundWorker bgGetMaxND = new BackgroundWorker();
                    bgGetMaxND.DoWork += new DoWorkEventHandler(bgGetMaxND_DoWork);
                    bgGetMaxND.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgGetMaxND_RunWorkerCompleted);
                    bgGetMaxND.RunWorkerAsync();
                    txtND.Visible = false;
                }
                else
                {
                    //DO NOTHING;
                    lblNDNo.Text = "ND#";
                    txtND.Visible = true;
                    btnFunction.Text = "ADD THE CATALOGUE ITEM";
                }

           
            }
            else if (Global.gCurrRequest == "MODIFY")
            {

                
                    BackgroundWorker bg_Modify = new BackgroundWorker();
                    bg_Modify.DoWork += new DoWorkEventHandler(bg_Modify_DoWork);
                    bg_Modify.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_Modify_RunWorkerCompleted);
                    bg_Modify.RunWorkerAsync();
                    if (Global.gTypeText == "NEW DEMAND")
                    {
                      btnFunction.Text = "MODIFY " + Global.gCurrND;
                    }
                    else
                    {
                      btnFunction.Text = "MODIFY " + Global.gCITicket;
                    }
                    frmLoad.Show();
           
            }
            else
            {
                
                BackgroundWorker bgUpdateND = new BackgroundWorker();
                bgUpdateND.DoWork += new DoWorkEventHandler(bgUpdateND_DoWork);
                bgUpdateND.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgUpdateND_RunWorkerCompleted);
                bgUpdateND.RunWorkerAsync();
                //Global.gDisplayText = "RETRIEVING " + Global.gCITicket + " INFO";
                frmLoad.Show();

            }

            #region: MORE INFO CODE

            if (Global.gMoreInfoCount > 0)
            {
               // SetMoreInfo();
            }
            else
            {
                //DO NOTHING ;
            }

            #endregion

           // pnlMoreInfo.Visible = false;
        }

         #region: MODIFYING THE NEW DEMAND INFORMATION 

        void bg_Modify_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

                txtND.Text = Global.gCurrND;
                txtCITicket.Text = Global.gCITicket;
                txtLampID.Text = Global.gCurrLampID;
                txtRFS.Text = Global.gCurrRFS;
                txtDept.Text = Global.gCurrDept;
                txtRegisteredDate.Text = Global.gCurrRegisteredDate;
                txtProjectName.Text = Global.gCurrProjectName;
                txtCITicket.Text = Global.gCITicket;
                txtBlock.Text = Global.gCurrBlock;
                txtRAG.Text = Global.gCurrRAGStatus;
                txtExpectedStart.Text = Global.gCurrExpecStart;
                txtExpectedFinish.Text = Global.gCurrExpecFinish;
                txtActualStart.Text = Global.gCurrActualStart;
                txtActualFinish.Text = Global.gCurrActualFinish;
                lblCurrProjStatus.Visible = true; 
                lblCurrProjStatus.Text = "CURRENT PROJECT STATUS : " + Global.gCurrProjectStatus;
                txtDescription.Text = Global.gCurrDescription;
                txtCurrentStatus.Text = Global.gCurrCurrentStatus;
                txtCustomerContacts.Text = Global.gCurrCustomer;
                txtServiceLines.Text = Global.gCurrServiceLines;
                txtTechnologies.Text = Global.gCurrTechnologies;
                txtProposedStaff.Text = Global.gCurrProjectStaff;
                txtOnsite.Text = Global.gCurrOnsite;
                txtOffshore.Text = Global.gCurrOffshore;
                txtCompetency.Text = Global.gCurrCompetency;
                txtProjectTeam.Text = Global.gCurrProjectTeam;
                txtKeyRisk.Text = Global.gCurrKeyrisk;
                txtDBASQL.Text = Global.gCurrDBASQL;
                txtDBAORA.Text = Global.gCurrDBAORA;
                txtBO.Text = Global.gCurrDBABO;
                txtInformatica.Text = Global.gCurrInformatica;
                txtCitrixarch.Text = Global.gCurrCitrixArch;
                txtCitrixDev.Text = Global.gCurrCitrixDev;
                txtWeblogic.Text = Global.gCurrWeblogic;
                txtWebsphere.Text = Global.gCurrWebsphere;
                txtIIS.Text = Global.gCurrIIS;
                txtDocumentum.Text = Global.gCurrDocumentum;
                txtSnTSolE.Text = Global.gCurrSnTSolEng;
                txtSnTSolB.Text = Global.gCurrSnTSolBuilder ;
                txtSnTArch.Text = Global.gCurrSnTSolArch;
                txtJBOSS.Text = Global.gCurrJBOSS;
                txtProjManager.Text = Global.gCurrProjectManager;
            
            //throw new Exception("The method or operation is not implemented.");
            frmLoad.Close();
        }

        void bg_Modify_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            OleDbCommand cmd = new OleDbCommand();

            if (Global.gTypeText == "NEW DEMAND")
            {

                cmd.CommandText = "select Type,NewDemandNo,LampID,RFS,Department,RegisteredDate,ProjectName,TicketID,Block,RAGStatus, " +
                                  "ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus,Description,CurrentStatus, " +
                                  "CustomerContacts,ServiceLines,Technologies,ProposedStaffing,Onsite,Offshore,CompetencyLevelRequired," +
                                  "ProjectTeam,KeyRisks,DBASQL,DBAORA,BO,Informatica,CitrixArchitect,CitrixDevelopers,Weblogic,Websphere," +
                                  "IIS,Documentum,SnTSolutionEngg,SntSolutionBuilder,SntArchitect,JBOSS,PM from Master where NewDemandNo = '" + Global.gCurrND + "' ";
            }
            else
            {
                cmd.CommandText = "select Type,NewDemandNo,LampID,RFS,Department,RegisteredDate,ProjectName,TicketID,Block,RAGStatus, " +
                               "ExpectedStart,ExpectedFinish,ActualStart,ActualFinish,ProjectStatus,Description,CurrentStatus, " +
                               "CustomerContacts,ServiceLines,Technologies,ProposedStaffing,Onsite,Offshore,CompetencyLevelRequired," +
                               "ProjectTeam,KeyRisks,DBASQL,DBAORA,BO,Informatica,CitrixArchitect,CitrixDevelopers,Weblogic,Websphere," +
                               "IIS,Documentum,SnTSolutionEngg,SntSolutionBuilder,SntArchitect,JBOSS,PM from Master where TicketID = '" + Global.gCITicket + "' ";
            }
            cmd.Connection = Global.GlobalConnection;
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
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
              Global.gCurrProjectStatus = dr[14].ToString();
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

    #endregion

         #region : UPDATING THE CURRENT DEMAND.

        void bgUpdateND_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        void bgUpdateND_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");


        }

    #endregion

         #region : EXTRACTING THE MAXIMUM NEW DEMAND NO

        void bgGetMaxND_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            int iND = Convert.ToInt32(sCurrND.Substring(sCurrND.Length - 3,3));
            iND++;   
            lblNDNo.Text = "ND-" + iND;
        }

        void bgGetMaxND_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");

            string type = "ND";
            OleDbCommand cmd = new OleDbCommand("select MAX(NewDemandNo) from Master where Type = '" + type + "'", Global.GlobalConnection);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sCurrND = dr[0].ToString();
            }

        }
       #endregion

        public void SetMoreInfo()
        {
            //MessageBox.Show(Global.gMoreInfo);
                            

            switch (Global.gMoreInfoCount)
            {

                case 1: txtTechnologies.Focus();
                    break;
                case 2: txtCompetency.Focus();
                    break;
                case 3: txtProjectTeam.Focus();
                    break;
                case 4: txtProposedStaff.Focus(); 
                    break;
                case 5: txtDescription.Focus(); 
                    break;
                case 6: txtCurrentStatus.Focus(); 
                    break;
                case 7: txtKeyRisk.Focus();
                    break;
                default: break;
            }

            this.Refresh();
        }

        public void UpdateND()
        {

            OleDbCommand cmdUpdate = new OleDbCommand();
            cmdUpdate.Connection = Global.GlobalConnection;


            if (Global.gTypeText == "NEW DEMAND")
            {

                cmdUpdate.CommandText = "UPDATE Master SET NewDemandNo = '"+txtND.Text+"',LampID = '"+txtLampID.Text+"',RFS = '"+txtRFS.Text+"', " +
                                  "Department = '"+txtDept.Text+"',RegisteredDate = '"+txtRegisteredDate.Text+"',ProjectName = '"+txtProjectName.Text+"', "+
                                  "TicketID = '"+txtCITicket.Text+"' ,Block = '"+txtBlock.Text+"',RAGStatus = '"+txtRAG.Text+"', " +
                                  "ExpectedStart = '"+txtExpectedStart.Text+"',ExpectedFinish = '"+txtExpectedFinish.Text+"', "+
                                  "ActualStart = '"+txtActualStart.Text+"',ActualFinish = '"+txtActualFinish.Text+"',ProjectStatus = '"+cmbProjectStatus.SelectedText+"', "+
                                  "Description = '"+txtDescription.Text+"',CurrentStatus = '"+txtCurrentStatus.Text+"', " +
                                  "CustomerContacts = '"+txtCustomerContacts.Text+"',ServiceLines = '"+txtServiceLines.Text+"', "+
                                  "Technologies = '"+txtTechnologies.Text+"',ProposedStaffing = '"+txtProposedStaff.Text+"',Onsite = '"+txtOnsite.Text+"', "+
                                  "Offshore = '"+txtOffshore.Text+"',CompetencyLevelRequired = '"+txtCompetency.Text+"'," +
                                  "ProjectTeam = '"+txtProjectTeam.Text+"',KeyRisks = '"+txtKeyRisk.Text+"',DBASQL = '"+txtDBASQL.Text+"', "+
                                  "DBAORA = '"+txtDBAORA.Text+"',BO = '"+txtBO.Text+"',Informatica = '"+txtInformatica.Text+"', "+
                                  "CitrixArchitect = '"+txtCitrixarch.Text+"',CitrixDevelopers = '"+txtCitrixDev.Text+"',Weblogic = '"+txtWeblogic.Text+"', "+
                                  "Websphere = '"+txtWebsphere.Text+"',IIS = '"+txtIIS.Text+"',Documentum = '"+txtDocumentum.Text+"', "+
                                  "SnTSolutionEngg = '"+txtSnTSolE.Text+"',SntSolutionBuilder = '"+txtSnTSolB.Text+"',SntArchitect = '"+txtSnTArch.Text+"', "+
                                  "JBOSS = '"+txtJBOSS.Text+"',PM = '"+txtProjectName.Text+"' where NewDemandNo = '" + Global.gCurrND + "' ";
            }
            else
            {
                cmdUpdate.CommandText = "UPDATE Master SET NewDemandNo = '" + txtND.Text + "',LampID = '" + txtLampID.Text + "',RFS = '" + txtRFS.Text + "', " +
                                  "Department = '" + txtDept.Text + "',RegisteredDate = '" + txtRegisteredDate.Text + "',ProjectName = '" + txtProjectName.Text + "', " +
                                  "TicketID = '" + txtCITicket.Text + "' ,Block = '" + txtBlock.Text + "',RAGStatus = '" + txtRAG.Text + "', " +
                                  "ExpectedStart = '" + txtExpectedStart.Text + "',ExpectedFinish = '" + txtExpectedFinish.Text + "', " +
                                  "ActualStart = '" + txtActualStart.Text + "',ActualFinish = '" + txtActualFinish.Text + "',ProjectStatus = '" + cmbProjectStatus.SelectedText + "', " +
                                  "Description = '" + txtDescription.Text + "',CurrentStatus = '" + txtCurrentStatus.Text + "', " +
                                  "CustomerContacts = '" + txtCustomerContacts.Text + "',ServiceLines = '" + txtServiceLines.Text + "', " +
                                  "Technologies = '" + txtTechnologies.Text + "',ProposedStaffing = '" + txtProposedStaff.Text + "',Onsite = '" + txtOnsite.Text + "', " +
                                  "Offshore = '" + txtOffshore.Text + "',CompetencyLevelRequired = '" + txtCompetency.Text + "'," +
                                  "ProjectTeam = '" + txtProjectTeam.Text + "',KeyRisks = '" + txtKeyRisk.Text + "',DBASQL = '" + txtDBASQL.Text + "', " +
                                  "DBAORA = '" + txtDBAORA.Text + "',BO = '" + txtBO.Text + "',Informatica = '" + txtInformatica.Text + "', " +
                                  "CitrixArchitect = '" + txtCitrixarch.Text + "',CitrixDevelopers = '" + txtCitrixDev.Text + "',Weblogic = '" + txtWeblogic.Text + "', " +
                                  "Websphere = '" + txtWebsphere.Text + "',IIS = '" + txtIIS.Text + "',Documentum = '" + txtDocumentum.Text + "', " +
                                  "SnTSolutionEngg = '" + txtSnTSolE.Text + "',SntSolutionBuilder = '" + txtSnTSolB.Text + "',SntArchitect = '" + txtSnTArch.Text + "', " +
                                  "JBOSS = '" + txtJBOSS.Text + "',PM = '" + txtProjectName.Text + "' where TicketID = '" + Global.gCITicket + "' ";
            }

            try
            {
                cmdUpdate.ExecuteNonQuery();
                if (Global.gTypeText == "NEW DEMAND")
                {
                    MessageBox.Show(" " + Global.gCurrND + " updated successfully");
                }
                else
                {
                    MessageBox.Show(" " + Global.gCITicket + " updated successfully");
                }
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Went Wrong Here", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void ShowMoreInfo()
        {
          //  pnlMoreInfo.Visible = true;
            //pnlMoreInfo.Width = pnlMoreInfo.Width + 250;
            //pnlMoreInfo.Height = pnlMoreInfo.Height + 250;
            //rchtxtMoreInfo.Width = rchtxtMoreInfo.Width + 140;
            //rchtxtMoreInfo.Height = rchtxtMoreInfo.Height + 20;
           //rchtxtMoreInfo.Text = Global.gMoreInfo;
            //btnMoreInfo. = pnlMoreInfo.Width - 40;

        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
           //Global.gMoreInfo = rchtxtMoreInfo.Text;
            //MessageBox.Show(Global.gMoreInfo);
            //txtCompetency.Text = Global.gMoreInfo;
            lblErrReporting.Text = Global.gMoreInfo;
            switch (Global.gMoreInfoCount)
            {
                case 1:
                    {
                        txtTechnologies.Text = Global.gMoreInfo;
                       // Global.gMoreInfo = txtTechnologies.Text;
                    }
                    break;
                case 2: txtCompetency.Text = Global.gMoreInfo;
                    break;
                case 3: txtDescription.Text = Global.gMoreInfo;
                    break;
                case 4: txtCurrentStatus.Text = Global.gMoreInfo;
                    break;
                case 5: txtKeyRisk.Text = Global.gMoreInfo;
                    break;
                case 6: txtProjectTeam.Text = Global.gMoreInfo;
                    break;
                case 7: txtProposedStaff.Text = Global.gMoreInfo;
                    break;
                default: break;
            }

          //  pnlMoreInfo.Visible = false;
       
        }

        private void btnMoreInfoCancel_Click(object sender, EventArgs e)
        {
         //   pnlMoreInfo.Visible = false;
        }

        private void frmAdd_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show(" I guess i can do this " + Global.gMoreInfo);
        }

        private void frmAdd_Activated(object sender, EventArgs e)
        {
 //           MessageBox.Show(" I guess i can do this " + Global.gMoreInfo);
        }


        #region: MORE INFO FOCUS CODE 
        private void txtTechnologies_Enter(object sender, EventArgs e)
        {
                if (Global.gMoreInfoCount == 1)
                {
                    txtTechnologies.Text = Global.gMoreInfo;
                }
        }

        private void txtCompetency_Enter(object sender, EventArgs e)
        {
            if (Global.gMoreInfoCount == 2)
            {
                txtCompetency.Text = Global.gMoreInfo;
            }
        }

        private void txtProjectTeam_Enter(object sender, EventArgs e)
        {
            if (Global.gMoreInfoCount == 3)
            {
                txtProjectTeam.Text = Global.gMoreInfo;
            }
        }

        private void txtProposedStaff_Enter(object sender, EventArgs e)
        {
            if (Global.gMoreInfoCount == 4)
            {
                txtProposedStaff.Text = Global.gMoreInfo;
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (Global.gMoreInfoCount == 5)
            {
                txtDescription.Text = Global.gMoreInfo;
            }
        }

        private void txtCurrentStatus_Leave(object sender, EventArgs e)
        {

        }

        private void txtCurrentStatus_Enter(object sender, EventArgs e)
        {
            if (Global.gMoreInfoCount == 6)
            {
                txtCurrentStatus.Text = Global.gMoreInfo;
            }
        }

        private void txtKeyRisk_Enter(object sender, EventArgs e)
        {
            if (Global.gMoreInfoCount == 7)
            {
                txtProjectTeam.Text = Global.gMoreInfo;
            }
        }

      #endregion

        
    }
}