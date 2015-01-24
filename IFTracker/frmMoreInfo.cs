using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IFTracker
{
    public partial class frmMoreInfo : Form
    {
        public delegate void delPassMoreInfo(TextBox txt);

        public frmMoreInfo()
        {
            InitializeComponent();
        }

        private void frmMoreInfo_Load(object sender, EventArgs e)
        {
            rtxtMore.Text = Global.gMoreInfo;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Global.gMoreInfo = rtxtMore.Text;   
            //MessageBox.Show(Global.gMoreInfo);
            frmAdd frm = new frmAdd(Global.gMoreInfoCount);
            //frmAdd frm = new frmAdd();
            //frm.SetMoreInfo();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}