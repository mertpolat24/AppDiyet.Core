namespace AppDiyet.UI
{
    partial class FoodMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            kategoriComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            yemekListBox = new ListBox();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            miktarComboBox = new ComboBox();
            miktarTextBox = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 98);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 122);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 148);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(141, 197);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(180, 23);
            textBox6.TabIndex = 0;
            // 
            // kategoriComboBox
            // 
            kategoriComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriComboBox.FormattingEnabled = true;
            kategoriComboBox.Location = new Point(141, 72);
            kategoriComboBox.Margin = new Padding(3, 2, 3, 2);
            kategoriComboBox.Name = "kategoriComboBox";
            kategoriComboBox.Size = new Size(180, 23);
            kategoriComboBox.TabIndex = 1;
            kategoriComboBox.SelectedIndexChanged += kategoriComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label1.Location = new Point(28, 100);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 2;
            label1.Text = "Yemek Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label2.Location = new Point(42, 76);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label3.Location = new Point(49, 151);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 2;
            label3.Text = "Protein";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label4.Location = new Point(59, 125);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 2;
            label4.Text = "Kalori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label5.Location = new Point(37, 203);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 2;
            label5.Text = "Açıklama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label6.Location = new Point(54, 176);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 2;
            label6.Text = "Miktar";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(535, 314);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(635, 314);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(741, 314);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 3;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(613, 72);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 198);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // yemekListBox
            // 
            yemekListBox.FormattingEnabled = true;
            yemekListBox.ItemHeight = 15;
            yemekListBox.Location = new Point(384, 72);
            yemekListBox.Margin = new Padding(3, 2, 3, 2);
            yemekListBox.Name = "yemekListBox";
            yemekListBox.Size = new Size(210, 199);
            yemekListBox.TabIndex = 5;
            yemekListBox.SelectedIndexChanged += yemekListBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 55);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 6;
            label7.Text = "Yemek Listesi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(613, 55);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 6;
            label8.Text = "Yemek Fotoğrafı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pizza2go_banners;
            pictureBox2.Location = new Point(-2, 284);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(483, 412);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // miktarComboBox
            // 
            miktarComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            miktarComboBox.FormattingEnabled = true;
            miktarComboBox.Location = new Point(262, 172);
            miktarComboBox.Margin = new Padding(3, 2, 3, 2);
            miktarComboBox.Name = "miktarComboBox";
            miktarComboBox.Size = new Size(59, 23);
            miktarComboBox.TabIndex = 1;
            // 
            // miktarTextBox
            // 
            miktarTextBox.Location = new Point(141, 172);
            miktarTextBox.Margin = new Padding(3, 2, 3, 2);
            miktarTextBox.Name = "miktarTextBox";
            miktarTextBox.Size = new Size(66, 23);
            miktarTextBox.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label9.Location = new Point(213, 173);
            label9.Name = "label9";
            label9.Size = new Size(42, 19);
            label9.TabIndex = 2;
            label9.Text = "Birim";
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(859, 490);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(yemekListBox);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(miktarComboBox);
            Controls.Add(kategoriComboBox);
            Controls.Add(textBox4);
            Controls.Add(miktarTextBox);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FoodMenu";
            Text = "FoodMenu";
            Load += FoodMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private ComboBox kategoriComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private ListBox yemekListBox;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private ComboBox miktarComboBox;
        private TextBox miktarTextBox;
        private Label label9;
    }
}