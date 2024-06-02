using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр26бд
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string logUser = TxtBoxLogin.Text;
            string passUser = TxtBoxPassword.Text;
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open();
                string query = $"SELECT * FROM [dbo].[User] WHERE [Login] = '{logUser}' AND [Password]='{passUser}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Вы успешно вошли!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Owner = this;
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Выйти", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x == DialogResult.Cancel)
            { e.Cancel = true; }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    internal class Connection
    {
        internal static string con = "Data Source = WINGSTONG\\SQLEXPRESS; " +
            "Initial Catalog = EnglishStore;" +
            "Integrated Security = True";
    }

}
