namespace OrchardManagementApp
{
    partial class frmOrchardManagement
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.btnMainPageEditSections = new System.Windows.Forms.Button();
            this.pnlMainPageSections = new System.Windows.Forms.Panel();
            this.btnMainPageAddSection = new System.Windows.Forms.Button();
            this.btnMainPageChangeMap = new System.Windows.Forms.Button();
            this.picMainPageMap = new System.Windows.Forms.PictureBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnActionsBack = new System.Windows.Forms.Button();
            this.btnActionsAddAction = new System.Windows.Forms.Button();
            this.pnlActionContent = new System.Windows.Forms.Panel();
            this.lblpnlActionHeader = new System.Windows.Forms.Label();
            this.pnlHarvests = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHarvestsBack = new System.Windows.Forms.Button();
            this.btnHarvestsAddHarvests = new System.Windows.Forms.Button();
            this.pnlHarvestsContent = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPageMap)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.pnlHarvests.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.txtLoginUsername);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(500, 300);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(251, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(150, 160);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(200, 20);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(150, 135);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(200, 20);
            this.txtLoginUsername.TabIndex = 0;
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Controls.Add(this.btnMainPageEditSections);
            this.pnlMainPage.Controls.Add(this.pnlMainPageSections);
            this.pnlMainPage.Controls.Add(this.btnMainPageAddSection);
            this.pnlMainPage.Controls.Add(this.btnMainPageChangeMap);
            this.pnlMainPage.Controls.Add(this.picMainPageMap);
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Size = new System.Drawing.Size(784, 661);
            this.pnlMainPage.TabIndex = 1;
            // 
            // btnMainPageEditSections
            // 
            this.btnMainPageEditSections.Location = new System.Drawing.Point(651, 336);
            this.btnMainPageEditSections.Name = "btnMainPageEditSections";
            this.btnMainPageEditSections.Size = new System.Drawing.Size(116, 23);
            this.btnMainPageEditSections.TabIndex = 4;
            this.btnMainPageEditSections.Text = "Edit Sections";
            this.btnMainPageEditSections.UseVisualStyleBackColor = true;
            this.btnMainPageEditSections.Click += new System.EventHandler(this.btnMainPageEditSections_Click);
            // 
            // pnlMainPageSections
            // 
            this.pnlMainPageSections.AutoScroll = true;
            this.pnlMainPageSections.Location = new System.Drawing.Point(12, 365);
            this.pnlMainPageSections.Name = "pnlMainPageSections";
            this.pnlMainPageSections.Size = new System.Drawing.Size(760, 284);
            this.pnlMainPageSections.TabIndex = 3;
            // 
            // btnMainPageAddSection
            // 
            this.btnMainPageAddSection.Location = new System.Drawing.Point(434, 336);
            this.btnMainPageAddSection.Name = "btnMainPageAddSection";
            this.btnMainPageAddSection.Size = new System.Drawing.Size(99, 23);
            this.btnMainPageAddSection.TabIndex = 2;
            this.btnMainPageAddSection.Text = "Add Section";
            this.btnMainPageAddSection.UseVisualStyleBackColor = true;
            this.btnMainPageAddSection.Click += new System.EventHandler(this.btnMainPageAddSection_Click);
            // 
            // btnMainPageChangeMap
            // 
            this.btnMainPageChangeMap.Location = new System.Drawing.Point(539, 336);
            this.btnMainPageChangeMap.Name = "btnMainPageChangeMap";
            this.btnMainPageChangeMap.Size = new System.Drawing.Size(106, 23);
            this.btnMainPageChangeMap.TabIndex = 1;
            this.btnMainPageChangeMap.Text = "Change Map";
            this.btnMainPageChangeMap.UseVisualStyleBackColor = true;
            this.btnMainPageChangeMap.Click += new System.EventHandler(this.btnMainPageChangeMap_Click);
            // 
            // picMainPageMap
            // 
            this.picMainPageMap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picMainPageMap.Location = new System.Drawing.Point(0, 0);
            this.picMainPageMap.Name = "picMainPageMap";
            this.picMainPageMap.Size = new System.Drawing.Size(784, 330);
            this.picMainPageMap.TabIndex = 0;
            this.picMainPageMap.TabStop = false;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnActionsBack);
            this.pnlActions.Controls.Add(this.btnActionsAddAction);
            this.pnlActions.Controls.Add(this.pnlActionContent);
            this.pnlActions.Controls.Add(this.lblpnlActionHeader);
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(784, 661);
            this.pnlActions.TabIndex = 2;
            // 
            // btnActionsBack
            // 
            this.btnActionsBack.Location = new System.Drawing.Point(651, 631);
            this.btnActionsBack.Name = "btnActionsBack";
            this.btnActionsBack.Size = new System.Drawing.Size(116, 23);
            this.btnActionsBack.TabIndex = 3;
            this.btnActionsBack.Text = "Back";
            this.btnActionsBack.UseVisualStyleBackColor = true;
            this.btnActionsBack.Click += new System.EventHandler(this.btnActionsBack_Click);
            // 
            // btnActionsAddAction
            // 
            this.btnActionsAddAction.Location = new System.Drawing.Point(676, 12);
            this.btnActionsAddAction.Name = "btnActionsAddAction";
            this.btnActionsAddAction.Size = new System.Drawing.Size(91, 23);
            this.btnActionsAddAction.TabIndex = 2;
            this.btnActionsAddAction.Text = "Add Action";
            this.btnActionsAddAction.UseVisualStyleBackColor = true;
            this.btnActionsAddAction.Click += new System.EventHandler(this.btnActionsAddAction_Click);
            // 
            // pnlActionContent
            // 
            this.pnlActionContent.Location = new System.Drawing.Point(12, 63);
            this.pnlActionContent.Name = "pnlActionContent";
            this.pnlActionContent.Size = new System.Drawing.Size(760, 562);
            this.pnlActionContent.TabIndex = 1;
            // 
            // lblpnlActionHeader
            // 
            this.lblpnlActionHeader.AutoSize = true;
            this.lblpnlActionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpnlActionHeader.Location = new System.Drawing.Point(38, 23);
            this.lblpnlActionHeader.Name = "lblpnlActionHeader";
            this.lblpnlActionHeader.Size = new System.Drawing.Size(130, 37);
            this.lblpnlActionHeader.TabIndex = 0;
            this.lblpnlActionHeader.Text = "Actions";
            // 
            // pnlHarvests
            // 
            this.pnlHarvests.Controls.Add(this.label1);
            this.pnlHarvests.Controls.Add(this.btnHarvestsBack);
            this.pnlHarvests.Controls.Add(this.btnHarvestsAddHarvests);
            this.pnlHarvests.Controls.Add(this.pnlHarvestsContent);
            this.pnlHarvests.Location = new System.Drawing.Point(0, 0);
            this.pnlHarvests.Name = "pnlHarvests";
            this.pnlHarvests.Size = new System.Drawing.Size(784, 661);
            this.pnlHarvests.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Harvests";
            // 
            // btnHarvestsBack
            // 
            this.btnHarvestsBack.Location = new System.Drawing.Point(651, 631);
            this.btnHarvestsBack.Name = "btnHarvestsBack";
            this.btnHarvestsBack.Size = new System.Drawing.Size(116, 23);
            this.btnHarvestsBack.TabIndex = 3;
            this.btnHarvestsBack.Text = "Back";
            this.btnHarvestsBack.UseVisualStyleBackColor = true;
            this.btnHarvestsBack.Click += new System.EventHandler(this.btnHarvestsBack_Click);
            // 
            // btnHarvestsAddHarvests
            // 
            this.btnHarvestsAddHarvests.Location = new System.Drawing.Point(676, 12);
            this.btnHarvestsAddHarvests.Name = "btnHarvestsAddHarvests";
            this.btnHarvestsAddHarvests.Size = new System.Drawing.Size(91, 23);
            this.btnHarvestsAddHarvests.TabIndex = 2;
            this.btnHarvestsAddHarvests.Text = "Add Harvests";
            this.btnHarvestsAddHarvests.UseVisualStyleBackColor = true;
            this.btnHarvestsAddHarvests.Click += new System.EventHandler(this.btnHarvestsAddHarvests_Click);
            // 
            // pnlHarvestsContent
            // 
            this.pnlHarvestsContent.Location = new System.Drawing.Point(12, 63);
            this.pnlHarvestsContent.Name = "pnlHarvestsContent";
            this.pnlHarvestsContent.Size = new System.Drawing.Size(760, 562);
            this.pnlHarvestsContent.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(155, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 24);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // frmOrchardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.pnlHarvests);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlMainPage);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmOrchardManagement";
            this.Text = "Orchard Management";
            this.Activated += new System.EventHandler(this.MainPage_Activated);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMainPageMap)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlHarvests.ResumeLayout(false);
            this.pnlHarvests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.Panel pnlMainPageSections;
        private System.Windows.Forms.Button btnMainPageAddSection;
        private System.Windows.Forms.Button btnMainPageChangeMap;
        private System.Windows.Forms.PictureBox picMainPageMap;
        private System.Windows.Forms.Button btnMainPageEditSections;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlActionContent;
        private System.Windows.Forms.Label lblpnlActionHeader;
        private System.Windows.Forms.Button btnActionsAddAction;
        private System.Windows.Forms.Button btnActionsBack;
        private System.Windows.Forms.Panel pnlHarvests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHarvestsBack;
        private System.Windows.Forms.Button btnHarvestsAddHarvests;
        private System.Windows.Forms.Panel pnlHarvestsContent;
        private System.Windows.Forms.Label lblLogin;
    }
}

