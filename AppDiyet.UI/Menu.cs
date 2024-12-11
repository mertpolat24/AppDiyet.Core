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

namespace AppDiyet.UI
{
    public partial class Menu : Form
    {
        OgunListeleme OgunListeleme = new OgunListeleme();
        IUserService user = new UserService();
        IMealsService meals = new MealsService();
        int userId = 0;
        public Menu(int id)
        {
            userId = id;
            InitializeComponent();

            idLabel.Text = userId.ToString();
            var loginUser = user.GetById(userId);
            var weight = loginUser.Weight;
            textBox1.Text = weight.ToString("F2");

            var fullName = user.GetById(userId);
            nameLabel.Text = fullName.FirstName + " " + fullName.LastName;

            var calories = user.CalculateCalories(userId);
            textBox2.Text = calories.ToString("F2");

            var proteins = user.CalculateProteins(userId);
            textBox3.Text = proteins.ToString("F2");

            var kalanKalori = user.RemainingCalories(userId);
            textBox4.Text = kalanKalori.ToString("F2");

            var lst = meals.MealFood(userId);
            ogunDataGridView.DataSource = lst;

        }
        private void gesmisOgunler_Click(object sender, EventArgs e)
        {
            OgunListeleme ogunListeleme = new OgunListeleme();
            ogunListeleme.Show();
            this.Hide();
        }

        private void ogunEkleButton_Click(object sender, EventArgs e)
        {
            OgunCrud ogunCrud = new OgunCrud();
            ogunCrud.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Guncelleme guncelleme = new Guncelleme(userId);
            guncelleme.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ogunDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
