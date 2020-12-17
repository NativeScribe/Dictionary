using System;
using System.Windows.Forms;

namespace NativeScribe
{
    public partial class DictionaryForm : Form
    {
        private DictionaryManage dictionary;
        private int index = 0;

        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            dictionary = new DictionaryManage();

            cbWord.DisplayMember = "Key";
            dictionary.LoadDataToComboBox(cbWord);
            cbWord.SelectedIndex = index;

            lbWord.DisplayMember = "Key";
            dictionary.LoadDataToListBox(lbWord);
            lbWord.SelectedIndex = index;
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

            index = cbWord.SelectedIndex;
            lbWord.SelectedIndex = index;
        }

        private void LbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox cb = sender as ListBox;

            if (cb.DataSource == null)
            {
                return;
            }

            Dictionary data = cb.SelectedItem as Dictionary;
            txtDesc.Text = data.Explaination;

            index = lbWord.SelectedIndex;
            cbWord.SelectedIndex = index;
        }
    }
}