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
            AddColumn = new Button();
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
            ((System.ComponentModel.ISupportInitialize)Col4_Txt).BeginInit();
            SuspendLayout();
            // 
            // AddColumn
            // 
            AddColumn.BackColor = SystemColors.Window;
            AddColumn.Enabled = false;
            AddColumn.Location = new Point(12, 12);
            AddColumn.Name = "AddColumn";
            AddColumn.Size = new Size(91, 23);
            AddColumn.TabIndex = 0;
            AddColumn.Text = "Add Column";
            AddColumn.UseVisualStyleBackColor = false;
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
            Col_2.Location = new Point(12, 88);
            Col_2.Name = "Col_2";
            Col_2.Size = new Size(50, 21);
            Col_2.TabIndex = 2;
            Col_2.Text = "Detail";
            // 
            // Col_3
            // 
            Col_3.AutoSize = true;
            Col_3.Font = new Font("Segoe UI", 12F);
            Col_3.Location = new Point(12, 175);
            Col_3.Name = "Col_3";
            Col_3.Size = new Size(73, 21);
            Col_3.TabIndex = 3;
            Col_3.Text = "ItemType";
            // 
            // Col_4
            // 
            Col_4.AutoSize = true;
            Col_4.Font = new Font("Segoe UI", 12F);
            Col_4.Location = new Point(12, 215);
            Col_4.Name = "Col_4";
            Col_4.Size = new Size(44, 21);
            Col_4.TabIndex = 4;
            Col_4.Text = "Price";
            // 
            // Col_5
            // 
            Col_5.AutoSize = true;
            Col_5.Font = new Font("Segoe UI", 12F);
            Col_5.Location = new Point(12, 251);
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
            Col2_Txt.Location = new Point(127, 86);
            Col2_Txt.Multiline = true;
            Col2_Txt.Name = "Col2_Txt";
            Col2_Txt.Size = new Size(120, 69);
            Col2_Txt.TabIndex = 8;
            // 
            // Col5_Txt
            // 
            Col5_Txt.Location = new Point(137, 251);
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
            Col4_Txt.Location = new Point(127, 213);
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
            Col3_Txt.Location = new Point(126, 175);
            Col3_Txt.Name = "Col3_Txt";
            Col3_Txt.Size = new Size(121, 23);
            Col3_Txt.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 357);
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
            Controls.Add(AddColumn);
            Name = "MainForm";
            Text = "JSON Convert";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Col4_Txt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddColumn;
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
    }
}
