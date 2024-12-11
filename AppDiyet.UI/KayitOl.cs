using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using AppDiyet.Service.Abstracts;
using AppDiyet.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppDiyet.UI
{
    public partial class KayitOl : Form
    {
        IUserService userService = new UserService();

        Users user = null;

        public KayitOl()
        {
            InitializeComponent();
            HedefComboBoxVerileriniYukle();
            hedefComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AktiviteComboBoxVerileriniYukle();
            aktiviteDuzeyiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void HedefComboBoxVerileriniYukle()
        { 
            hedefComboBox.DataSource = Enum.GetValues(typeof(Purpose));
        }
        public void AktiviteComboBoxVerileriniYukle()
        {
            var liste = Enum.GetNames(typeof(Activities)).ToList();
            aktiviteDuzeyiComboBox.DataSource = liste;
        }

        public void KullaniciKaydet()
        {


        }

        private void adTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailAdresiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hedefComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ogunSayisiNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aktiviteDuzeyiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void erkekCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kadinCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kiloNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void boyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void hedefKiloNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void imageSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                MessageBox.Show("Seçilen dosya: " + imagePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox.ImageLocation = imagePath;
                labelImage.Text = imagePath;
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(adTextBox.Text) || string.IsNullOrWhiteSpace(soyadTextBox.Text) ||
                    string.IsNullOrWhiteSpace(mailAdresiTextBox.Text) || string.IsNullOrWhiteSpace(sifreTextBox.Text))
                    throw new Exception("Lütfen tüm alanları doldurun!");



                string ad = adTextBox.Text;
                string soyad = soyadTextBox.Text;
                string mail = mailAdresiTextBox.Text;
                string sifre = sifreTextBox.Text;
                int yas = (int)yasNumericUpDown.Value;
                double boy = (double)boyNumericUpDown.Value;
                double kilo = (double)kiloNumericUpDown.Value;
                Purpose purpose = (Purpose)hedefComboBox.SelectedIndex;
                Activities activities = (Activities)aktiviteDuzeyiComboBox.SelectedIndex;
                int ogunSayisi = (int)ogunSayisiNumericUpDown.Value;
                int hedefKilo = (int)hedefKiloNumericUpDown.Value;
                Gender cinsiyet = Gender.Male;
                string resimYolu = labelImage.Text;
                if (erkekCheckBox.Checked)
                {
                    cinsiyet = Gender.Male;
                }
                else if (kadinCheckBox.Checked)
                {
                    cinsiyet = Gender.Female;
                }
                else
                    throw new Exception("Lütfen Cinsiyet Seçimi Yapınız!");

                if (yas > 65 || yas < 18)
                    throw new Exception("Bu Uygulamayı 18 Yaşından Küçükler ve 65 Yaşından Büyükler Kullanamaz");

                bool sonuc = userService.Create(ad, soyad, mail, sifre, yas, boy, kilo, cinsiyet, purpose, activities, ogunSayisi, hedefKilo, resimYolu);

                if (sonuc)
                {
                    MessageBox.Show("kullanıcı başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    throw new Exception("kullanıcı kaydedilemedi. lütfen tekrar deneyin.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
