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
            this.lblVersionData = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPageThirdParty = new System.Windows.Forms.TabPage();
            this.lblThirdPartyIntro = new System.Windows.Forms.Label();
            this.rtbLicenses = new System.Windows.Forms.RichTextBox();
            this.tabControlInfo.SuspendLayout();
            this.tabPageVersion.SuspendLayout();
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
            this.tabPageVersion.Controls.Add(this.lblVersionData);
            this.tabPageVersion.Controls.Add(this.lblVersion);
            this.tabPageVersion.Controls.Add(this.lblTitle);
            this.tabPageVersion.Location = new System.Drawing.Point(4, 24);
            this.tabPageVersion.Name = "tabPageVersion";
            this.tabPageVersion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVersion.Size = new System.Drawing.Size(768, 398);
            this.tabPageVersion.TabIndex = 0;
            this.tabPageVersion.Text = "Version";
            this.tabPageVersion.UseVisualStyleBackColor = true;
            // 
            // lblVersionData
            // 
            this.lblVersionData.AutoSize = true;
            this.lblVersionData.Location = new System.Drawing.Point(72, 54);
            this.lblVersionData.Name = "lblVersionData";
            this.lblVersionData.Size = new System.Drawing.Size(57, 15);
            this.lblVersionData.TabIndex = 2;
            this.lblVersionData.Text = "unknown";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(6, 54);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mouse Click Simulator";
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
            // lblThirdPartyIntro
            // 
            this.lblThirdPartyIntro.AutoSize = true;
            this.lblThirdPartyIntro.Location = new System.Drawing.Point(6, 3);
            this.lblThirdPartyIntro.Name = "lblThirdPartyIntro";
            this.lblThirdPartyIntro.Size = new System.Drawing.Size(427, 15);
            this.lblThirdPartyIntro.TabIndex = 0;
            this.lblThirdPartyIntro.Text = "This program uses some third party components. Their licenses are listed below.";
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
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlInfo);
            this.Name = "VersionForm";
            this.Text = "Version information";
            this.Load += new System.EventHandler(this.VersionForm_Load);
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageVersion.ResumeLayout(false);
            this.tabPageVersion.PerformLayout();
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
    }
}