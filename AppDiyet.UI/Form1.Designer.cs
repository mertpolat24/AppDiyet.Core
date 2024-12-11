namespace AppDiyet.UI
{
    partial class Form1
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
            label4 = new Label();
            girisButton = new Button();
            kayitOlButton = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            sifreTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(542, 90);
            label4.Name = "label4";
            label4.Size = new Size(428, 56);
            label4.TabIndex = 19;
            label4.Text = "\n\"Kalorini say, sağlığını koru, hayatını değiştir!\"";
            // 
            // girisButton
            // 
            girisButton.BackColor = Color.LightGreen;
            girisButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            girisButton.Location = new Point(709, 378);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(94, 29);
            girisButton.TabIndex = 17;
            girisButton.Text = "Giriş Yap";
            girisButton.UseVisualStyleBackColor = false;
            girisButton.Click += girisButton_Click_1;
            // 
            // kayitOlButton
            // 
            kayitOlButton.BackColor = Color.LightGreen;
            kayitOlButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kayitOlButton.Location = new Point(709, 554);
            kayitOlButton.Name = "kayitOlButton";
            kayitOlButton.Size = new Size(94, 29);
            kayitOlButton.TabIndex = 16;
            kayitOlButton.Text = "Kayıt Ol";
            kayitOlButton.UseVisualStyleBackColor = false;
            kayitOlButton.Click += kayitOlButton_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(700, 335);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(663, 513);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 14;
            label3.Text = "Hala Bir Hesabın Yok Mu?";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.Window;
            emailTextBox.Location = new Point(588, 212);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(337, 27);
            emailTextBox.TabIndex = 13;
            emailTextBox.Text = "user1@gmail.com";
            // 
            // sifreTextBox
            // 
            sifreTextBox.BorderStyle = BorderStyle.FixedSingle;
            sifreTextBox.Location = new Point(588, 284);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.Size = new Size(337, 27);
            sifreTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(734, 252);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 11;
            label2.Text = "Şifre ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(706, 175);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 10;
            label1.Text = "Kullanıcı Adı ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_woman_runner_running_jumpingsilhouette_athletic_photo_png_image_13643437;
            pictureBox1.Location = new Point(-364, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(888, 840);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(982, 653);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(girisButton);
            Controls.Add(kayitOlButton);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(sifreTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "KayitOl";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button girisButton;
        private Button kayitOlButton;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox emailTextBox;
        private TextBox sifreTextBox;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
