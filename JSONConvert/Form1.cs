namespace JSONConvert
{
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using System.IO;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<string> _Name = new List<string>();
        private List<string> Detail = new List<string>();
        private List<int> ItemType = new List<int>();
        private List<int> Price = new List<int>();
        private List<string> Description = new List<string>();
        private string preName, preDetail, preDescription;
        private int preItemType, prePrice;
        bool listEditOnly = false;
        private void EnterBtn_Click(object sender, EventArgs e)
        {

            //string Name, string Detail, int ItemType, int Price, string Description
            string _name = "", _detail = "", _description = "";
            int _itemType = 0, _price = 0;
            bool _err = false;
            //verify input format
            try
            {
                _name = Col1_Txt.Text;
                _detail = Col2_Txt.Text;
                _itemType = (int)Col3_Txt.Value;
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
                _Name.Add(_name);
                Detail.Add(_detail);
                ItemType.Add(_itemType);
                Price.Add(_price);
                Description.Add(_description);
                //msg = $"Name:{_name},Detail:{_detail},ItemType:{_itemType},Price:{_price},Description:{_description}";
                listBox1.Items.Add(_name);
            }
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            Col1_Txt.Text = preName;
            Col2_Txt.Text = preDetail;
            Col3_Txt.Value = preItemType;
            Col4_Txt.Value = prePrice;
            Col5_Txt.Text = preDescription;
            prevBtn.Enabled = false;
        }
        // data work
        private void dataRemove(int Index)
        {
            listBox1.Items.RemoveAt(Index);
            _Name.RemoveAt(Index);
            Detail.RemoveAt(Index);
            ItemType.RemoveAt(Index);
            Price.RemoveAt(Index);
            Description.RemoveAt(Index);
        }
        private void dataClear()
        {
            listBox1.Items.Clear();
            _Name.Clear();
            Detail.Clear();
            ItemType.Clear();
            Price.Clear();
            Description.Clear();
        }
        private void dataEdit(int index)
        {
            listBox1.Items[index] = Col1_Txt.Text;
            _Name[index] = Col1_Txt.Text;
            Detail[index] = Col2_Txt.Text;
            ItemType[index] = (int)Col3_Txt.Value;
            Price[index] = (int)Col4_Txt.Value;
            Description[index] = Col5_Txt.Text;
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

                List<DataItem> dataItems = new List<DataItem>();
                for (int i = 0; i < _Name.Count; i++)
                {
                    dataItems.Add(new DataItem
                    {
                        Name = _Name[i],
                        Detail = Detail[i],
                        ItemType = ItemType[i],
                        Price = Price[i],
                        Description = Description[i],
                    });
                }
                string json = JsonConvert.SerializeObject(dataItems, Formatting.Indented);

                File.WriteAllText($"{filePath}\\Itemdatabase.json", json);

                MessageBox.Show("save to Json");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!prevBtn.Enabled)
            {
                preName = Col1_Txt.Text;
                preDetail = Col2_Txt.Text;
                preItemType = (int)Col3_Txt.Value;
                prePrice = (int)Col4_Txt.Value;
                preDescription = Col5_Txt.Text;
            }
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            if (!listEditOnly)
            {
                Col1_Txt.Text = _Name[index];
                Col2_Txt.Text = Detail[index];
                Col3_Txt.Value = ItemType[index];
                Col4_Txt.Value = Price[index];
                Col5_Txt.Text = Description[index];
            }
            editBtn.Enabled = true;
            prevBtn.Enabled = true;
        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string json = File.ReadAllText(filePath);

                List<DataItem> dataItems = JsonConvert.DeserializeObject<List<DataItem>>(json);
                dataClear();
                foreach (var item in dataItems)
                {
                    _Name.Add(item.Name);
                    Detail.Add(item.Detail);
                    ItemType.Add(item.ItemType);
                    Price.Add(item.Price);
                    Description.Add(item.Description);
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        public class DataItem
        {
            public string Name { get; set; }
            public string Detail { get; set; }
            public int ItemType { get; set; }
            public int Price { get; set; }
            public string Description { get; set; }
        }


    }
}
