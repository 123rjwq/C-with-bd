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

namespace пр23бд
{
    public partial class fmAvtor : Form
    {
        public string fioUser;
        public string statusUser;
        public fmAvtor()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string logUser = txtLogin.Text;
            string passUser = txtPassword.Text;
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open();
                string query = $"SELECT [id_user], [login], [password], [status], [fio] FROM [dbo].[user] WHERE [login] ='{logUser}' AND [password] = '{passUser}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if(reader.HasRows == false)
                {
                    MessageBox.Show("Такого аккаунта нет!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    if(reader.Read())
                    {
                        fioUser = reader[4].ToString();
                        statusUser = reader[3].ToString();
                        MessageBox.Show("Вы успешно вошли как " + statusUser, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                reader.Close();
                conn.Close();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
