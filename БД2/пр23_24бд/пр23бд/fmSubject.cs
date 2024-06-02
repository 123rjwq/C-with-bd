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
    public partial class fmSubject : Form
    {
        public fmSubject()
        {
            InitializeComponent();
        }

        private void subjectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.decanatDataSet);

        }

        private void fmSubject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.decanatDataSet.Subject);

        }

        private void btnfiltr_Click(object sender, EventArgs e)
        {
            subjectBindingSource.Filter = "semestr='" + comboBox1.Text + "'";
        }

        private void btnvse_Click(object sender, EventArgs e)
        {
            subjectBindingSource.Filter = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.subjectBindingSource.RemoveCurrent();
            }
            else if (dialogResult == DialogResult.No)
            { 
                return;
            }
        }
    }
}
