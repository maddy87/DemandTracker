namespace IFTracker
{
    partial class frmUpdateStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblND = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDescp = new System.Windows.Forms.Label();
            this.lblPreviousUpdates = new System.Windows.Forms.Label();
            this.txtPreviousUpdates = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMoreInfoPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewUpdate = new System.Windows.Forms.TextBox();
            this.btnMoreInfoNew = new System.Windows.Forms.Button();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblND
            // 
            this.lblND.AutoSize = true;
            this.lblND.BackColor = System.Drawing.Color.SteelBlue;
            this.lblND.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblND.Location = new System.Drawing.Point(92, 31);
            this.lblND.Name = "lblND";
            this.lblND.Size = new System.Drawing.Size(134, 13);
            this.lblND.TabIndex = 0;
            this.lblND.Text = "UPDATE STATUS FOR ";
            this.lblND.Click += new System.EventHandler(this.lblND_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblProjectName.Location = new System.Drawing.Point(92, 68);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(95, 13);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "PROJECT NAME";
            this.lblProjectName.Click += new System.EventHandler(this.lblProjectName_Click);
            // 
            // lblDescp
            // 
            this.lblDescp.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDescp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDescp.Location = new System.Drawing.Point(92, 101);
            this.lblDescp.Name = "lblDescp";
            this.lblDescp.Size = new System.Drawing.Size(463, 106);
            this.lblDescp.TabIndex = 2;
            this.lblDescp.Text = "DESCRIPTION";
            this.lblDescp.Click += new System.EventHandler(this.lblDescp_Click);
            // 
            // lblPreviousUpdates
            // 
            this.lblPreviousUpdates.AutoSize = true;
            this.lblPreviousUpdates.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPreviousUpdates.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousUpdates.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPreviousUpdates.Location = new System.Drawing.Point(92, 222);
            this.lblPreviousUpdates.Name = "lblPreviousUpdates";
            this.lblPreviousUpdates.Size = new System.Drawing.Size(134, 13);
            this.lblPreviousUpdates.TabIndex = 3;
            this.lblPreviousUpdates.Text = "PREVIOUS UPDATES";
            this.lblPreviousUpdates.Click += new System.EventHandler(this.lblPreviousUpdates_Click);
            // 
            // txtPreviousUpdates
            // 
            this.txtPreviousUpdates.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPreviousUpdates.ForeColor = System.Drawing.Color.White;
            this.txtPreviousUpdates.Location = new System.Drawing.Point(96, 259);
            this.txtPreviousUpdates.Multiline = true;
            this.txtPreviousUpdates.Name = "txtPreviousUpdates";
            this.txtPreviousUpdates.Size = new System.Drawing.Size(459, 142);
            this.txtPreviousUpdates.TabIndex = 4;
            this.txtPreviousUpdates.TextChanged += new System.EventHandler(this.txtPreviousUpdates_TextChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(45, 300);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(43, 27);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(45, 333);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 29);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMoreInfoPrev
            // 
            this.btnMoreInfoPrev.Location = new System.Drawing.Point(45, 380);
            this.btnMoreInfoPrev.Name = "btnMoreInfoPrev";
            this.btnMoreInfoPrev.Size = new System.Drawing.Size(43, 24);
            this.btnMoreInfoPrev.TabIndex = 7;
            this.btnMoreInfoPrev.Text = "...";
            this.btnMoreInfoPrev.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(92, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADD A STATUS UPDATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewUpdate
            // 
            this.txtNewUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNewUpdate.ForeColor = System.Drawing.Color.White;
            this.txtNewUpdate.Location = new System.Drawing.Point(96, 461);
            this.txtNewUpdate.Multiline = true;
            this.txtNewUpdate.Name = "txtNewUpdate";
            this.txtNewUpdate.Size = new System.Drawing.Size(459, 142);
            this.txtNewUpdate.TabIndex = 9;
            this.txtNewUpdate.TextChanged += new System.EventHandler(this.txtNewUpdate_TextChanged);
            // 
            // btnMoreInfoNew
            // 
            this.btnMoreInfoNew.Location = new System.Drawing.Point(45, 579);
            this.btnMoreInfoNew.Name = "btnMoreInfoNew";
            this.btnMoreInfoNew.Size = new System.Drawing.Size(43, 24);
            this.btnMoreInfoNew.TabIndex = 10;
            this.btnMoreInfoNew.Text = "...";
            this.btnMoreInfoNew.UseVisualStyleBackColor = true;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.BackColor = System.Drawing.Color.SteelBlue;
            this.lblLastUpdated.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLastUpdated.Location = new System.Drawing.Point(96, 638);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(95, 13);
            this.lblLastUpdated.TabIndex = 11;
            this.lblLastUpdated.Text = "LAST UPDATED";
            this.lblLastUpdated.Click += new System.EventHandler(this.lblLastUpdated_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(99, 683);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(436, 23);
            this.btnUpdateStatus.TabIndex = 12;
            this.btnUpdateStatus.Text = "UPDATE CURRENT STATUS ";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTicketID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTicketID.Location = new System.Drawing.Point(419, 31);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(77, 13);
            this.lblTicketID.TabIndex = 13;
            this.lblTicketID.Text = "CI Ticket ID";
            // 
            // frmUpdateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(644, 744);
            this.Controls.Add(this.lblTicketID);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.btnMoreInfoNew);
            this.Controls.Add(this.txtNewUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoreInfoPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtPreviousUpdates);
            this.Controls.Add(this.lblPreviousUpdates);
            this.Controls.Add(this.lblDescp);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblND);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUpdateStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateStatus";
            this.Load += new System.EventHandler(this.frmUpdateStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblND;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDescp;
        private System.Windows.Forms.Label lblPreviousUpdates;
        private System.Windows.Forms.TextBox txtPreviousUpdates;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMoreInfoPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewUpdate;
        private System.Windows.Forms.Button btnMoreInfoNew;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblTicketID;
    }
}