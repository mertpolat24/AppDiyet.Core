using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using AppDiyet.Service.Abstracts;
using AppDiyet.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDiyet.UI
{
    public partial class OgunListeleme : Form
    {
        IMealsService mealsService = new MealsService();
        int userId = 0;
        public OgunListeleme(int id)
        {
            userId = id;
            InitializeComponent();

            var lst = mealsService.MealFood(userId);
            gecmisOgunlerDataGridView.DataSource = lst;
        }

        private void gecmisOgunlerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void baslangicTarihiDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bitisTarihiDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void filtreleButton_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = baslangicTarihiDTP.Value;
            DateTime bitisTarihi = bitisTarihiDTP.Value;

            //var liste = mealsService.GetByMeals(userId, new DateTime(2024-11-03), DateTime.Now);

            //var gosterilecekListe = liste.Select(x => new
            //{
            //    MealName = ((MealCategories)x.MealName).ToString(), 
            //    UserId = userId, 
            //    CreateDate = x.CreateDate

            //}).ToList();
            //gecmisOgunlerDataGridView.AutoGenerateColumns = true;
            //gecmisOgunlerDataGridView.DataSource = gosterilecekListe;
            var liste = mealsService.GetByMeals(userId, baslangicTarihi, bitisTarihi).ToList();

            if (liste == null || !liste.Any())
            {
                MessageBox.Show("Veritabanında belirtilen tarihler için öğün bulunamadı.");
                return;
            }
            foreach (var item in liste)
            {
                Debug.WriteLine($"MealName: {item.MealName}, CreateDate: {item.CreateDate}");
            }
        }
    }
}
