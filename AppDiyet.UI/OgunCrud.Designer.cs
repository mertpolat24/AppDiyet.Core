﻿namespace AppDiyet.UI
{
    partial class OgunCrud
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
            listBox1 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            porsiyonNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)porsiyonNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(35, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(255, 484);
            listBox1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Beige;
            button5.Location = new Point(828, 224);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 2;
            button5.Text = "Hesapla";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Beige;
            button6.Location = new Point(645, 570);
            button6.Name = "button6";
            button6.Size = new Size(131, 29);
            button6.TabIndex = 2;
            button6.Text = "Öğün Kaydet";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Beige;
            button7.Location = new Point(791, 570);
            button7.Name = "button7";
            button7.Size = new Size(131, 29);
            button7.TabIndex = 2;
            button7.Text = "Yeni Yemek";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(645, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 187);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(497, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 145);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Yemekler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(730, 145);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Porsiyon";
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.Location = new Point(497, 570);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 2;
            button1.Text = "Öğün Ekle";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(497, 438);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(497, 491);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(497, 331);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(497, 384);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 27);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(356, 338);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 8;
            label3.Text = "Toplam Kalori :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(356, 391);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "Toplam Protein :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(356, 445);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Kategorisi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(356, 498);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 8;
            label6.Text = "Açıklama :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // porsiyonNumericUpDown
            // 
            porsiyonNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            porsiyonNumericUpDown.Location = new Point(730, 177);
            porsiyonNumericUpDown.Name = "porsiyonNumericUpDown";
            porsiyonNumericUpDown.Size = new Size(192, 27);
            porsiyonNumericUpDown.TabIndex = 10;
            porsiyonNumericUpDown.ValueChanged += porsiyonNumericUpDown_ValueChanged;
            // 
            // OgunCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(982, 653);
            Controls.Add(porsiyonNumericUpDown);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Name = "OgunCrud";
            Text = "OgunCrud";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)porsiyonNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown porsiyonNumericUpDown;
    }
}