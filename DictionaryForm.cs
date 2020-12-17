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
            cbWord.DisplayMember = "Key";

            dictionary = new DictionaryManage();
            dictionary.LoadDataToComboBox(cbWord);
        }

        private void CbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
            {
                return;
            }

            Dictionary data = cb.SelectedItem as Dictionary;
            txtDesc.Text = data.Explaination;
        }
    }
}