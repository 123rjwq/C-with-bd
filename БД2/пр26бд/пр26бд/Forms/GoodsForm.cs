using System;
using System.Drawing;
using System.Windows.Forms;

namespace пр26бд.Forms
{
    public partial class GoodsForm : Form
    {
        private DataGridViewColumn Col;
        public GoodsForm()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "englishStoreDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.englishStoreDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "englishStoreDataSetGood.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.englishStoreDataSetGood.Product);
            toolStripStatusLabel1.Text = $"Всего товаров: {dataGridViewGood.Rows.Count - 1}";
        }

        
        private void btnSort_Click(object sender, EventArgs e)
        {
            Col = new DataGridViewColumn();
            Col = Col_name;
            if (radioButtonV.Checked)
                dataGridViewGood.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridViewGood.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)   
        {
            //Перебирает все ячейки таблицы и устанавливает в них белый цыет фона
            // и черный цвет текста, те отменяет рез-ты предыдущего поиска
            for (int i = 0; i < dataGridViewGood.ColumnCount - 1; i++)
            {
                for(int j = 0; j < dataGridViewGood.RowCount - 1; j++)
                {
                    dataGridViewGood[i, j].Style.BackColor = Color.White;
                    dataGridViewGood[i, j].Style.ForeColor = Color.Black;                   
                }
            }

            for (int i = 0; i < dataGridViewGood.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewGood.RowCount - 1; j++)
                {
                    if (dataGridViewGood[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridViewGood[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridViewGood[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void dataGridViewGood_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewGood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridViewGood.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewGood.RowCount - 1; j++)
                {
                    if (dataGridViewGood.Rows[j].Cells["Col_isActive"].Value.ToString() == "True") 
                    {
                        dataGridViewGood[i, j].Style.BackColor = Color.White;
                    }
                    else
                    {
                        dataGridViewGood[i, j].Style.BackColor = Color.Gray;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedManufacturerID = (int)comboBox1.SelectedValue;
            productBindingSource.Filter = "Manufacturer='" + selectedManufacturerID.ToString() + "'";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            productBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            productBindingSource.AddNew();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            productBindingSource.EndEdit();
            productTableAdapter.Update(this.englishStoreDataSetGood.Product);
        }
    }
}
