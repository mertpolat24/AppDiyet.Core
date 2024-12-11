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
        string newPassword = string.Empty;
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
            try
            {
                var loginUser2 = user.GetById(userId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedUser = user.GetById(userId);

                if (updatedUser != null)
                {
                    if (sifreTextBox.Text != updatedUser.Password && sifreTekrarTextBox.Text != updatedUser.Password)
                    {
                        if (sifreTekrarTextBox.Text == sifreTextBox.Text)
                        {
                            newPassword = sifreTextBox.Text;

                        }
                        else
                            throw new Exception("Şifreler Uyuşmuyor!");
                    }
                    else
                        throw new Exception("Yeni Şifreinz Eski Şifrenizle Aynı Olamaz");
                    if (newPassword == string.Empty)
                    {
                        newPassword = updatedUser.Password;
                    }
                    var yas = (int)yasNumericUpDown.Value;
                    var boy = (double)boyNumericUpDown.Value;
                    var kilo = (double)kiloNumericUpDown.Value;
                    var aktivite = (Activities)aktiviteDuzeyiComboBox.SelectedItem;
                    var hedef = (Purpose)hedefComboBox.SelectedItem;
                    var ogun = (int)ogunSayisiNumericUpDown.Value;
                    var hedefKilo = (double)hedefKiloNumericUpDown.Value;

                    bool guncellendiMi = user.Update(userId, newPassword, yas, boy, kilo, aktivite, hedef, ogun, hedefKilo, labelImage.Text);
                    if (guncellendiMi == true)
                    {
                        MessageBox.Show("Bilgiler başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu menu = new Menu(userId);
                        menu.Show();
                        this.Close();
                    }
                    else
                        throw new Exception("Güncelleme başarısız!");
                }
                else
                {
                    throw new Exception("Kullanıcı bulunamadı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imageSelectButton_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void imageSelectButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                MessageBox.Show("Seçilen dosya: " + imagePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullaniciPictureBox.ImageLocation = imagePath;
                labelImage.Text = imagePath;
            }
        }
    }
}
