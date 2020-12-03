using System;
using System.Collections.Generic;
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //openChildForm(new HomeForm());
        }

        private void BtnDict_Click(object sender, EventArgs e)
        {
            activeForm.Close();

            btnDict.Enabled = false;
            btnAbout.Enabled = true;

            cboSearch.Enabled = true;
            lboWord.Enabled = true;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());

            btnDict.Enabled = true;
            btnAbout.Enabled = false;

            cboSearch.Enabled = false;
            lboWord.Enabled = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
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

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LboWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = lboWord.SelectedIndex;

            cboSearch.SelectedIndex = Index;

            string Desc = sortedListDict.ElementAt(Index).Desc;

            webDesc.DocumentText = Desc;
        }

        private void CboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = cboSearch.SelectedIndex;

            lboWord.SelectedIndex = Index;

            string Desc = sortedListDict.ElementAt(Index).Desc;

            webDesc.DocumentText = Desc;
        }

        private void WebDesc_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());

            btnDict.Enabled = true;
            btnAbout.Enabled = false;

            cboSearch.Enabled = false;
            lboWord.Enabled = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    internal class Dict
    {
        public string Word { get; set; }
        public string Desc { get; set; }
    }
}