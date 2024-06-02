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
    public partial class fmStudent : Form
    {
        public fmStudent()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.decanatDataSet);

        }

        private void fmStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Groupa". При необходимости она может быть перемещена или удалена.
            this.groupaTableAdapter.Fill(this.decanatDataSet.Groupa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.decanatDataSet.Student);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.studentBindingSource.RemoveCurrent();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
