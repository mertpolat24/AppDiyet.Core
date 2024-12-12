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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDiyet.UI
{
    public partial class FoodMenu : Form
    {
        IFoodCategoriesService foodCategories = new FoodCategoriesService();
        IFoodService foodService = new FoodService();
        public FoodMenu()
        {
            InitializeComponent();
            MiktarVerileriniYukle();
            KategoriVerileriniYukle();
        }
        public void KategoriVerileriniYukle()
        {
            var kategoriler = foodCategories.GetAll().Select(x => x.Name).ToList();
            kategoriComboBox.DataSource = kategoriler;


        }
        public void MiktarVerileriniYukle()
        {
            var protionType = Enum.GetValues(typeof(PortionType)).Cast<PortionType>().ToList();
            miktarComboBox.DataSource = protionType;
        }
        private void FoodMenu_Load(object sender, EventArgs e)
        {

        }

        private void yemekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yemekListBox.SelectedItem != null)
            {
                string selectedFoodName = yemekListBox.SelectedItem.ToString();

                var yemek = foodService.GetAll().FirstOrDefault(f => f.Name == selectedFoodName);

                if (yemek != null)
                {
                    yemekAdıTextBox.Text = yemek.Name;
                    kaloriTextBox.Text = yemek.Calories.ToString();
                    proteinTextBox.Text = yemek.Proteins.ToString();
                    miktarComboBox.SelectedItem = yemek.PortionType;
                    aciklamaTextBox.Text = yemek.Description;
                }
            }
        }

        private void kategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = kategoriComboBox.SelectedItem.ToString();

            var category = foodCategories.GetAll().FirstOrDefault(c => c.Name == selectedCategory);

            if (category != null && category.Foods != null)
            {
                var yemekler = category.Foods.Select(f => f.Name).ToList();

                yemekListBox.Items.Clear();
                foreach (var yemek in yemekler)
                {
                    yemekListBox.Items.Add(yemek);
                }
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void miktarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void miktarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string foodName = yemekAdıTextBox.Text;
            double calories = double.Parse(kaloriTextBox.Text);
            double proteins = double.Parse(proteinTextBox.Text);
            string aciklama = aciklamaTextBox.Text;
            double miktar = (double)miktarNumericUpDown.Value;
            PortionType portionType = (PortionType)miktarComboBox.SelectedItem;
            string selectedCategory = kategoriComboBox.SelectedItem.ToString();

            var category = foodCategories.GetAll().FirstOrDefault(c => c.Name == selectedCategory);

            if (category != null)
            {
                foodService.Create(foodName, calories, proteins, miktar, aciklama, label.Text, portionType);
                MessageBox.Show("Yeni yemek eklendi!");

                kategoriComboBox_SelectedIndexChanged(sender, e);
            }
        }

        private void yemekPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                MessageBox.Show("Seçilen dosya: " + imagePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yemekPictureBox.ImageLocation = imagePath;
                label.Text = imagePath;
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string selectedFoodName = yemekListBox.SelectedItem.ToString();

            var yemek = foodService.GetAll().FirstOrDefault(f => f.Name == selectedFoodName);

            if (yemek != null)
            {
                foodService.Delete(yemek.Id);
                MessageBox.Show("Yemek silindi!");
                kategoriComboBox_SelectedIndexChanged(sender, e);
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {

        }

        private void miktarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
