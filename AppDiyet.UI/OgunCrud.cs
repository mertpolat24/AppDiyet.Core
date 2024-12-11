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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDiyet.UI
{
    public partial class OgunCrud : Form
    {
        IMealsService mealsService = new MealsService();
        IFoodService foodService = new FoodService();
        int userId = 0;
        public OgunCrud(int id)
        {
            InitializeComponent();
            userId = id;
            GetAllFoods();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void GetAllFoods()
        {
            var foodsList = Enum.GetValues(typeof(PortionType));
            comboBox1.DataSource = foodsList;
            
            
            var portions = foodService.CalculatePortionsProteins(userId,porsiyonNumericUpDown.Value,foodsList.ToString());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void porsiyonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
