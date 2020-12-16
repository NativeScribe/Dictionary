namespace NativeScribe
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesc = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDev = new System.Windows.Forms.Panel();
            this.linkProject = new System.Windows.Forms.LinkLabel();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.lnk_Version = new System.Windows.Forms.LinkLabel();
            this.lnk_License = new System.Windows.Forms.LinkLabel();
            this.panelDesc.SuspendLayout();
            this.panelDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(608, 99);
            this.panelTop.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelLogo.Location = new System.Drawing.Point(0, 99);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(608, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesc
            // 
            this.panelDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesc.Controls.Add(this.lbl_Subtitle);
            this.panelDesc.Controls.Add(this.labelVersion);
            this.panelDesc.Controls.Add(this.labelTitle);
            this.panelDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDesc.Location = new System.Drawing.Point(0, 199);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(608, 100);
            this.panelDesc.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(191, 76);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(211, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Tun Seri Lanang (Build 201217)";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(206, 8);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(181, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "NativeScribe";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDev
            // 
            this.panelDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDev.Controls.Add(this.linkProject);
            this.panelDev.Controls.Add(this.lnk_License);
            this.panelDev.Controls.Add(this.labelWebsite);
            this.panelDev.Controls.Add(this.lnk_Version);
            this.panelDev.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelDev.Location = new System.Drawing.Point(0, 299);
            this.panelDev.Name = "panelDev";
            this.panelDev.Size = new System.Drawing.Size(608, 100);
            this.panelDev.TabIndex = 0;
            // 
            // linkProject
            // 
            this.linkProject.AutoSize = true;
            this.linkProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkProject.Location = new System.Drawing.Point(177, 75);
            this.linkProject.Name = "linkProject";
            this.linkProject.Size = new System.Drawing.Size(238, 17);
            this.linkProject.TabIndex = 0;
            this.linkProject.TabStop = true;
            this.linkProject.Text = "https://nativescribe.syafiqhadzir.dev/";
            this.linkProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWebsite
            // 
            this.labelWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(243, 55);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(3);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(106, 17);
            this.labelWebsite.TabIndex = 0;
            this.labelWebsite.Text = "Official Website";
            this.labelWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelBottom.Location = new System.Drawing.Point(0, 399);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(608, 100);
            this.panelBottom.TabIndex = 0;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitle.Location = new System.Drawing.Point(138, 44);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(317, 20);
            this.lbl_Subtitle.TabIndex = 0;
            this.lbl_Subtitle.Text = "An Open Malayo-Polynesian Dictionary";
            // 
            // lnk_Version
            // 
            this.lnk_Version.AutoSize = true;
            this.lnk_Version.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_Version.LinkArea = new System.Windows.Forms.LinkArea(7, 13);
            this.lnk_Version.Location = new System.Drawing.Point(229, 3);
            this.lnk_Version.Name = "lnk_Version";
            this.lnk_Version.Size = new System.Drawing.Size(134, 20);
            this.lnk_Version.TabIndex = 0;
            this.lnk_Version.TabStop = true;
            this.lnk_Version.Text = "v1.1a (release notes)";
            this.lnk_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnk_Version.UseCompatibleTextRendering = true;
            // 
            // lnk_License
            // 
            this.lnk_License.AutoSize = true;
            this.lnk_License.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_License.Location = new System.Drawing.Point(184, 23);
            this.lnk_License.Name = "lnk_License";
            this.lnk_License.Size = new System.Drawing.Size(224, 17);
            this.lnk_License.TabIndex = 0;
            this.lnk_License.TabStop = true;
            this.lnk_License.Text = "License and Open Source Notices";
            this.lnk_License.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 499);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelDev);
            this.Controls.Add(this.panelDesc);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.panelDesc.ResumeLayout(false);
            this.panelDesc.PerformLayout();
            this.panelDev.ResumeLayout(false);
            this.panelDev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesc;
        private System.Windows.Forms.Panel panelDev;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.LinkLabel linkProject;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.LinkLabel lnk_License;
        private System.Windows.Forms.LinkLabel lnk_Version;
    }
}