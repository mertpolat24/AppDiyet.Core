﻿namespace AppDiyet.UI
{
    partial class Menu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gesmisOgunler = new Button();
            ogunEkleButton = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            idLabel = new Label();
            ogunDataGridView = new DataGridView();
            nameLabel2 = new Label();
            bilgiDuzenleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ogunDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(27, 329);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Güncel Kilo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(27, 368);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 0;
            label2.Text = "Aldığı Kalori :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(27, 410);
            label3.Name = "label3";
            label3.Size = new Size(146, 28);
            label3.TabIndex = 0;
            label3.Text = "Aldığı Protein :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(27, 449);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 0;
            label4.Text = "Kalan Kalori :";
            // 
            // gesmisOgunler
            // 
            gesmisOgunler.BackColor = Color.LightGreen;
            gesmisOgunler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gesmisOgunler.Location = new Point(549, 524);
            gesmisOgunler.Name = "gesmisOgunler";
            gesmisOgunler.Size = new Size(186, 29);
            gesmisOgunler.TabIndex = 1;
            gesmisOgunler.Text = "Geçmiş Öğünler";
            gesmisOgunler.UseVisualStyleBackColor = false;
            gesmisOgunler.Click += gesmisOgunler_Click;
            // 
            // ogunEkleButton
            // 
            ogunEkleButton.BackColor = Color.LightGreen;
            ogunEkleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ogunEkleButton.Location = new Point(761, 524);
            ogunEkleButton.Name = "ogunEkleButton";
            ogunEkleButton.Size = new Size(186, 29);
            ogunEkleButton.TabIndex = 1;
            ogunEkleButton.Text = "Öğün Ekle";
            ogunEkleButton.UseVisualStyleBackColor = false;
            ogunEkleButton.Click += ogunEkleButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.NavajoWhite;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(108, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(211, 330);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(211, 368);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(211, 411);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(211, 453);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(925, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(22, 20);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id";
            idLabel.Click += idLabel_Click;
            // 
            // ogunDataGridView
            // 
            ogunDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogunDataGridView.Location = new Point(549, 83);
            ogunDataGridView.Name = "ogunDataGridView";
            ogunDataGridView.RowHeadersWidth = 51;
            ogunDataGridView.Size = new Size(398, 403);
            ogunDataGridView.TabIndex = 7;
            ogunDataGridView.CellContentClick += ogunDataGridView_CellContentClick;
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new Point(108, 60);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new Size(36, 20);
            nameLabel2.TabIndex = 9;
            nameLabel2.Text = "isim";
            nameLabel2.Click += nameLabel2_Click;
            // 
            // bilgiDuzenleButton
            // 
            bilgiDuzenleButton.BackColor = Color.LightGreen;
            bilgiDuzenleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bilgiDuzenleButton.Location = new Point(108, 223);
            bilgiDuzenleButton.Name = "bilgiDuzenleButton";
            bilgiDuzenleButton.Size = new Size(136, 31);
            bilgiDuzenleButton.TabIndex = 10;
            bilgiDuzenleButton.Text = "Kullanıcı Bilgileri";
            bilgiDuzenleButton.UseVisualStyleBackColor = false;
            bilgiDuzenleButton.Click += bilgiDuzenleButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(982, 653);
            Controls.Add(bilgiDuzenleButton);
            Controls.Add(nameLabel2);
            Controls.Add(ogunDataGridView);
            Controls.Add(idLabel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(ogunEkleButton);
            Controls.Add(gesmisOgunler);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ogunDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button gesmisOgunler;
        private Button ogunEkleButton;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label idLabel;
        private DataGridView ogunDataGridView;
        private Label nameLabel;
        private Label nameLabel2;
        private Button bilgiDuzenleButton;
    }
}