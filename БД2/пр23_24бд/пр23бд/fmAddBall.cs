using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр23бд
{
    public partial class fmAddBall : Form
    {
        public fmAddBall()
        {
            InitializeComponent();
        }

        private void fmAddBall_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.decanatDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Ball". При необходимости она может быть перемещена или удалена.
            this.ballTableAdapter.Fill(this.decanatDataSet.Ball);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Ball". При необходимости она может быть перемещена или удалена.
            this.ballTableAdapter.Fill(this.decanatDataSet.Ball);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.decanatDataSet.Subject);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow nRow = decanatDataSet.Ball.NewRow(); //создем новую строку
            //заполняем данными
            nRow[1] = cmbSubject.SelectedValue.ToString();
            nRow[2] = cmbStudent.SelectedValue.ToString();
            nRow[3] = txtBall.Text;
            nRow[4] = cmdVid.Text;
            this.decanatDataSet.Ball.Rows.Add(nRow); // добабляем строку в таблицу
            tableAdapterManager.UpdateAll(this.decanatDataSet);
            decanatDataSet.Ball.AcceptChanges();
            MessageBox.Show("Данные сохранены");
        }
    }
}
