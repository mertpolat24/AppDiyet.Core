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
        public Menu()
        {
            InitializeComponent();
        }
        OgunListeleme OgunListeleme = new OgunListeleme();
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
        }
    }
}
