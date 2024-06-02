using ShopApp_пр27бд.Models;
using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopApp_пр27бд.Forms
{
    public partial class MainWindow : Form
    {
        int _itemcount = 0;
        public MainWindow(string userRole, string name)
        {
            InitializeComponent();
            stripRole.Text += userRole;
            stripName.Text += name;

            LoadAndInitData();

            var CategoryType = Shop_liissaEntities.GetContext().Categories.OrderBy(p => p.CategoryName).ToList();
            CategoryType.Insert(0, new Category
            {
                CategoryName = "Все типы"    
            });
            comboCategory.DataSource = CategoryType;
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "id_Category";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void LoadAndInitData()
        {
            // получаем текущие даннные из бд
            var currentGoods = Shop_liissaEntities.GetContext().Goods.Join
                (Shop_liissaEntities.GetContext().Categories, p => p.Categoty_id, t => t.id_Category,
                (p, t) => new { p.GoodName, p.Price, p.Picture, p.Descriptions, t.CategoryName }).ToList();
            
            // в качестве источника данных присваиваем список данных
            dvgGoods.DataSource = currentGoods;

            // заголовки
            dvgGoods.Columns[0].HeaderText = "Название";
            dvgGoods.Columns[1].HeaderText = "Цена";
            dvgGoods.Columns[2].HeaderText = "Изображение";
            dvgGoods.Columns[3].HeaderText = "Описание";
            dvgGoods.Columns[4].HeaderText = "Категория";

            //колво товара
            _itemcount = dvgGoods.Rows.Count;
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount}";
        }

        private void UpdateData()
        {
            // получаем текущие даннные из бд
            var currentGoods = Shop_liissaEntities.GetContext().Goods.Join
                (Shop_liissaEntities.GetContext().Categories, p => p.Categoty_id, t => t.id_Category,
                (p, t) => new { p.GoodName, p.Price, p.Picture, p.Descriptions, t.CategoryName, p.Categoty_id }).ToList();

            // выбор только тех товаров, которые принадлежат данной категории
            if (comboCategory.SelectedIndex > 0)
                currentGoods = currentGoods.Where(y => y.Categoty_id == (comboCategory.SelectedItem as Category).id_Category).ToList();

            // выбор тех товаров, в названии которых есть поисковая строка
            currentGoods = currentGoods.Where(p => p.GoodName.ToLower().Contains(txtNameGood.Text.ToLower())).ToList();

            // сортировка
            if (comboSort.SelectedIndex >= 0)
            {
                //сортировка по возрастанию цены
                if (comboSort.SelectedIndex == 0)
                    currentGoods = currentGoods.OrderBy(p => p.Price).ToList();

                //сортировка по убыванию цены
                if (comboSort.SelectedIndex == 1)
                    currentGoods = currentGoods.OrderByDescending(p => p.Price).ToList();
            }



            //в качестве источника данных пписваиваем список данных
            dvgGoods.DataSource = currentGoods;
            //отображение колва записей
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount}";
        }

        private void txtNameGood_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dvgGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = dvgGoods[0, e.RowIndex].Value.ToString();
            labelNameGood.Text = dvgGoods[0, e.RowIndex].Value.ToString();
            labelPrice.Text = dvgGoods[1, e.RowIndex].Value.ToString();
            pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory()
                + @"\Images\" + dvgGoods[2, e.RowIndex].Value.ToString());
        }

        private void labelNameGood_Click(object sender, EventArgs e)
        {

        }
    }
}
