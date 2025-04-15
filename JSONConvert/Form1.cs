namespace JSONConvert
{
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using System.IO;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    using System.Windows.Forms;
    using System.Security.Cryptography;

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
                //ItemID.Add(_ID);
                //_Name.Add(_name);
                //Detail.Add(_detail);
                //ItemType.Add(_itemType);
                //Price.Add(_price);
                //Description.Add(_description);
                dataItem.Add(new DataItem
                {
                    ID = _ID,
                    Name = _name,
                    Detail = _detail,
                    ItemType = _itemType,
                    Price = _price,
                    Description = _description
                });
                //msg = $"Name:{_name},Detail:{_detail},ItemType:{_itemType},Price:{_price},Description:{_description}";
                listBox1.Items.Add(_name);
            }
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            Col0_Txt.Value = preID;
            Col1_Txt.Text = preName;
            Col2_Txt.Text = preDetail;
            Col3_Txt.SelectedIndex = preItemType;
            Col4_Txt.Value = prePrice;
            Col5_Txt.Text = preDescription;
            prevBtn.Enabled = false;
        }
        // data work
        private bool itemIDChecker(int _ID)
        {
            foreach (int itemID in ItemID)
            {
                if (itemID == _ID) return true;
            }
            return false;
        }
        private void SwapItem(int ID_A, int ID_B)
        {
            DataItem _item = new DataItem
            {
                ID = ID_A,
                Name = _Name[ID_A],
                Detail = Detail[ID_A],
                ItemType = ItemType[ID_A],
                Price = Price[ID_A],
                Description = Description[ID_A],
            };
        }
        private void IDRefresh()
        {
            for (int i = 0; i < dataItem.Count; i++)
                dataItem[i].ID = i;
        }
        private void dataRemove(int Index)
        {
            listBox1.Items.RemoveAt(Index);
            dataItem.RemoveAt(Index);
            //ItemID.RemoveAt(Index);
            //_Name.RemoveAt(Index);
            //Detail.RemoveAt(Index);
            //ItemType.RemoveAt(Index);
            //Price.RemoveAt(Index);
            //Description.RemoveAt(Index);
        }
        private void dataClear()
        {
            listBox1.Items.Clear();
            dataItem.Clear();
            //ItemID.Clear();
            //_Name.Clear();
            //Detail.Clear();
            //ItemType.Clear();
            //Price.Clear();
            //Description.Clear();
        }
        private void dataEdit(int index)
        {
            dataItem[index] = new DataItem
            {
                ID = (int)Col0_Txt.Value,
                Name = Col1_Txt.Text,
                Detail = Col2_Txt.Text,
                ItemType = (int)Col3_Txt.SelectedIndex,
                Price = (int)Col4_Txt.Value,
                Description = Col5_Txt.Text
            };
            ItemID[index] = (int)Col0_Txt.Value;
            listBox1.Items[index] = Col1_Txt.Text;
            //_Name[index] = Col1_Txt.Text;
            //Detail[index] = Col2_Txt.Text;
            //ItemType[index] = (int)Col3_Txt.SelectedIndex;
            //Price[index] = (int)Col4_Txt.Value;
            //Description[index] = Col5_Txt.Text;
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
        }

        private void OutputBtn_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = folderBrowserDialog1.SelectedPath;

                //List<DataItem> dataItems = new List<DataItem>();
                //for (int i = 0; i < _Name.Count; i++)
                //{
                //    dataItems.Add(new DataItem
                //    {
                //        ID = ItemID[i],
                //        Name = _Name[i],
                //        Detail = Detail[i],
                //        ItemType = ItemType[i],
                //        Price = Price[i],
                //        Description = Description[i],
                //    });
                //}
                string json = JsonConvert.SerializeObject(dataItem, Formatting.Indented);

                File.WriteAllText($"{filePath}\\Itemdatabase.json", json);

                MessageBox.Show("save to Json");
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
            if (index == -1) return;
            if (!listEditOnly)
            {
                Col0_Txt.Value = dataItem[index].ID;
                Col1_Txt.Text = dataItem[index].Name;
                Col2_Txt.Text = dataItem[index].Detail;
                Col3_Txt.SelectedIndex = dataItem[index].ItemType;
                Col4_Txt.Value = dataItem[index].Price;
                Col5_Txt.Text = dataItem[index].Description;
            }
            editBtn.Enabled = true;
            prevBtn.Enabled = true;
            IDRefresh();
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                foreach (var item in dataItems)
                {
                    listBox1.Items.Add(item.Name);
                }
                comboBox1.SelectedIndex = 0;
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filterIndex = comboBox1.SelectedIndex - 1;
            listBox1.Items.Clear();
            if (filterIndex == -1)
            {
                foreach (DataItem item in dataItem)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
            else
            {
                foreach (DataItem item in dataItem)
                {
                    if (item.ItemType == filterIndex) listBox1.Items.Add(item.Name);
                }
            }
        }


    }
}
