namespace mouse_click_simulator
{
    partial class VersionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionForm));
            tabControlInfo = new System.Windows.Forms.TabControl();
            tabPageVersion = new System.Windows.Forms.TabPage();
            gbGit = new System.Windows.Forms.GroupBox();
            lblDescriptionData = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblDateData = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblCommitData = new System.Windows.Forms.Label();
            lblCommit = new System.Windows.Forms.Label();
            gbProgram = new System.Windows.Forms.GroupBox();
            lblLicense = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            lblVersionData = new System.Windows.Forms.Label();
            gbRuntimeInformation = new System.Windows.Forms.GroupBox();
            lblDotNet = new System.Windows.Forms.Label();
            lblArchitectureData = new System.Windows.Forms.Label();
            lblDotNetData = new System.Windows.Forms.Label();
            lblOperatingSystemData = new System.Windows.Forms.Label();
            lblOperatingSystem = new System.Windows.Forms.Label();
            lblArchitecture = new System.Windows.Forms.Label();
            tabPageThirdParty = new System.Windows.Forms.TabPage();
            rtbLicenses = new System.Windows.Forms.RichTextBox();
            lblThirdPartyIntro = new System.Windows.Forms.Label();
            tabControlInfo.SuspendLayout();
            tabPageVersion.SuspendLayout();
            gbGit.SuspendLayout();
            gbProgram.SuspendLayout();
            gbRuntimeInformation.SuspendLayout();
            tabPageThirdParty.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlInfo
            // 
            tabControlInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControlInfo.Controls.Add(tabPageVersion);
            tabControlInfo.Controls.Add(tabPageThirdParty);
            tabControlInfo.Location = new System.Drawing.Point(12, 12);
            tabControlInfo.Name = "tabControlInfo";
            tabControlInfo.SelectedIndex = 0;
            tabControlInfo.Size = new System.Drawing.Size(776, 426);
            tabControlInfo.TabIndex = 0;
            // 
            // tabPageVersion
            // 
            tabPageVersion.Controls.Add(gbGit);
            tabPageVersion.Controls.Add(gbProgram);
            tabPageVersion.Controls.Add(gbRuntimeInformation);
            tabPageVersion.Location = new System.Drawing.Point(4, 24);
            tabPageVersion.Name = "tabPageVersion";
            tabPageVersion.Padding = new System.Windows.Forms.Padding(3);
            tabPageVersion.Size = new System.Drawing.Size(768, 398);
            tabPageVersion.TabIndex = 0;
            tabPageVersion.Text = "Version";
            tabPageVersion.UseVisualStyleBackColor = true;
            // 
            // gbGit
            // 
            gbGit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbGit.Controls.Add(lblDescriptionData);
            gbGit.Controls.Add(lblDescription);
            gbGit.Controls.Add(lblDateData);
            gbGit.Controls.Add(lblDate);
            gbGit.Controls.Add(lblCommitData);
            gbGit.Controls.Add(lblCommit);
            gbGit.Location = new System.Drawing.Point(6, 132);
            gbGit.Name = "gbGit";
            gbGit.Size = new System.Drawing.Size(756, 112);
            gbGit.TabIndex = 11;
            gbGit.TabStop = false;
            gbGit.Text = "Git information:";
            // 
            // lblDescriptionData
            // 
            lblDescriptionData.AutoSize = true;
            lblDescriptionData.Location = new System.Drawing.Point(101, 79);
            lblDescriptionData.Name = "lblDescriptionData";
            lblDescriptionData.Size = new System.Drawing.Size(57, 15);
            lblDescriptionData.TabIndex = 5;
            lblDescriptionData.Text = "unknown";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(6, 79);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(70, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // lblDateData
            // 
            lblDateData.AutoSize = true;
            lblDateData.Location = new System.Drawing.Point(101, 49);
            lblDateData.Name = "lblDateData";
            lblDateData.Size = new System.Drawing.Size(57, 15);
            lblDateData.TabIndex = 3;
            lblDateData.Text = "unknown";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(6, 49);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(34, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // lblCommitData
            // 
            lblCommitData.AutoSize = true;
            lblCommitData.Location = new System.Drawing.Point(101, 19);
            lblCommitData.Name = "lblCommitData";
            lblCommitData.Size = new System.Drawing.Size(57, 15);
            lblCommitData.TabIndex = 1;
            lblCommitData.Text = "unknown";
            // 
            // lblCommit
            // 
            lblCommit.AutoSize = true;
            lblCommit.Location = new System.Drawing.Point(6, 19);
            lblCommit.Name = "lblCommit";
            lblCommit.Size = new System.Drawing.Size(54, 15);
            lblCommit.TabIndex = 0;
            lblCommit.Text = "Commit:";
            // 
            // gbProgram
            // 
            gbProgram.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbProgram.Controls.Add(lblLicense);
            gbProgram.Controls.Add(lblTitle);
            gbProgram.Controls.Add(lblVersion);
            gbProgram.Controls.Add(lblVersionData);
            gbProgram.Location = new System.Drawing.Point(6, 6);
            gbProgram.Name = "gbProgram";
            gbProgram.Size = new System.Drawing.Size(756, 120);
            gbProgram.TabIndex = 10;
            gbProgram.TabStop = false;
            gbProgram.Text = "Program information:";
            // 
            // lblLicense
            // 
            lblLicense.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLicense.Location = new System.Drawing.Point(231, 19);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new System.Drawing.Size(519, 98);
            lblLicense.TabIndex = 3;
            lblLicense.Text = resources.GetString("lblLicense.Text");
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(6, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(126, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mouse Click Simulator";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(6, 49);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(48, 15);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version:";
            // 
            // lblVersionData
            // 
            lblVersionData.AutoSize = true;
            lblVersionData.Location = new System.Drawing.Point(72, 49);
            lblVersionData.Name = "lblVersionData";
            lblVersionData.Size = new System.Drawing.Size(57, 15);
            lblVersionData.TabIndex = 2;
            lblVersionData.Text = "unknown";
            // 
            // gbRuntimeInformation
            // 
            gbRuntimeInformation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbRuntimeInformation.Controls.Add(lblDotNet);
            gbRuntimeInformation.Controls.Add(lblArchitectureData);
            gbRuntimeInformation.Controls.Add(lblDotNetData);
            gbRuntimeInformation.Controls.Add(lblOperatingSystemData);
            gbRuntimeInformation.Controls.Add(lblOperatingSystem);
            gbRuntimeInformation.Controls.Add(lblArchitecture);
            gbRuntimeInformation.Location = new System.Drawing.Point(6, 250);
            gbRuntimeInformation.Name = "gbRuntimeInformation";
            gbRuntimeInformation.Size = new System.Drawing.Size(756, 108);
            gbRuntimeInformation.TabIndex = 9;
            gbRuntimeInformation.TabStop = false;
            gbRuntimeInformation.Text = "Runtime information:";
            // 
            // lblDotNet
            // 
            lblDotNet.AutoSize = true;
            lblDotNet.Location = new System.Drawing.Point(6, 19);
            lblDotNet.Name = "lblDotNet";
            lblDotNet.Size = new System.Drawing.Size(34, 15);
            lblDotNet.TabIndex = 3;
            lblDotNet.Text = ".NET:";
            // 
            // lblArchitectureData
            // 
            lblArchitectureData.AutoSize = true;
            lblArchitectureData.Location = new System.Drawing.Point(101, 79);
            lblArchitectureData.Name = "lblArchitectureData";
            lblArchitectureData.Size = new System.Drawing.Size(57, 15);
            lblArchitectureData.TabIndex = 8;
            lblArchitectureData.Text = "unknown";
            // 
            // lblDotNetData
            // 
            lblDotNetData.AutoSize = true;
            lblDotNetData.Location = new System.Drawing.Point(101, 19);
            lblDotNetData.Name = "lblDotNetData";
            lblDotNetData.Size = new System.Drawing.Size(57, 15);
            lblDotNetData.TabIndex = 4;
            lblDotNetData.Text = "unknown";
            // 
            // lblOperatingSystemData
            // 
            lblOperatingSystemData.AutoSize = true;
            lblOperatingSystemData.Location = new System.Drawing.Point(101, 49);
            lblOperatingSystemData.Name = "lblOperatingSystemData";
            lblOperatingSystemData.Size = new System.Drawing.Size(57, 15);
            lblOperatingSystemData.TabIndex = 7;
            lblOperatingSystemData.Text = "unknown";
            // 
            // lblOperatingSystem
            // 
            lblOperatingSystem.AutoSize = true;
            lblOperatingSystem.Location = new System.Drawing.Point(6, 49);
            lblOperatingSystem.Name = "lblOperatingSystem";
            lblOperatingSystem.Size = new System.Drawing.Size(25, 15);
            lblOperatingSystem.TabIndex = 5;
            lblOperatingSystem.Text = "OS:";
            // 
            // lblArchitecture
            // 
            lblArchitecture.AutoSize = true;
            lblArchitecture.Location = new System.Drawing.Point(6, 79);
            lblArchitecture.Name = "lblArchitecture";
            lblArchitecture.Size = new System.Drawing.Size(75, 15);
            lblArchitecture.TabIndex = 6;
            lblArchitecture.Text = "Architecture:";
            // 
            // tabPageThirdParty
            // 
            tabPageThirdParty.Controls.Add(rtbLicenses);
            tabPageThirdParty.Controls.Add(lblThirdPartyIntro);
            tabPageThirdParty.Location = new System.Drawing.Point(4, 24);
            tabPageThirdParty.Name = "tabPageThirdParty";
            tabPageThirdParty.Padding = new System.Windows.Forms.Padding(3);
            tabPageThirdParty.Size = new System.Drawing.Size(768, 398);
            tabPageThirdParty.TabIndex = 1;
            tabPageThirdParty.Text = "Third party components";
            tabPageThirdParty.UseVisualStyleBackColor = true;
            // 
            // rtbLicenses
            // 
            rtbLicenses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtbLicenses.Location = new System.Drawing.Point(6, 40);
            rtbLicenses.Name = "rtbLicenses";
            rtbLicenses.ReadOnly = true;
            rtbLicenses.Size = new System.Drawing.Size(756, 352);
            rtbLicenses.TabIndex = 1;
            rtbLicenses.Text = "";
            // 
            // lblThirdPartyIntro
            // 
            lblThirdPartyIntro.AutoSize = true;
            lblThirdPartyIntro.Location = new System.Drawing.Point(6, 3);
            lblThirdPartyIntro.Name = "lblThirdPartyIntro";
            lblThirdPartyIntro.Size = new System.Drawing.Size(427, 15);
            lblThirdPartyIntro.TabIndex = 0;
            lblThirdPartyIntro.Text = "This program uses some third party components. Their licenses are listed below.";
            // 
            // VersionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControlInfo);
            MinimumSize = new System.Drawing.Size(480, 280);
            Name = "VersionForm";
            Text = "Version information";
            Load += VersionForm_Load;
            tabControlInfo.ResumeLayout(false);
            tabPageVersion.ResumeLayout(false);
            gbGit.ResumeLayout(false);
            gbGit.PerformLayout();
            gbProgram.ResumeLayout(false);
            gbProgram.PerformLayout();
            gbRuntimeInformation.ResumeLayout(false);
            gbRuntimeInformation.PerformLayout();
            tabPageThirdParty.ResumeLayout(false);
            tabPageThirdParty.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageVersion;
        private System.Windows.Forms.TabPage tabPageThirdParty;
        private System.Windows.Forms.Label lblVersionData;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbLicenses;
        private System.Windows.Forms.Label lblThirdPartyIntro;
        private System.Windows.Forms.Label lblOperatingSystemData;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.Label lblDotNetData;
        private System.Windows.Forms.Label lblDotNet;
        private System.Windows.Forms.Label lblArchitectureData;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.GroupBox gbRuntimeInformation;
        private System.Windows.Forms.GroupBox gbGit;
        private System.Windows.Forms.Label lblDescriptionData;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateData;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCommitData;
        private System.Windows.Forms.Label lblCommit;
        private System.Windows.Forms.Label lblLicense;
    }
}