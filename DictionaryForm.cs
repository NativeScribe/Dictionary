using System;
using System.Windows.Forms;

namespace NativeScribe
{
    public partial class DictionaryForm : Form
    {
        private DictionaryManage dictionary;

        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            cboSearch.DisplayMember = "Key";

            dictionary = new DictionaryManage();
            dictionary.LoadDataToComboBox(cboSearch);
        }

        private void CboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
            {
                return;
            }

            Dictionary data = cb.SelectedItem as Dictionary;
            txtDesc.Text = data.Desc;
        }
    }
}