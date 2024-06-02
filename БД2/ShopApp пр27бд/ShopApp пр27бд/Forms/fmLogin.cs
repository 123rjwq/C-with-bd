using ShopApp_пр27бд.Forms;
using ShopApp_пр27бд.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShopApp_пр27бд
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPassword.Text;
            try
            { // загрузка всех пользователей из БД в список
                List<User> users = Shop_liissaEntities.GetContext().Users.ToList();
                //попытка найти пользователя с указанным паролем и логином 
                //если такого пользователя нет то = null
                User user = users.FirstOrDefault(p => p.UserName  == username && p.Password == password);
                if (user != null)
                {
                    MainWindow mainWindow = new MainWindow(user.Role, user.UserName);
                    mainWindow.Owner = this;
                    this.Hide();
                    txtPassword.Clear();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool showPassword = false;
        private void picBoxVisible_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            txtPassword.UseSystemPasswordChar = !showPassword;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Вы действительно хотите закрыть приложение?",
                "Выйти", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (x == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
