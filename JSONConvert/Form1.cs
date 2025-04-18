namespace JSONConvert
{
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using System.IO;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    using System.Windows.Forms;
    using System.Security.Cryptography;
    using System;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<int> ItemID = new List<int>();
        private List<string> _Name = new List<string>();
        private List<string> Detail = new List<string>();
        private List<int> ItemType = new List<int>();
        private List<int> Price = new List<int>();
        private List<string> Description = new List<string>();
        private List<DataItem> dataItem = new List<DataItem>();
        private string preName, preDetail, preDescription;
        private int preID, preItemType, prePrice;
        bool listEditOnly = false;
        private void EnterBtn_Click(object sender, EventArgs e)
        {

            //string Name, string Detail, int ItemType, int Price, string Description
            int _ID = 0;
            string _name = "", _detail = "", _description = "";
            int _itemType = 0, _price = 0;
            bool _err = false;
            //verify input format
            try
            {
                _ID = (int)Col0_Txt.Value;
                _name = Col1_Txt.Text;
                _detail = Col2_Txt.Text;
                _itemType = Col3_Txt.SelectedIndex;
                _price = (int)Col4_Txt.Value;
                _description = Col5_Txt.Text;
            }
            catch
            {
                _err = true;
                MessageBox.Show("Detect other error.");
            }
            if (!_err)
            {

                string msg = "";
                DataItem _item = new DataItem
                {
                    ID = dataItem.Count,
                    Name = _name,
                    Detail = _detail,
                    ItemType = _itemType,
                    Price = _price,
                    Description = _description
                };
                if (_item.ItemType == 0) _item.Detail = "duration:1";

                if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex - 1 == _item.ItemType)
                {
                    listBox1.Items.Add(dataItem.Count - 1 + "-" + _name);
                }
                dataItem.Add(_item);
            }
            Col0_Txt.Value = dataItem.Count;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            Col0_Txt.Value = preID;
            Col1_Txt.Text = preName;
            Col2_Txt.Text = preDetail;
            Col3_Txt.SelectedIndex = preItemType;
            Col4_Txt.Value = prePrice;
            Col5_Txt.Text = preDescription;
            listBox2.Items.Clear();
            prevBtn.Enabled = false;
        }
        // data work
        private void IDRefresh()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < dataItem.Count; i++)
            {
                if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex - 1 == dataItem[i].ItemType)
                {
                    dataItem[i].ID = i;
                    listBox1.Items.Add(dataItem[i].ID + "-" + dataItem[i].Name);
                }
            }
        }
        private void dataRemove(int index)
        {

            string[] _index = listBox1.Items[index].ToString().Split('-');
            listBox1.Items.RemoveAt(index);
            dataItem.RemoveAt(int.Parse(_index[0]));

        }
        private void dataClear()
        {
            listBox1.Items.Clear();
            dataItem.Clear();

        }
        private void dataEdit(int index)
        {
            string[] _index = listBox1.Items[index].ToString().Split('-');

            dataItem[int.Parse(_index[0])] = new DataItem
            {
                ID = (int)Col0_Txt.Value,
                Name = Col1_Txt.Text,
                Detail = Col2_Txt.Text,
                ItemType = (int)Col3_Txt.SelectedIndex,
                Price = (int)Col4_Txt.Value,
                Description = Col5_Txt.Text
            };
            listBox1.Items[index] = Col0_Txt.Value + "-" + Col1_Txt.Text;
            listEditOnly = false;
        }
        // data work end
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            listEditOnly = true;
            dataEdit(listBox1.SelectedIndex);
            editBtn.Enabled = false;

        }
        private void listRemoveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            dataRemove(listBox1.SelectedIndex);
            IDRefresh();

        }

        private void OutputBtn_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = folderBrowserDialog1.SelectedPath;

                string json = JsonConvert.SerializeObject(dataItem, Formatting.Indented);

                File.WriteAllText($"{filePath}\\Itemdatabase.json", json);

                MessageBox.Show("save to Json");
            }

        }
        private void InputBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string json = File.ReadAllText(filePath);

                List<DataItem> dataItems = JsonConvert.DeserializeObject<List<DataItem>>(json);
                dataClear();
                dataItem = dataItems;
                comboBox1.SelectedIndex = 0;
                IDRefresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!prevBtn.Enabled)
            {
                preID = (int)Col0_Txt.Value;
                preName = Col1_Txt.Text;
                preDetail = Col2_Txt.Text;
                preItemType = (int)Col3_Txt.SelectedIndex;
                prePrice = (int)Col4_Txt.Value;
                preDescription = Col5_Txt.Text;
            }
            int index = listBox1.SelectedIndex;
            string[] _index = listBox1.Items[index].ToString().Split('-');
            index = int.Parse(_index[0]);
            if (index == -1) return;
            if (!listEditOnly)
            {
                Col0_Txt.Value = dataItem[index].ID;
                Col1_Txt.Text = dataItem[index].Name;
                Col2_Txt.Text = dataItem[index].Detail;
                Col3_Txt.SelectedIndex = dataItem[index].ItemType;
                Col4_Txt.Value = dataItem[index].Price;
                Col5_Txt.Text = dataItem[index].Description;
                if (dataItem[index].ItemType == 0) Seed_For_Corp();
                else if (dataItem[index].ItemType == 1) Corp_For_Seed();
                else ClearList2();
            }
            editBtn.Enabled = true;
            prevBtn.Enabled = true;
        }
        // "seed", "corp", "food", "fish", "other" 
        // seed => corp
        // corp => seed
        // seed detial need duration:
        // corp detail need seed name

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ItemIndex_1 = listBox1.SelectedIndex;
            int ItemIndex_2 = listBox2.SelectedIndex;
            if (ItemIndex_1 == -1 || ItemIndex_2 == -1) return;
            string[] _index = listBox2.Items[ItemIndex_2].ToString().Split('-');
            ItemIndex_2 = int.Parse(_index[0]);
            int filterIndex = comboBox2.SelectedIndex - 1;
            if (filterIndex == 0)//c2 seed, c1 corp
            {
                string str = dataItem[ItemIndex_1].Detail;
                dataItem[ItemIndex_1].Detail = "seed:" + dataItem[ItemIndex_2].Name;
                Col2_Txt.Text = dataItem[ItemIndex_1].Detail;
            }
            else if (filterIndex == 1)//c2 corp, c1 seed
            {

                string str = dataItem[ItemIndex_2].Detail;
                dataItem[ItemIndex_2].Detail = "seed:" + dataItem[ItemIndex_1].Name;
            }
        }
        private int SearchNameIndex(string _name)
        {
            for (int i = 0; i < dataItem.Count; i++)
            {
                if (dataItem[i].Name == _name) return i;
            }
            return -1;
        }
        private void Seed_For_Corp()
        {
            listBox2.Items.Clear();
            comboBox2.SelectedIndex = 2;
            int filterIndex = 1;
            string seedName = "";

            foreach (DataItem item in dataItem)
            {
                string corpdetail = item.Detail;
                if (corpdetail.IndexOf("seed:") != -1) seedName = corpdetail.Substring(corpdetail.IndexOf(':') + 1);
                if (item.ItemType == filterIndex)
                {
                    listBox2.Items.Add(item.ID + "-" + item.Name);
                    if (seedName != "" && seedName == dataItem[listBox1.SelectedIndex].Name) listBox2.SelectedIndex = listBox2.Items.Count - 1;
                }
            }

        }

        private void Corp_For_Seed()
        {
            listBox2.Items.Clear();
            comboBox2.SelectedIndex = 1;
            int filterIndex = 0;
            string seedName = "";
            string corpdetail = dataItem[listBox1.SelectedIndex].Detail;
            if (corpdetail.IndexOf("seed:") != -1) seedName = corpdetail.Substring(corpdetail.IndexOf(':') + 1);
            foreach (DataItem item in dataItem)
            {
                if (item.ItemType == filterIndex)
                {
                    listBox2.Items.Add(item.ID + "-" + item.Name);
                    if (seedName != "" && seedName == item.Name) listBox2.SelectedIndex = listBox2.Items.Count - 1;
                }
            }

        }

        private void ClearList2()
        {
            listBox2.Items.Clear();
            comboBox2.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filterIndex = comboBox1.SelectedIndex - 1;
            listBox1.Items.Clear();
            if (filterIndex == -1)
            {
                foreach (DataItem item in dataItem)
                {
                    listBox1.Items.Add(item.ID + "-" + item.Name);
                }
            }
            else
            {
                foreach (DataItem item in dataItem)
                {
                    if (item.ItemType == filterIndex) listBox1.Items.Add(item.ID + "-" + item.Name);
                }
            }
        }
        private void Col3_Txt_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public class DataItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Detail { get; set; }
            public int ItemType { get; set; }
            public int Price { get; set; }
            public string Description { get; set; }
        }


    }
}
