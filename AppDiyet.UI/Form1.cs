using AppDiyet.Service.Abstracts;
using AppDiyet.Service.Services;

namespace AppDiyet.UI
{
    public partial class Form1 : Form
    {
        IUserService userService = new UserService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            Form1 kayitOl = new Form1();
            kayitOl.Show();
            this.Hide();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {


        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void girisButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(sifreTextBox.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanlarý Doldurun!");
                return;
            }
            else
            {
                var user = userService.GetByEmail(emailTextBox.Text);

                if (user is null || sifreTextBox.Text != user.Password)
                {
                    MessageBox.Show("Kullanýcý bulunamadý vey Þifreniz Yanlýþ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var id = user.Id;
                    Menu menu = new Menu(id);
                    menu.Show();
                    this.Hide();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kayitOlButton_Click_1(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }
    }
}