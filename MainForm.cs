using System;
using System.Windows.Forms;

namespace NativeScribe
{
    public partial class MainForm : Form
    {
        private readonly DictionaryManage dictionary;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DictionaryForm());

            btnDict.Enabled = false;
            btnAbout.Enabled = true;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //openChildForm(new HomeForm());
        }

        private void BtnDict_Click(object sender, EventArgs e)
        {
            activeForm.Close();

            OpenChildForm(new DictionaryForm());

            btnDict.Enabled = false;
            btnAbout.Enabled = true;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            activeForm.Close();

            OpenChildForm(new AboutForm());

            btnDict.Enabled = true;
            btnAbout.Enabled = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

            dictionary.Serialize();
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

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm.Close();

            OpenChildForm(new AboutForm());

            btnDict.Enabled = true;
            btnAbout.Enabled = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            dictionary.Serialize();
        }
    }
}