
namespace NativeScribe_Update
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtb_ReleaseNotes = new System.Windows.Forms.RichTextBox();
            this.btn_CoreUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_DatabaseDetails = new System.Windows.Forms.GroupBox();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.grp_Database = new System.Windows.Forms.GroupBox();
            this.btn_DatabaseUpdate = new System.Windows.Forms.Button();
            this.lbl_DatabaseBuild = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.grp_Core = new System.Windows.Forms.GroupBox();
            this.lbl_CoreBuild = new System.Windows.Forms.Label();
            this.lbl_Core = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.grp_DatabaseDetails.SuspendLayout();
            this.grp_Database.SuspendLayout();
            this.grp_Core.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_ReleaseNotes
            // 
            this.rtb_ReleaseNotes.Location = new System.Drawing.Point(12, 12);
            this.rtb_ReleaseNotes.Name = "rtb_ReleaseNotes";
            this.rtb_ReleaseNotes.ReadOnly = true;
            this.rtb_ReleaseNotes.Size = new System.Drawing.Size(419, 367);
            this.rtb_ReleaseNotes.TabIndex = 0;
            this.rtb_ReleaseNotes.Text = "";
            // 
            // btn_CoreUpdate
            // 
            this.btn_CoreUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CoreUpdate.Location = new System.Drawing.Point(9, 63);
            this.btn_CoreUpdate.Name = "btn_CoreUpdate";
            this.btn_CoreUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_CoreUpdate.TabIndex = 1;
            this.btn_CoreUpdate.Text = "Update";
            this.btn_CoreUpdate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_DatabaseDetails);
            this.panel1.Controls.Add(this.grp_Database);
            this.panel1.Controls.Add(this.grp_Core);
            this.panel1.Location = new System.Drawing.Point(437, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 367);
            this.panel1.TabIndex = 2;
            // 
            // grp_DatabaseDetails
            // 
            this.grp_DatabaseDetails.Controls.Add(this.lbl_Details);
            this.grp_DatabaseDetails.Location = new System.Drawing.Point(3, 199);
            this.grp_DatabaseDetails.Name = "grp_DatabaseDetails";
            this.grp_DatabaseDetails.Size = new System.Drawing.Size(137, 165);
            this.grp_DatabaseDetails.TabIndex = 0;
            this.grp_DatabaseDetails.TabStop = false;
            this.grp_DatabaseDetails.Text = "Details";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Location = new System.Drawing.Point(6, 25);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(27, 13);
            this.lbl_Details.TabIndex = 0;
            this.lbl_Details.Text = "N/A";
            // 
            // grp_Database
            // 
            this.grp_Database.Controls.Add(this.btn_DatabaseUpdate);
            this.grp_Database.Controls.Add(this.lbl_DatabaseBuild);
            this.grp_Database.Controls.Add(this.lbl_Database);
            this.grp_Database.Location = new System.Drawing.Point(3, 101);
            this.grp_Database.Name = "grp_Database";
            this.grp_Database.Size = new System.Drawing.Size(137, 92);
            this.grp_Database.TabIndex = 0;
            this.grp_Database.TabStop = false;
            this.grp_Database.Text = "Database";
            // 
            // btn_DatabaseUpdate
            // 
            this.btn_DatabaseUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatabaseUpdate.Location = new System.Drawing.Point(9, 63);
            this.btn_DatabaseUpdate.Name = "btn_DatabaseUpdate";
            this.btn_DatabaseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_DatabaseUpdate.TabIndex = 2;
            this.btn_DatabaseUpdate.Text = "Update";
            this.btn_DatabaseUpdate.UseVisualStyleBackColor = true;
            // 
            // lbl_DatabaseBuild
            // 
            this.lbl_DatabaseBuild.AutoSize = true;
            this.lbl_DatabaseBuild.Location = new System.Drawing.Point(6, 38);
            this.lbl_DatabaseBuild.Name = "lbl_DatabaseBuild";
            this.lbl_DatabaseBuild.Size = new System.Drawing.Size(72, 13);
            this.lbl_DatabaseBuild.TabIndex = 0;
            this.lbl_DatabaseBuild.Text = "Build: 201202";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(6, 25);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(93, 13);
            this.lbl_Database.TabIndex = 0;
            this.lbl_Database.Text = "Status: Up-to-date";
            // 
            // grp_Core
            // 
            this.grp_Core.Controls.Add(this.lbl_CoreBuild);
            this.grp_Core.Controls.Add(this.btn_CoreUpdate);
            this.grp_Core.Controls.Add(this.lbl_Core);
            this.grp_Core.Location = new System.Drawing.Point(3, 3);
            this.grp_Core.Name = "grp_Core";
            this.grp_Core.Size = new System.Drawing.Size(137, 92);
            this.grp_Core.TabIndex = 0;
            this.grp_Core.TabStop = false;
            this.grp_Core.Text = "Core";
            // 
            // lbl_CoreBuild
            // 
            this.lbl_CoreBuild.AutoSize = true;
            this.lbl_CoreBuild.Location = new System.Drawing.Point(6, 38);
            this.lbl_CoreBuild.Name = "lbl_CoreBuild";
            this.lbl_CoreBuild.Size = new System.Drawing.Size(72, 13);
            this.lbl_CoreBuild.TabIndex = 4;
            this.lbl_CoreBuild.Text = "Build: 201202";
            // 
            // lbl_Core
            // 
            this.lbl_Core.AutoSize = true;
            this.lbl_Core.Location = new System.Drawing.Point(6, 25);
            this.lbl_Core.Name = "lbl_Core";
            this.lbl_Core.Size = new System.Drawing.Size(93, 13);
            this.lbl_Core.TabIndex = 3;
            this.lbl_Core.Text = "Status: Up-to-date";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtb_ReleaseNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Software Update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.grp_DatabaseDetails.ResumeLayout(false);
            this.grp_DatabaseDetails.PerformLayout();
            this.grp_Database.ResumeLayout(false);
            this.grp_Database.PerformLayout();
            this.grp_Core.ResumeLayout(false);
            this.grp_Core.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_ReleaseNotes;
        private System.Windows.Forms.Button btn_CoreUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_Core;
        private System.Windows.Forms.Label lbl_CoreBuild;
        private System.Windows.Forms.Label lbl_Core;
        private System.Windows.Forms.GroupBox grp_Database;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.Label lbl_DatabaseBuild;
        private System.Windows.Forms.Button btn_DatabaseUpdate;
        private System.Windows.Forms.GroupBox grp_DatabaseDetails;
        private System.Windows.Forms.Label lbl_Details;
    }
}

