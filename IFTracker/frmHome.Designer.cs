namespace IFTracker
{
    partial class frmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbHome = new System.Windows.Forms.TabControl();
            this.tbNewDemands = new System.Windows.Forms.TabPage();
            this.btnExportND = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewCompleteStory = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAddND = new System.Windows.Forms.Button();
            this.grpNewDemands = new System.Windows.Forms.GroupBox();
            this.dgNewDemand = new System.Windows.Forms.DataGridView();
            this.tbCatalogue = new System.Windows.Forms.TabPage();
            this.btnExportNDData = new System.Windows.Forms.Button();
            this.brnRefreshCI = new System.Windows.Forms.Button();
            this.btnEmailCI = new System.Windows.Forms.Button();
            this.btnUpdateCI = new System.Windows.Forms.Button();
            this.grpCI = new System.Windows.Forms.GroupBox();
            this.dgCI = new System.Windows.Forms.DataGridView();
            this.btnModifyCI = new System.Windows.Forms.Button();
            this.btnAddCI = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.tbHome.SuspendLayout();
            this.tbNewDemands.SuspendLayout();
            this.grpNewDemands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewDemand)).BeginInit();
            this.tbCatalogue.SuspendLayout();
            this.grpCI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHome
            // 
            this.tbHome.Controls.Add(this.tbNewDemands);
            this.tbHome.Controls.Add(this.tbCatalogue);
            this.tbHome.Location = new System.Drawing.Point(13, 25);
            this.tbHome.Margin = new System.Windows.Forms.Padding(4);
            this.tbHome.Name = "tbHome";
            this.tbHome.SelectedIndex = 0;
            this.tbHome.Size = new System.Drawing.Size(1009, 349);
            this.tbHome.TabIndex = 0;
            // 
            // tbNewDemands
            // 
            this.tbNewDemands.BackColor = System.Drawing.Color.SkyBlue;
            this.tbNewDemands.Controls.Add(this.btnExportND);
            this.tbNewDemands.Controls.Add(this.btnRefresh);
            this.tbNewDemands.Controls.Add(this.btnViewCompleteStory);
            this.tbNewDemands.Controls.Add(this.btnSendEmail);
            this.tbNewDemands.Controls.Add(this.btnUpdateStatus);
            this.tbNewDemands.Controls.Add(this.btnModify);
            this.tbNewDemands.Controls.Add(this.btnAddND);
            this.tbNewDemands.Controls.Add(this.grpNewDemands);
            this.tbNewDemands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewDemands.Location = new System.Drawing.Point(4, 23);
            this.tbNewDemands.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewDemands.Name = "tbNewDemands";
            this.tbNewDemands.Padding = new System.Windows.Forms.Padding(4);
            this.tbNewDemands.Size = new System.Drawing.Size(1001, 322);
            this.tbNewDemands.TabIndex = 0;
            this.tbNewDemands.Text = "NEW DEMANDS";
            // 
            // btnExportND
            // 
            this.btnExportND.Location = new System.Drawing.Point(99, 67);
            this.btnExportND.Name = "btnExportND";
            this.btnExportND.Size = new System.Drawing.Size(249, 23);
            this.btnExportND.TabIndex = 16;
            this.btnExportND.Text = "EXPORT ND INFORMATION TO EXCEL";
            this.btnExportND.UseVisualStyleBackColor = true;
            this.btnExportND.Click += new System.EventHandler(this.btnExportND_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewCompleteStory
            // 
            this.btnViewCompleteStory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCompleteStory.Location = new System.Drawing.Point(625, 28);
            this.btnViewCompleteStory.Name = "btnViewCompleteStory";
            this.btnViewCompleteStory.Size = new System.Drawing.Size(187, 23);
            this.btnViewCompleteStory.TabIndex = 5;
            this.btnViewCompleteStory.Text = "EMAIL COMPLETE STORY ";
            this.btnViewCompleteStory.UseVisualStyleBackColor = true;
            this.btnViewCompleteStory.Click += new System.EventHandler(this.btnViewCompleteStory_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(844, 67);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(131, 23);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "SEND EMAIL";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Visible = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(396, 28);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(223, 23);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "UPDATE CURRENT STATUS";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(214, 28);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(168, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAddND
            // 
            this.btnAddND.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddND.FlatAppearance.BorderSize = 3;
            this.btnAddND.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddND.Location = new System.Drawing.Point(18, 28);
            this.btnAddND.Name = "btnAddND";
            this.btnAddND.Size = new System.Drawing.Size(180, 22);
            this.btnAddND.TabIndex = 1;
            this.btnAddND.Text = "REGISTER  A NEW DEMAND";
            this.btnAddND.UseVisualStyleBackColor = true;
            this.btnAddND.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpNewDemands
            // 
            this.grpNewDemands.Controls.Add(this.dgNewDemand);
            this.grpNewDemands.Location = new System.Drawing.Point(18, 96);
            this.grpNewDemands.Name = "grpNewDemands";
            this.grpNewDemands.Size = new System.Drawing.Size(957, 187);
            this.grpNewDemands.TabIndex = 0;
            this.grpNewDemands.TabStop = false;
            this.grpNewDemands.Text = "NEW DEMANDS";
            // 
            // dgNewDemand
            // 
            this.dgNewDemand.AllowUserToAddRows = false;
            this.dgNewDemand.AllowUserToDeleteRows = false;
            this.dgNewDemand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgNewDemand.BackgroundColor = System.Drawing.Color.White;
            this.dgNewDemand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNewDemand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgNewDemand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNewDemand.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgNewDemand.Location = new System.Drawing.Point(15, 20);
            this.dgNewDemand.Name = "dgNewDemand";
            this.dgNewDemand.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNewDemand.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgNewDemand.RowHeadersVisible = false;
            this.dgNewDemand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgNewDemand.Size = new System.Drawing.Size(240, 150);
            this.dgNewDemand.TabIndex = 0;
            this.dgNewDemand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNewDemand_CellClick);
            // 
            // tbCatalogue
            // 
            this.tbCatalogue.BackColor = System.Drawing.Color.SkyBlue;
            this.tbCatalogue.Controls.Add(this.btnExportNDData);
            this.tbCatalogue.Controls.Add(this.brnRefreshCI);
            this.tbCatalogue.Controls.Add(this.btnEmailCI);
            this.tbCatalogue.Controls.Add(this.btnUpdateCI);
            this.tbCatalogue.Controls.Add(this.grpCI);
            this.tbCatalogue.Controls.Add(this.btnModifyCI);
            this.tbCatalogue.Controls.Add(this.btnAddCI);
            this.tbCatalogue.Location = new System.Drawing.Point(4, 23);
            this.tbCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.tbCatalogue.Name = "tbCatalogue";
            this.tbCatalogue.Padding = new System.Windows.Forms.Padding(4);
            this.tbCatalogue.Size = new System.Drawing.Size(1001, 322);
            this.tbCatalogue.TabIndex = 1;
            this.tbCatalogue.Text = "CATALOGUES ITEMS";
            // 
            // btnExportNDData
            // 
            this.btnExportNDData.Location = new System.Drawing.Point(104, 71);
            this.btnExportNDData.Name = "btnExportNDData";
            this.btnExportNDData.Size = new System.Drawing.Size(257, 23);
            this.btnExportNDData.TabIndex = 15;
            this.btnExportNDData.Text = "EXPORT CI INFORMATION TO EXCEL";
            this.btnExportNDData.UseVisualStyleBackColor = true;
            this.btnExportNDData.Click += new System.EventHandler(this.btnExportNDData_Click);
            // 
            // brnRefreshCI
            // 
            this.brnRefreshCI.Location = new System.Drawing.Point(22, 72);
            this.brnRefreshCI.Name = "brnRefreshCI";
            this.brnRefreshCI.Size = new System.Drawing.Size(75, 23);
            this.brnRefreshCI.TabIndex = 14;
            this.brnRefreshCI.Text = "REFRESH";
            this.brnRefreshCI.UseVisualStyleBackColor = true;
            this.brnRefreshCI.Click += new System.EventHandler(this.brnRefreshCI_Click);
            // 
            // btnEmailCI
            // 
            this.btnEmailCI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailCI.Location = new System.Drawing.Point(629, 34);
            this.btnEmailCI.Name = "btnEmailCI";
            this.btnEmailCI.Size = new System.Drawing.Size(187, 23);
            this.btnEmailCI.TabIndex = 12;
            this.btnEmailCI.Text = "EMAIL COMPLETE STORY ";
            this.btnEmailCI.UseVisualStyleBackColor = true;
            this.btnEmailCI.Click += new System.EventHandler(this.btnEmailCI_Click);
            // 
            // btnUpdateCI
            // 
            this.btnUpdateCI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCI.Location = new System.Drawing.Point(400, 34);
            this.btnUpdateCI.Name = "btnUpdateCI";
            this.btnUpdateCI.Size = new System.Drawing.Size(223, 23);
            this.btnUpdateCI.TabIndex = 10;
            this.btnUpdateCI.Text = "UPDATE CURRENT STATUS";
            this.btnUpdateCI.UseVisualStyleBackColor = true;
            this.btnUpdateCI.Click += new System.EventHandler(this.btnUpdateCI_Click);
            // 
            // grpCI
            // 
            this.grpCI.Controls.Add(this.dgCI);
            this.grpCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCI.Location = new System.Drawing.Point(22, 102);
            this.grpCI.Name = "grpCI";
            this.grpCI.Size = new System.Drawing.Size(957, 187);
            this.grpCI.TabIndex = 7;
            this.grpCI.TabStop = false;
            this.grpCI.Text = "NEW DEMANDS";
            // 
            // dgCI
            // 
            this.dgCI.AllowUserToAddRows = false;
            this.dgCI.AllowUserToDeleteRows = false;
            this.dgCI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgCI.BackgroundColor = System.Drawing.Color.White;
            this.dgCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCI.Location = new System.Drawing.Point(15, 20);
            this.dgCI.Name = "dgCI";
            this.dgCI.ReadOnly = true;
            this.dgCI.RowHeadersVisible = false;
            this.dgCI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgCI.Size = new System.Drawing.Size(240, 150);
            this.dgCI.TabIndex = 0;
            this.dgCI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCI_CellClick);
            // 
            // btnModifyCI
            // 
            this.btnModifyCI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCI.Location = new System.Drawing.Point(218, 34);
            this.btnModifyCI.Name = "btnModifyCI";
            this.btnModifyCI.Size = new System.Drawing.Size(168, 23);
            this.btnModifyCI.TabIndex = 9;
            this.btnModifyCI.Text = "MODIFY";
            this.btnModifyCI.UseVisualStyleBackColor = true;
            this.btnModifyCI.Click += new System.EventHandler(this.btnModifyCI_Click);
            // 
            // btnAddCI
            // 
            this.btnAddCI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCI.Location = new System.Drawing.Point(22, 34);
            this.btnAddCI.Name = "btnAddCI";
            this.btnAddCI.Size = new System.Drawing.Size(180, 22);
            this.btnAddCI.TabIndex = 8;
            this.btnAddCI.Text = "ADD A NEW CI";
            this.btnAddCI.UseVisualStyleBackColor = true;
            this.btnAddCI.Click += new System.EventHandler(this.btnAddCI_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(15, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1276, 687);
            this.Controls.Add(this.tbHome);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "INFLIGHT DEMAND TRACKER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.tbHome.ResumeLayout(false);
            this.tbNewDemands.ResumeLayout(false);
            this.grpNewDemands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNewDemand)).EndInit();
            this.tbCatalogue.ResumeLayout(false);
            this.grpCI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbHome;
        private System.Windows.Forms.TabPage tbNewDemands;
        private System.Windows.Forms.TabPage tbCatalogue;
        private System.Windows.Forms.GroupBox grpNewDemands;
        private System.Windows.Forms.DataGridView dgNewDemand;
        private System.Windows.Forms.Button btnAddND;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnViewCompleteStory;
        private System.Windows.Forms.Button btnEmailCI;
        private System.Windows.Forms.Button btnUpdateCI;
        private System.Windows.Forms.GroupBox grpCI;
        private System.Windows.Forms.DataGridView dgCI;
        private System.Windows.Forms.Button btnModifyCI;
        private System.Windows.Forms.Button btnAddCI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button brnRefreshCI;
        private System.Windows.Forms.Button btnExportNDData;
        private System.Windows.Forms.Button btnExportND;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}