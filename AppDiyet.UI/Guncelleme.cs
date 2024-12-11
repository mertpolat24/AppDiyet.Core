using AppDiyet.Core.Enums;
using AppDiyet.Service.Abstracts;
using AppDiyet.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDiyet.UI
{
    public partial class Guncelleme : Form
    {

        IUserService user = new UserService();
        int userId = 0;

        public Guncelleme(int id)
        {
            userId = id;
            InitializeComponent();
            AktiviteVerileriniYukle();
            HedefVerileriniYukle();
            var loginUser = user.GetById(userId);
            kiloNumericUpDown.Value = (decimal)loginUser.Weight;
            hedefKiloNumericUpDown.Value = (decimal)loginUser.TargetWeight;
            ogunSayisiNumericUpDown.Value = loginUser.MealsCount;
            boyNumericUpDown.Value = (decimal)loginUser.Lenght;
            yasNumericUpDown.Value = (int)loginUser.Age;
            kullaniciPictureBox.ImageLocation = loginUser.ImagePath;

        }



        public void AktiviteVerileriniYukle()
        {
            var activities = Enum.GetValues(typeof(Activities));
            aktiviteDuzeyiComboBox.DataSource = activities;
        }
        public void HedefVerileriniYukle()
        {
            var purpose = Enum.GetValues(typeof(Purpose));
            hedefComboBox.DataSource = purpose;
            hedefComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void aktiviteDuzeyiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktiviteDuzeyiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void kiloNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void degistirButton_Click(object sender, EventArgs e)
        {
            var loginUser2 = user.GetById(userId);
            if (sifreTekrarTextBox.Text == sifreTextBox.Text)
            {
                loginUser2.Password = sifreTextBox.Text;
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            var updatedUser = user.GetById(userId);

            if (updatedUser != null)
            {

                user.Update(userId, updatedUser.Password, (int)yasNumericUpDown.Value, (double)boyNumericUpDown.Value, (double)kiloNumericUpDown.Value, (Activities)aktiviteDuzeyiComboBox.SelectedItem, (Purpose)hedefComboBox.SelectedItem, (int)ogunSayisiNumericUpDown.Value, (double)hedefKiloNumericUpDown.Value,labelImage.Text);

                MessageBox.Show("Bilgiler başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!string.IsNullOrEmpty(sifreTextBox.Text))
                {
                    if (sifreTextBox.Text == sifreTekrarTextBox.Text)
                    {
                        updatedUser.Password = sifreTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imageSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Continue)
            {
                string imagePath = openFileDialog.FileName;
                MessageBox.Show("Seçilen dosya: " + imagePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullaniciPictureBox.ImageLocation = imagePath;
                labelImage.Text = imagePath;
            }
        }
    }
}
