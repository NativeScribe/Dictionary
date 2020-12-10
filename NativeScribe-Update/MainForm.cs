using System;
using System.Net;
using System.Windows.Forms;

namespace NativeScribe_Update
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rtb_ReleaseNotes.ReadOnly = true;
            try
            {
                try
                {
                    string contents;
                    using (var wc = new WebClient())
                        contents = wc.DownloadString("https://servdocs.syafiqhadzir.dev/Projects/NativeScribe/ReleaseNotes.txt");

                    rtb_ReleaseNotes.Text = contents.ToString();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception lv_err)
            {
                MessageBox.Show(lv_err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}