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
            this.panelTop.Size = new System.Drawing.Size(592, 99);
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
            this.panelLogo.Size = new System.Drawing.Size(592, 99);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesc
            // 
            this.panelDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesc.Controls.Add(this.labelVersion);
            this.panelDesc.Controls.Add(this.labelTitle);
            this.panelDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDesc.Location = new System.Drawing.Point(0, 198);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(592, 99);
            this.panelDesc.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(229, 48);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(132, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "v1.0 (Build 200622)";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(205, 8);
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
            this.panelDev.Controls.Add(this.labelWebsite);
            this.panelDev.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelDev.Location = new System.Drawing.Point(0, 297);
            this.panelDev.Name = "panelDev";
            this.panelDev.Size = new System.Drawing.Size(592, 99);
            this.panelDev.TabIndex = 0;
            // 
            // linkProject
            // 
            this.linkProject.AutoSize = true;
            this.linkProject.Location = new System.Drawing.Point(176, 42);
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
            this.labelWebsite.Location = new System.Drawing.Point(266, 22);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(3);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(59, 17);
            this.labelWebsite.TabIndex = 0;
            this.labelWebsite.Text = "Website";
            this.labelWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelBottom.Location = new System.Drawing.Point(0, 396);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(592, 60);
            this.panelBottom.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 460);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelDev);
            this.Controls.Add(this.panelDesc);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}