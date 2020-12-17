using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NativeScribe
{
    public class DictionaryManage
    {
        private readonly string filePath = @"data.xml";

        private DictionaryItem items;

        public DictionaryItem Items { get => items; set => items = value; }

        public DictionaryManage()
        {
            items = (DictionaryItem)DeserializeFormXML(filePath);
        }

        /// <param name="combo"></param>
        public void LoadDataToComboBox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }

        /// <param name="list"></param>
        public void LoadDataToListBox(ListBox list)
        {
            list.DataSource = items.Items;
        }

        public void Serialize()
        {
            SerializeToXML(items, filePath);
        }

        /// <param name="data"></param>
        /// <param name="filePath"></param>
        public void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer srlXML = new XmlSerializer(typeof(DictionaryItem));

            srlXML.Serialize(fs, data);
            fs.Close();
        }

        /// <param name="filePath"></param>
        /// <returns></returns>
        public object DeserializeFormXML(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer srlXML = new XmlSerializer(typeof(DictionaryItem));

            object obj = srlXML.Deserialize(fileStream);

            fileStream.Close();

            return obj;
        }
    }
}