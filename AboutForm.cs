using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NativeScribe
{
    public partial class AboutForm : Form
    {
        private readonly string Version = "201217";

        public AboutForm()
        {
            InitializeComponent();
        }

        private void Lnk_Version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://servdocs.syafiqhadzir.dev/Projects/NativeScribe/" + Version + "/ReleaseNote.txt");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lnk_License_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://servdocs.syafiqhadzir.dev/Projects/NativeScribe/" + Version + "/License.txt");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nativescribe.syafiqhadzir.dev/");
        }
    }
}