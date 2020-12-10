using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace NativeScribe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Dict> sortedListDict = new List<Dict>();

        private int Index = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDict.Enabled = false;
            btnAbout.Enabled = true;

            List<Dict> listDict = new List<Dict>();

            // Dictionary
            Dict dict1 = new Dict
            {
                Word = "",
                Desc = ""
            };
            listDict.Add(dict1);

            sortedListDict = listDict.OrderBy(x => x.Word).ToList();

            List<string> listWord = new List<string>();
            listWord.Sort();

            foreach (Dict d in sortedListDict)
            {
                listWord.Add(d.Word);
            }

            lboWord.Items.AddRange(listWord.ToArray());

            cboSearch.Items.AddRange(listWord.ToArray());

            lboWord.SelectedIndex = Index;

            cboSearch.SelectedIndex = Index;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //openChildForm(new HomeForm());
        }

        private void btnDict_Click(object sender, EventArgs e)
        {
            activeForm.Close();

            btnDict.Enabled = false;
            btnAbout.Enabled = true;

            cboSearch.Enabled = true;
            lboWord.Enabled = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutForm());

            btnDict.Enabled = true;
            btnAbout.Enabled = false;

            cboSearch.Enabled = false;
            lboWord.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lboWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = lboWord.SelectedIndex;

            cboSearch.SelectedIndex = Index;

            string Desc = sortedListDict.ElementAt(Index).Desc;

            webDesc.DocumentText = Desc;
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = cboSearch.SelectedIndex;

            lboWord.SelectedIndex = Index;

            string Desc = sortedListDict.ElementAt(Index).Desc;

            webDesc.DocumentText = Desc;
        }

        private void webDesc_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutForm());

            btnDict.Enabled = true;
            btnAbout.Enabled = false;

            cboSearch.Enabled = false;
            lboWord.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@".\NativeScribe-Update.exe");
        }
    }

    internal class Dict
    {
        public string Word { get; set; }
        public string Desc { get; set; }
    }
}