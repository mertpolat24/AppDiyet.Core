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

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            var cinsiyet = Gender.Male;
            if (string.IsNullOrWhiteSpace(adTextBox.Text) || string.IsNullOrWhiteSpace(soyadTextBox.Text) ||
                string.IsNullOrWhiteSpace(mailAdresiTextBox.Text) || string.IsNullOrWhiteSpace(sifreTextBox.Text))
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var mevcutKullanici = userService.GetByEmail(mailAdresiTextBox.Text);
            if (mevcutKullanici != null)
            {
                MessageBox.Show("Bu e-posta zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sifreTextBox.Text.Length < 10 || !sifreTextBox.Text.Any(char.IsUpper) ||
        !sifreTextBox.Text.Any(ch => !char.IsLetterOrDigit(ch)) || !sifreTextBox.Text.Any(char.IsDigit))
                MessageBox.Show("Şifre en az 10 karakter uzunluğunda, bir büyük harf, bir rakam ve bir özel karakter içermelidir.",
            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (erkekCheckBox.Checked)
            {
                cinsiyet = Gender.Male;
            }
            else
            {
                cinsiyet = Gender.Female;
            }
            string asdasd = string.Empty;
            bool sonuc = userService.Create(adTextBox.Text, soyadTextBox.Text, mailAdresiTextBox.Text, sifreTextBox.Text, (int)yasNumericUpDown.Value, (double)boyNumericUpDown.Value, (double)kiloNumericUpDown.Value, cinsiyet, (Purpose)hedefComboBox.SelectedItem, (Activities)aktiviteDuzeyiComboBox.SelectedItem, (int)ogunSayisiNumericUpDown.Value, (double)hedefKiloNumericUpDown.Value,asdasd);

            if (sonuc)
            {
                MessageBox.Show("kullanıcı başarıyla kaydedildi!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("kullanıcı kaydedilemedi. lütfen tekrar deneyin.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
