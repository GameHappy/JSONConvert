namespace JSONConvert
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Col_1 = new Label();
            Col_2 = new Label();
            Col_3 = new Label();
            Col_4 = new Label();
            Col_5 = new Label();
            EnterBtn = new Button();
            Col1_Txt = new TextBox();
            Col2_Txt = new TextBox();
            Col5_Txt = new TextBox();
            listBox1 = new ListBox();
            OutputBtn = new Button();
            InputBtn = new Button();
            Col4_Txt = new NumericUpDown();
            listRemoveBtn = new Button();
            editBtn = new Button();
            prevBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            Col3_Txt = new ComboBox();
            comboBox1 = new ComboBox();
            Col_0 = new Label();
            Col0_Txt = new NumericUpDown();
            listBox2 = new ListBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Col4_Txt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Col0_Txt).BeginInit();
            SuspendLayout();
            // 
            // Col_1
            // 
            Col_1.AutoSize = true;
            Col_1.Font = new Font("Segoe UI", 12F);
            Col_1.Location = new Point(12, 48);
            Col_1.Name = "Col_1";
            Col_1.Size = new Size(52, 21);
            Col_1.TabIndex = 1;
            Col_1.Text = "Name";
            // 
            // Col_2
            // 
            Col_2.AutoSize = true;
            Col_2.Font = new Font("Segoe UI", 12F);
            Col_2.Location = new Point(13, 84);
            Col_2.Name = "Col_2";
            Col_2.Size = new Size(50, 21);
            Col_2.TabIndex = 2;
            Col_2.Text = "Detail";
            // 
            // Col_3
            // 
            Col_3.AutoSize = true;
            Col_3.Font = new Font("Segoe UI", 12F);
            Col_3.Location = new Point(11, 165);
            Col_3.Name = "Col_3";
            Col_3.Size = new Size(73, 21);
            Col_3.TabIndex = 3;
            Col_3.Text = "ItemType";
            // 
            // Col_4
            // 
            Col_4.AutoSize = true;
            Col_4.Font = new Font("Segoe UI", 12F);
            Col_4.Location = new Point(11, 205);
            Col_4.Name = "Col_4";
            Col_4.Size = new Size(44, 21);
            Col_4.TabIndex = 4;
            Col_4.Text = "Price";
            // 
            // Col_5
            // 
            Col_5.AutoSize = true;
            Col_5.Font = new Font("Segoe UI", 12F);
            Col_5.Location = new Point(12, 241);
            Col_5.Name = "Col_5";
            Col_5.Size = new Size(89, 21);
            Col_5.TabIndex = 5;
            Col_5.Text = "Description";
            // 
            // EnterBtn
            // 
            EnterBtn.Location = new Point(12, 312);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(52, 23);
            EnterBtn.TabIndex = 6;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = true;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // Col1_Txt
            // 
            Col1_Txt.Location = new Point(127, 46);
            Col1_Txt.Name = "Col1_Txt";
            Col1_Txt.Size = new Size(120, 23);
            Col1_Txt.TabIndex = 7;
            // 
            // Col2_Txt
            // 
            Col2_Txt.Location = new Point(128, 82);
            Col2_Txt.Multiline = true;
            Col2_Txt.Name = "Col2_Txt";
            Col2_Txt.Size = new Size(120, 69);
            Col2_Txt.TabIndex = 8;
            // 
            // Col5_Txt
            // 
            Col5_Txt.Location = new Point(128, 241);
            Col5_Txt.Multiline = true;
            Col5_Txt.Name = "Col5_Txt";
            Col5_Txt.Size = new Size(152, 84);
            Col5_Txt.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(310, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 289);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // OutputBtn
            // 
            OutputBtn.Location = new Point(513, 267);
            OutputBtn.Name = "OutputBtn";
            OutputBtn.Size = new Size(75, 23);
            OutputBtn.TabIndex = 13;
            OutputBtn.Text = "SaveJSON";
            OutputBtn.UseVisualStyleBackColor = true;
            OutputBtn.Click += OutputBtn_Click;
            // 
            // InputBtn
            // 
            InputBtn.Location = new Point(513, 229);
            InputBtn.Name = "InputBtn";
            InputBtn.Size = new Size(75, 23);
            InputBtn.TabIndex = 14;
            InputBtn.Text = "LoadJSON";
            InputBtn.UseVisualStyleBackColor = true;
            InputBtn.Click += InputBtn_Click;
            // 
            // Col4_Txt
            // 
            Col4_Txt.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            Col4_Txt.Location = new Point(126, 203);
            Col4_Txt.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Col4_Txt.Name = "Col4_Txt";
            Col4_Txt.Size = new Size(120, 23);
            Col4_Txt.TabIndex = 16;
            Col4_Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // listRemoveBtn
            // 
            listRemoveBtn.Location = new Point(513, 85);
            listRemoveBtn.Name = "listRemoveBtn";
            listRemoveBtn.Size = new Size(75, 23);
            listRemoveBtn.TabIndex = 17;
            listRemoveBtn.Text = "Remove";
            listRemoveBtn.UseVisualStyleBackColor = true;
            listRemoveBtn.Click += listRemoveBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(513, 45);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 18;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Enabled = false;
            prevBtn.Location = new Point(70, 312);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(52, 23);
            prevBtn.TabIndex = 19;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Col3_Txt
            // 
            Col3_Txt.FormattingEnabled = true;
            Col3_Txt.Items.AddRange(new object[] { "seed", "corp", "food", "fish", "other" });
            Col3_Txt.Location = new Point(125, 165);
            Col3_Txt.Name = "Col3_Txt";
            Col3_Txt.Size = new Size(121, 23);
            Col3_Txt.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Seed", "Corp", "Food", "Fish", "Other" });
            comboBox1.Location = new Point(310, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Col_0
            // 
            Col_0.AutoSize = true;
            Col_0.Font = new Font("Segoe UI", 12F);
            Col_0.Location = new Point(12, 14);
            Col_0.Name = "Col_0";
            Col_0.Size = new Size(25, 21);
            Col_0.TabIndex = 22;
            Col_0.Text = "ID";
            // 
            // Col0_Txt
            // 
            Col0_Txt.Location = new Point(127, 14);
            Col0_Txt.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Col0_Txt.Name = "Col0_Txt";
            Col0_Txt.Size = new Size(120, 23);
            Col0_Txt.TabIndex = 24;
            Col0_Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(606, 46);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(187, 289);
            listBox2.TabIndex = 25;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All", "Seed", "Corp", "Food", "Fish", "Other" });
            comboBox2.Location = new Point(606, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 26;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 357);
            Controls.Add(comboBox2);
            Controls.Add(listBox2);
            Controls.Add(Col0_Txt);
            Controls.Add(Col_0);
            Controls.Add(comboBox1);
            Controls.Add(Col3_Txt);
            Controls.Add(prevBtn);
            Controls.Add(editBtn);
            Controls.Add(listRemoveBtn);
            Controls.Add(Col4_Txt);
            Controls.Add(InputBtn);
            Controls.Add(OutputBtn);
            Controls.Add(listBox1);
            Controls.Add(Col5_Txt);
            Controls.Add(Col2_Txt);
            Controls.Add(Col1_Txt);
            Controls.Add(EnterBtn);
            Controls.Add(Col_5);
            Controls.Add(Col_4);
            Controls.Add(Col_3);
            Controls.Add(Col_2);
            Controls.Add(Col_1);
            Name = "MainForm";
            Text = "JSON Convert";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Col4_Txt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Col0_Txt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Col_1;
        private Label Col_2;
        private Label Col_3;
        private Label Col_4;
        private Label Col_5;
        private Button EnterBtn;
        private TextBox Col1_Txt;
        private TextBox Col2_Txt;
        private TextBox Col5_Txt;
        private ListBox listBox1;
        private Button OutputBtn;
        private Button InputBtn;
        private NumericUpDown Col4_Txt;
        private Button listRemoveBtn;
        private Button editBtn;
        private Button prevBtn;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboBox Col3_Txt;
        private ComboBox comboBox1;
        private Label Col_0;
        private NumericUpDown Col0_Txt;
        private ListBox listBox2;
        private ComboBox comboBox2;
    }
}
