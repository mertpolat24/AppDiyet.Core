namespace AppDiyet.UI
{
    partial class Guncelleme
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
            label11 = new Label();
            label10 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            kaydetButton = new Button();
            aktiviteDuzeyiComboBox = new ComboBox();
            yasTextBox = new TextBox();
            hedefComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label9 = new Label();
            kiloNumericUpDown = new NumericUpDown();
            hedefKiloNumericUpDown = new NumericUpDown();
            ogunSayisiNumericUpDown = new NumericUpDown();
            boyNumericUpDown = new NumericUpDown();
            yasNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kiloNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hedefKiloNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ogunSayisiNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yasNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(30, 123);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 62;
            label11.Text = "Hedef Kilo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(30, 74);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 61;
            label10.Text = "Aktivite Duzeyi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(30, 199);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 59;
            label6.Text = "Boy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(30, 174);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 58;
            label8.Text = "Öğün Sayısı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(30, 224);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 56;
            label7.Text = "Yaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(30, 98);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 55;
            label5.Text = "Kilo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(30, 148);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 60;
            label4.Text = "Hedef";
            // 
            // kaydetButton
            // 
            kaydetButton.BackColor = Color.DarkTurquoise;
            kaydetButton.Location = new Point(146, 256);
            kaydetButton.Margin = new Padding(3, 2, 3, 2);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(82, 22);
            kaydetButton.TabIndex = 50;
            kaydetButton.Text = "Güncelle";
            kaydetButton.UseVisualStyleBackColor = false;
            // 
            // aktiviteDuzeyiComboBox
            // 
            aktiviteDuzeyiComboBox.FormattingEnabled = true;
            aktiviteDuzeyiComboBox.Items.AddRange(new object[] { "Masa başı bir işte çalışıyorum, fazla hareket etmiyorum.", "Masa başı bir işte çalışıyorum, hafif egzersizler yapıyorum.", "Az hareket ettiğim bir işte çalışıyorum, yoğun egzersizler yapıyorum.", "Çok aktif olduğum bir işim var, orta düzeyde egzersiz yapıyorum.", "Çok aktif olduğum bir işim var, yoğun düzeyde egzersiz yapıyorum.", "" });
            aktiviteDuzeyiComboBox.Location = new Point(146, 68);
            aktiviteDuzeyiComboBox.Margin = new Padding(3, 2, 3, 2);
            aktiviteDuzeyiComboBox.Name = "aktiviteDuzeyiComboBox";
            aktiviteDuzeyiComboBox.Size = new Size(496, 23);
            aktiviteDuzeyiComboBox.TabIndex = 48;
            aktiviteDuzeyiComboBox.SelectedIndexChanged += aktiviteDuzeyiComboBox_SelectedIndexChanged;
            // 
            // yasTextBox
            // 
            yasTextBox.Location = new Point(175, 362);
            yasTextBox.Margin = new Padding(3, 2, 3, 2);
            yasTextBox.Name = "yasTextBox";
            yasTextBox.Size = new Size(164, 23);
            yasTextBox.TabIndex = 47;
            // 
            // hedefComboBox
            // 
            hedefComboBox.FormattingEnabled = true;
            hedefComboBox.Location = new Point(146, 145);
            hedefComboBox.Margin = new Padding(3, 2, 3, 2);
            hedefComboBox.Name = "hedefComboBox";
            hedefComboBox.Size = new Size(496, 23);
            hedefComboBox.TabIndex = 44;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Recep_Ivedik_7_3_e1670719324142;
            pictureBox1.Location = new Point(704, 68);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Location = new Point(756, 210);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 67;
            button1.Text = "Değiştir";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 341);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 68;
            label1.Text = "Yeni Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 367);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 68;
            label2.Text = "Yeni Şifre Tekrar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 336);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(32, 303);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 69;
            label3.Text = "Şifre Değişikliği \r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(256, 386);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 24);
            button2.TabIndex = 70;
            button2.Text = "Değiştir";
            button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(30, 20);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 71;
            label9.Text = "Kişi Bilgileri";
            // 
            // kiloNumericUpDown
            // 
            kiloNumericUpDown.Location = new Point(146, 96);
            kiloNumericUpDown.Name = "kiloNumericUpDown";
            kiloNumericUpDown.Size = new Size(120, 23);
            kiloNumericUpDown.TabIndex = 72;
            // 
            // hedefKiloNumericUpDown
            // 
            hedefKiloNumericUpDown.Location = new Point(146, 121);
            hedefKiloNumericUpDown.Name = "hedefKiloNumericUpDown";
            hedefKiloNumericUpDown.Size = new Size(120, 23);
            hedefKiloNumericUpDown.TabIndex = 72;
            // 
            // ogunSayisiNumericUpDown
            // 
            ogunSayisiNumericUpDown.Location = new Point(146, 172);
            ogunSayisiNumericUpDown.Name = "ogunSayisiNumericUpDown";
            ogunSayisiNumericUpDown.Size = new Size(120, 23);
            ogunSayisiNumericUpDown.TabIndex = 72;
            // 
            // boyNumericUpDown
            // 
            boyNumericUpDown.Location = new Point(146, 199);
            boyNumericUpDown.Name = "boyNumericUpDown";
            boyNumericUpDown.Size = new Size(120, 23);
            boyNumericUpDown.TabIndex = 72;
            // 
            // yasNumericUpDown
            // 
            yasNumericUpDown.Location = new Point(146, 228);
            yasNumericUpDown.Name = "yasNumericUpDown";
            yasNumericUpDown.Size = new Size(120, 23);
            yasNumericUpDown.TabIndex = 72;
            // 
            // Guncelleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(859, 490);
            Controls.Add(yasNumericUpDown);
            Controls.Add(boyNumericUpDown);
            Controls.Add(ogunSayisiNumericUpDown);
            Controls.Add(hedefKiloNumericUpDown);
            Controls.Add(kiloNumericUpDown);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(kaydetButton);
            Controls.Add(aktiviteDuzeyiComboBox);
            Controls.Add(textBox1);
            Controls.Add(yasTextBox);
            Controls.Add(hedefComboBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Guncelleme";
            Text = "Guncelleme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kiloNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hedefKiloNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ogunSayisiNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yasNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Label label10;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button kaydetButton;
        private ComboBox aktiviteDuzeyiComboBox;
        private TextBox yasTextBox;
        private ComboBox hedefComboBox;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private Label label9;
        private NumericUpDown kiloNumericUpDown;
        private NumericUpDown hedefKiloNumericUpDown;
        private NumericUpDown ogunSayisiNumericUpDown;
        private NumericUpDown boyNumericUpDown;
        private NumericUpDown yasNumericUpDown;
    }
}