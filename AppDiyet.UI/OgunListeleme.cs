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
        public OgunListeleme()
        {
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
            var list = mealsService.GetByMeals(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            listBox1.Text = list.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgunList();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
