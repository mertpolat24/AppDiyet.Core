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
            yemekAdıTextBox = new TextBox();
            kaloriTextBox = new TextBox();
            proteinTextBox = new TextBox();
            aciklamaTextBox = new TextBox();
            kategoriComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ekleButton = new Button();
            silButton = new Button();
            guncelleButton = new Button();
            yemekPictureBox = new PictureBox();
            yemekListBox = new ListBox();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            miktarComboBox = new ComboBox();
            label9 = new Label();
            label = new Label();
            miktarNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)yemekPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miktarNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // yemekAdıTextBox
            // 
            yemekAdıTextBox.Location = new Point(141, 98);
            yemekAdıTextBox.Margin = new Padding(3, 2, 3, 2);
            yemekAdıTextBox.Name = "yemekAdıTextBox";
            yemekAdıTextBox.Size = new Size(180, 23);
            yemekAdıTextBox.TabIndex = 0;
            // 
            // kaloriTextBox
            // 
            kaloriTextBox.Location = new Point(141, 122);
            kaloriTextBox.Margin = new Padding(3, 2, 3, 2);
            kaloriTextBox.Name = "kaloriTextBox";
            kaloriTextBox.Size = new Size(180, 23);
            kaloriTextBox.TabIndex = 0;
            kaloriTextBox.TextChanged += textBox3_TextChanged;
            // 
            // proteinTextBox
            // 
            proteinTextBox.Location = new Point(141, 148);
            proteinTextBox.Margin = new Padding(3, 2, 3, 2);
            proteinTextBox.Name = "proteinTextBox";
            proteinTextBox.Size = new Size(180, 23);
            proteinTextBox.TabIndex = 0;
            proteinTextBox.TextChanged += textBox4_TextChanged;
            // 
            // aciklamaTextBox
            // 
            aciklamaTextBox.Location = new Point(141, 197);
            aciklamaTextBox.Margin = new Padding(3, 2, 3, 2);
            aciklamaTextBox.Name = "aciklamaTextBox";
            aciklamaTextBox.Size = new Size(180, 23);
            aciklamaTextBox.TabIndex = 0;
            aciklamaTextBox.TextChanged += textBox6_TextChanged;
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
            // ekleButton
            // 
            ekleButton.BackColor = Color.YellowGreen;
            ekleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ekleButton.Location = new Point(535, 314);
            ekleButton.Margin = new Padding(3, 2, 3, 2);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(82, 22);
            ekleButton.TabIndex = 3;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = false;
            ekleButton.Click += ekleButton_Click;
            // 
            // silButton
            // 
            silButton.BackColor = Color.YellowGreen;
            silButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            silButton.Location = new Point(635, 314);
            silButton.Margin = new Padding(3, 2, 3, 2);
            silButton.Name = "silButton";
            silButton.Size = new Size(82, 22);
            silButton.TabIndex = 3;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = false;
            silButton.Click += silButton_Click;
            // 
            // guncelleButton
            // 
            guncelleButton.BackColor = Color.YellowGreen;
            guncelleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guncelleButton.Location = new Point(741, 314);
            guncelleButton.Margin = new Padding(3, 2, 3, 2);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(82, 22);
            guncelleButton.TabIndex = 3;
            guncelleButton.Text = "Güncelle";
            guncelleButton.UseVisualStyleBackColor = false;
            guncelleButton.Click += guncelleButton_Click;
            // 
            // yemekPictureBox
            // 
            yemekPictureBox.Location = new Point(613, 72);
            yemekPictureBox.Margin = new Padding(3, 2, 3, 2);
            yemekPictureBox.Name = "yemekPictureBox";
            yemekPictureBox.Size = new Size(210, 198);
            yemekPictureBox.TabIndex = 4;
            yemekPictureBox.TabStop = false;
            yemekPictureBox.Click += yemekPictureBox_Click;
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
            miktarComboBox.SelectedIndexChanged += miktarComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            label9.Location = new Point(214, 173);
            label9.Name = "label9";
            label9.Size = new Size(42, 19);
            label9.TabIndex = 2;
            label9.Text = "Birim";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(604, 27);
            label.Name = "label";
            label.Size = new Size(0, 15);
            label.TabIndex = 8;
            // 
            // miktarNumericUpDown
            // 
            miktarNumericUpDown.Location = new Point(141, 172);
            miktarNumericUpDown.Name = "miktarNumericUpDown";
            miktarNumericUpDown.Size = new Size(76, 23);
            miktarNumericUpDown.TabIndex = 9;
            miktarNumericUpDown.ValueChanged += miktarNumericUpDown_ValueChanged;
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(859, 490);
            Controls.Add(miktarNumericUpDown);
            Controls.Add(label);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(yemekListBox);
            Controls.Add(yemekPictureBox);
            Controls.Add(guncelleButton);
            Controls.Add(silButton);
            Controls.Add(ekleButton);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(miktarComboBox);
            Controls.Add(kategoriComboBox);
            Controls.Add(proteinTextBox);
            Controls.Add(aciklamaTextBox);
            Controls.Add(kaloriTextBox);
            Controls.Add(yemekAdıTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FoodMenu";
            Text = "FoodMenu";
            Load += FoodMenu_Load;
            ((System.ComponentModel.ISupportInitialize)yemekPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)miktarNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox yemekAdıTextBox;
        private TextBox kaloriTextBox;
        private TextBox proteinTextBox;
        private TextBox aciklamaTextBox;
        private ComboBox kategoriComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button ekleButton;
        private Button silButton;
        private Button guncelleButton;
        private PictureBox yemekPictureBox;
        private ListBox yemekListBox;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private ComboBox miktarComboBox;
        private Label label9;
        private Label label;
        private NumericUpDown miktarNumericUpDown;
    }
}