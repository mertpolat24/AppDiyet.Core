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

namespace AppDiyet.UI
{
    public partial class FoodMenu : Form
    {
        IFoodCategoriesService foodCategories = new FoodCategoriesService();
        public FoodMenu()
        {
            InitializeComponent();
            MiktarVerileriniYukle();
            KategoriVerileriniYukle();
        }
        public void KategoriVerileriniYukle()
        {
            var kategoriler = foodCategories.GetAll().Select(x => x.Name).ToList();
            kategoriComboBox.DataSource=kategoriler;


        }
        public void MiktarVerileriniYukle()
        {
            var protionType = Enum.GetValues(typeof(PortionType));
            miktarComboBox.DataSource = protionType;
        }
        private void FoodMenu_Load(object sender, EventArgs e)
        {

        }

        private void yemekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yemekler = foodCategories.GetAll().Select(x => x.Name);

            yemekListBox.Items.Clear();

            foreach (var yemek in yemekler)
            {
                yemekListBox.Items.Add(yemek);
            }
        }

        private void kategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
