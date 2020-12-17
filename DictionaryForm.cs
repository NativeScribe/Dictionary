using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NativeScribe
{
    public partial class DictionaryForm : Form
    {
        public DictionaryForm()
        {
            InitializeComponent();
        }

        private List<Dict> sortedListDict = new List<Dict>();

        private int Index = 0;

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
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
    }

    internal class Dict
    {
        public string Word { get; set; }
        public string Desc { get; set; }
    }
}