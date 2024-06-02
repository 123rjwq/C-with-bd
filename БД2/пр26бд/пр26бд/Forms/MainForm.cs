using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using пр26бд.Forms;

namespace пр26бд
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            this.Hide();
            adminWindow.ShowDialog();
        }

        
        private void btnTovari_Click(object sender, EventArgs e)
        {
            GoodsForm goodsForm = new GoodsForm();
            goodsForm.ShowDialog();
            this.Close();
        }
    }
}
