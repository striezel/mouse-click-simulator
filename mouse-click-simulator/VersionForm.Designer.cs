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
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageVersion = new System.Windows.Forms.TabPage();
            this.gbGit = new System.Windows.Forms.GroupBox();
            this.lblDescriptionData = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDateData = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCommitData = new System.Windows.Forms.Label();
            this.lblCommit = new System.Windows.Forms.Label();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionData = new System.Windows.Forms.Label();
            this.gbRuntimeInformation = new System.Windows.Forms.GroupBox();
            this.lblDotNet = new System.Windows.Forms.Label();
            this.lblArchitectureData = new System.Windows.Forms.Label();
            this.lblDotNetData = new System.Windows.Forms.Label();
            this.lblOperatingSystemData = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.tabPageThirdParty = new System.Windows.Forms.TabPage();
            this.rtbLicenses = new System.Windows.Forms.RichTextBox();
            this.lblThirdPartyIntro = new System.Windows.Forms.Label();
            this.tabControlInfo.SuspendLayout();
            this.tabPageVersion.SuspendLayout();
            this.gbGit.SuspendLayout();
            this.gbProgram.SuspendLayout();
            this.gbRuntimeInformation.SuspendLayout();
            this.tabPageThirdParty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlInfo.Controls.Add(this.tabPageVersion);
            this.tabControlInfo.Controls.Add(this.tabPageThirdParty);
            this.tabControlInfo.Location = new System.Drawing.Point(12, 12);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(776, 426);
            this.tabControlInfo.TabIndex = 0;
            // 
            // tabPageVersion
            // 
            this.tabPageVersion.Controls.Add(this.gbGit);
            this.tabPageVersion.Controls.Add(this.gbProgram);
            this.tabPageVersion.Controls.Add(this.gbRuntimeInformation);
            this.tabPageVersion.Location = new System.Drawing.Point(4, 24);
            this.tabPageVersion.Name = "tabPageVersion";
            this.tabPageVersion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVersion.Size = new System.Drawing.Size(768, 398);
            this.tabPageVersion.TabIndex = 0;
            this.tabPageVersion.Text = "Version";
            this.tabPageVersion.UseVisualStyleBackColor = true;
            // 
            // gbGit
            // 
            this.gbGit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGit.Controls.Add(this.lblDescriptionData);
            this.gbGit.Controls.Add(this.lblDescription);
            this.gbGit.Controls.Add(this.lblDateData);
            this.gbGit.Controls.Add(this.lblDate);
            this.gbGit.Controls.Add(this.lblCommitData);
            this.gbGit.Controls.Add(this.lblCommit);
            this.gbGit.Location = new System.Drawing.Point(6, 99);
            this.gbGit.Name = "gbGit";
            this.gbGit.Size = new System.Drawing.Size(756, 112);
            this.gbGit.TabIndex = 11;
            this.gbGit.TabStop = false;
            this.gbGit.Text = "Git information:";
            // 
            // lblDescriptionData
            // 
            this.lblDescriptionData.AutoSize = true;
            this.lblDescriptionData.Location = new System.Drawing.Point(101, 79);
            this.lblDescriptionData.Name = "lblDescriptionData";
            this.lblDescriptionData.Size = new System.Drawing.Size(57, 15);
            this.lblDescriptionData.TabIndex = 5;
            this.lblDescriptionData.Text = "unknown";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // lblDateData
            // 
            this.lblDateData.AutoSize = true;
            this.lblDateData.Location = new System.Drawing.Point(101, 49);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(57, 15);
            this.lblDateData.TabIndex = 3;
            this.lblDateData.Text = "unknown";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblCommitData
            // 
            this.lblCommitData.AutoSize = true;
            this.lblCommitData.Location = new System.Drawing.Point(101, 19);
            this.lblCommitData.Name = "lblCommitData";
            this.lblCommitData.Size = new System.Drawing.Size(57, 15);
            this.lblCommitData.TabIndex = 1;
            this.lblCommitData.Text = "unknown";
            // 
            // lblCommit
            // 
            this.lblCommit.AutoSize = true;
            this.lblCommit.Location = new System.Drawing.Point(6, 19);
            this.lblCommit.Name = "lblCommit";
            this.lblCommit.Size = new System.Drawing.Size(54, 15);
            this.lblCommit.TabIndex = 0;
            this.lblCommit.Text = "Commit:";
            // 
            // gbProgram
            // 
            this.gbProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProgram.Controls.Add(this.lblTitle);
            this.gbProgram.Controls.Add(this.lblVersion);
            this.gbProgram.Controls.Add(this.lblVersionData);
            this.gbProgram.Location = new System.Drawing.Point(6, 6);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(756, 87);
            this.gbProgram.TabIndex = 10;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program information:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mouse Click Simulator";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(6, 49);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version:";
            // 
            // lblVersionData
            // 
            this.lblVersionData.AutoSize = true;
            this.lblVersionData.Location = new System.Drawing.Point(72, 49);
            this.lblVersionData.Name = "lblVersionData";
            this.lblVersionData.Size = new System.Drawing.Size(57, 15);
            this.lblVersionData.TabIndex = 2;
            this.lblVersionData.Text = "unknown";
            // 
            // gbRuntimeInformation
            // 
            this.gbRuntimeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRuntimeInformation.Controls.Add(this.lblDotNet);
            this.gbRuntimeInformation.Controls.Add(this.lblArchitectureData);
            this.gbRuntimeInformation.Controls.Add(this.lblDotNetData);
            this.gbRuntimeInformation.Controls.Add(this.lblOperatingSystemData);
            this.gbRuntimeInformation.Controls.Add(this.lblOperatingSystem);
            this.gbRuntimeInformation.Controls.Add(this.lblArchitecture);
            this.gbRuntimeInformation.Location = new System.Drawing.Point(6, 217);
            this.gbRuntimeInformation.Name = "gbRuntimeInformation";
            this.gbRuntimeInformation.Size = new System.Drawing.Size(756, 108);
            this.gbRuntimeInformation.TabIndex = 9;
            this.gbRuntimeInformation.TabStop = false;
            this.gbRuntimeInformation.Text = "Runtime information:";
            // 
            // lblDotNet
            // 
            this.lblDotNet.AutoSize = true;
            this.lblDotNet.Location = new System.Drawing.Point(6, 19);
            this.lblDotNet.Name = "lblDotNet";
            this.lblDotNet.Size = new System.Drawing.Size(34, 15);
            this.lblDotNet.TabIndex = 3;
            this.lblDotNet.Text = ".NET:";
            // 
            // lblArchitectureData
            // 
            this.lblArchitectureData.AutoSize = true;
            this.lblArchitectureData.Location = new System.Drawing.Point(101, 79);
            this.lblArchitectureData.Name = "lblArchitectureData";
            this.lblArchitectureData.Size = new System.Drawing.Size(57, 15);
            this.lblArchitectureData.TabIndex = 8;
            this.lblArchitectureData.Text = "unknown";
            // 
            // lblDotNetData
            // 
            this.lblDotNetData.AutoSize = true;
            this.lblDotNetData.Location = new System.Drawing.Point(101, 19);
            this.lblDotNetData.Name = "lblDotNetData";
            this.lblDotNetData.Size = new System.Drawing.Size(57, 15);
            this.lblDotNetData.TabIndex = 4;
            this.lblDotNetData.Text = "unknown";
            // 
            // lblOperatingSystemData
            // 
            this.lblOperatingSystemData.AutoSize = true;
            this.lblOperatingSystemData.Location = new System.Drawing.Point(101, 49);
            this.lblOperatingSystemData.Name = "lblOperatingSystemData";
            this.lblOperatingSystemData.Size = new System.Drawing.Size(57, 15);
            this.lblOperatingSystemData.TabIndex = 7;
            this.lblOperatingSystemData.Text = "unknown";
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Location = new System.Drawing.Point(6, 49);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(25, 15);
            this.lblOperatingSystem.TabIndex = 5;
            this.lblOperatingSystem.Text = "OS:";
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(6, 79);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(75, 15);
            this.lblArchitecture.TabIndex = 6;
            this.lblArchitecture.Text = "Architecture:";
            // 
            // tabPageThirdParty
            // 
            this.tabPageThirdParty.Controls.Add(this.rtbLicenses);
            this.tabPageThirdParty.Controls.Add(this.lblThirdPartyIntro);
            this.tabPageThirdParty.Location = new System.Drawing.Point(4, 24);
            this.tabPageThirdParty.Name = "tabPageThirdParty";
            this.tabPageThirdParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThirdParty.Size = new System.Drawing.Size(768, 398);
            this.tabPageThirdParty.TabIndex = 1;
            this.tabPageThirdParty.Text = "Third party components";
            this.tabPageThirdParty.UseVisualStyleBackColor = true;
            // 
            // rtbLicenses
            // 
            this.rtbLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLicenses.Location = new System.Drawing.Point(6, 40);
            this.rtbLicenses.Name = "rtbLicenses";
            this.rtbLicenses.ReadOnly = true;
            this.rtbLicenses.Size = new System.Drawing.Size(756, 352);
            this.rtbLicenses.TabIndex = 1;
            this.rtbLicenses.Text = "";
            // 
            // lblThirdPartyIntro
            // 
            this.lblThirdPartyIntro.AutoSize = true;
            this.lblThirdPartyIntro.Location = new System.Drawing.Point(6, 3);
            this.lblThirdPartyIntro.Name = "lblThirdPartyIntro";
            this.lblThirdPartyIntro.Size = new System.Drawing.Size(427, 15);
            this.lblThirdPartyIntro.TabIndex = 0;
            this.lblThirdPartyIntro.Text = "This program uses some third party components. Their licenses are listed below.";
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlInfo);
            this.MinimumSize = new System.Drawing.Size(480, 280);
            this.Name = "VersionForm";
            this.Text = "Version information";
            this.Load += new System.EventHandler(this.VersionForm_Load);
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageVersion.ResumeLayout(false);
            this.gbGit.ResumeLayout(false);
            this.gbGit.PerformLayout();
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.gbRuntimeInformation.ResumeLayout(false);
            this.gbRuntimeInformation.PerformLayout();
            this.tabPageThirdParty.ResumeLayout(false);
            this.tabPageThirdParty.PerformLayout();
            this.ResumeLayout(false);

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
    }
}