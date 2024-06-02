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
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace пр23бд
{
    public partial class fmVed : Form
    {
        public fmVed()
        {
            InitializeComponent();
        }

        private void fmVed_Load(object sender, EventArgs e)
        {
            // Создать объект подключения
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open(); // Открыть подключение
                string query = "SELECT [dbo].[Student].[FIO], [dbo].[Groupa].[Name_group]," +
                                "[dbo].[Subject].[Name_subject], [dbo].[Ball].[ball], [dbo].[Ball].[vid_control]" +
                                "FROM [dbo].[Student], [dbo].[Groupa], [dbo].[Subject], [dbo].[Ball]" +
                                "WHERE ([dbo].[Student].[id_group]=[dbo].[Groupa].[id_group]) AND" +
                                "([dbo].[Ball].[id_student]=[dbo].[Student].[id_student]) AND" +
                                "([dbo].[Ball].[id_subject]=[dbo].[Subject].[id_subject])";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                { MessageBox.Show("Данные не найдены!"); }
                else
                {
                    while (reader.Read())
                    {
                        dataGridStudent.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);  
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
        }

        private DataGridViewColumn Col;

        private void btnSort_Click(object sender, EventArgs e)
        {
            Col = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = ColumnFIO;
                    break;
                case 1:
                    Col = ColumnGroup;
                    break;
                case 2:
                    Col = ColumnSubject;
                    break;
                case 3:
                    Col = ColumnBall;
                    break;
                case 4:
                    Col = ColumnControl;
                    break;
            }
            if (radioButtonV.Checked)
                dataGridStudent.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridStudent.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var app = new Excel.Application();
            app.SheetsInNewWorkbook = 1;
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = app.Worksheets.Item[1];
            worksheet.Name = "Ведомость";

            for (int i = 0; i < dataGridStudent.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridStudent.Columns[i].HeaderCell.Value;

                for (int j = 0; j < dataGridStudent.Rows.Count; j++)
                {
                    worksheet.Cells[j + 2, i + 1] = dataGridStudent[i, j].Value;
                }
            }


            app.Visible = true;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmAddBall fmAddBall = new fmAddBall();
            fmAddBall.Show();
        }

        private void dataGridStudent_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
