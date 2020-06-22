namespace NativeScribe
{
    partial class DictionaryForm
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
            this.webDesc = new System.Windows.Forms.WebBrowser();
            this.lboWord = new System.Windows.Forms.ListBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // webDesc
            // 
            this.webDesc.Location = new System.Drawing.Point(273, 28);
            this.webDesc.Margin = new System.Windows.Forms.Padding(4);
            this.webDesc.MinimumSize = new System.Drawing.Size(24, 22);
            this.webDesc.Name = "webDesc";
            this.webDesc.Size = new System.Drawing.Size(306, 422);
            this.webDesc.TabIndex = 0;
            // 
            // lboWord
            // 
            this.lboWord.FormattingEnabled = true;
            this.lboWord.ItemHeight = 16;
            this.lboWord.Location = new System.Drawing.Point(16, 62);
            this.lboWord.Margin = new System.Windows.Forms.Padding(4);
            this.lboWord.Name = "lboWord";
            this.lboWord.Size = new System.Drawing.Size(248, 388);
            this.lboWord.TabIndex = 0;
            // 
            // cboSearch
            // 
            this.cboSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(16, 28);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(248, 24);
            this.cboSearch.TabIndex = 0;
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 460);
            this.Controls.Add(this.lboWord);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.webDesc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DictionaryForm";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.DictionaryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webDesc;
        private System.Windows.Forms.ListBox lboWord;
        private System.Windows.Forms.ComboBox cboSearch;
    }
}