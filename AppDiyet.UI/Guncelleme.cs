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
    public partial class Guncelleme : Form
    {

        IUserService user = new UserService();
        int userId = 0;
        public Guncelleme(int id)
        {
            userId = id;
            InitializeComponent();
            AktiviteVerileriniYukle();
            HedefVerileriniYukle();
        }

        public void AktiviteVerileriniYukle()
        {
            var activities = Enum.GetValues(typeof(Activities));
            aktiviteDuzeyiComboBox.DataSource = activities;
        }
        public void HedefVerileriniYukle()
        {
            var purpose = Enum.GetValues(typeof(Purpose));
            hedefComboBox.DataSource = purpose;
            hedefComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void aktiviteDuzeyiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktiviteDuzeyiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
