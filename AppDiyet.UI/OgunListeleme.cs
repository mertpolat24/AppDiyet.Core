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
    public partial class OgunListeleme : Form
    {
        IMealsService mealsService = new MealsService();
        int userId = 0;
        public OgunListeleme(int id)
        {
            userId = id;
            InitializeComponent();
            OgunList();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void OgunList()
        {
            if (button4.Enabled)
            {
                var list = mealsService.GetByMeals(userId, bitisTarihiDTP.Value, baslangicTarihiDTP.Value);
                gecmisOgunlerDataGridView.DataSource = list;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void gecmisOgunlerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
