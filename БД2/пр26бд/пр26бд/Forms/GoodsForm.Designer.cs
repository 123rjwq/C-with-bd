namespace пр26бд.Forms
{
    partial class GoodsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.dataGridViewGood = new System.Windows.Forms.DataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishStoreDataSetGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishStoreDataSetGood = new пр26бд.EnglishStoreDataSetGood();
            this.productTableAdapter = new пр26бд.EnglishStoreDataSetGoodTableAdapters.ProductTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.radioButtonU = new System.Windows.Forms.RadioButton();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishStoreDataSet = new пр26бд.EnglishStoreDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.manufacturerTableAdapter = new пр26бд.EnglishStoreDataSetTableAdapters.ManufacturerTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSetGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSetGood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGood
            // 
            this.dataGridViewGood.AutoGenerateColumns = false;
            this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_name,
            this.Col_img,
            this.Col_facture,
            this.Col_isActive,
            this.Col_price});
            this.dataGridViewGood.DataSource = this.productBindingSource;
            this.dataGridViewGood.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGood.Name = "dataGridViewGood";
            this.dataGridViewGood.RowHeadersWidth = 62;
            this.dataGridViewGood.RowTemplate.Height = 28;
            this.dataGridViewGood.Size = new System.Drawing.Size(715, 362);
            this.dataGridViewGood.TabIndex = 0;
            this.dataGridViewGood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewGood_CellFormatting);
            this.dataGridViewGood.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewGood_UserDeletingRow);
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "ID";
            this.Col_Id.HeaderText = "Код товара";
            this.Col_Id.MinimumWidth = 8;
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Width = 150;
            // 
            // Col_name
            // 
            this.Col_name.DataPropertyName = "Name";
            this.Col_name.HeaderText = "Имя товара";
            this.Col_name.MinimumWidth = 8;
            this.Col_name.Name = "Col_name";
            this.Col_name.Width = 150;
            // 
            // Col_img
            // 
            this.Col_img.DataPropertyName = "Image";
            this.Col_img.HeaderText = "Фото";
            this.Col_img.MinimumWidth = 8;
            this.Col_img.Name = "Col_img";
            this.Col_img.Width = 150;
            // 
            // Col_facture
            // 
            this.Col_facture.DataPropertyName = "Manufacturer";
            this.Col_facture.HeaderText = "Производитель";
            this.Col_facture.MinimumWidth = 8;
            this.Col_facture.Name = "Col_facture";
            this.Col_facture.Width = 150;
            // 
            // Col_isActive
            // 
            this.Col_isActive.DataPropertyName = "IsActive";
            this.Col_isActive.HeaderText = "Наличие";
            this.Col_isActive.MinimumWidth = 8;
            this.Col_isActive.Name = "Col_isActive";
            this.Col_isActive.Width = 150;
            // 
            // Col_price
            // 
            this.Col_price.DataPropertyName = "Price";
            this.Col_price.HeaderText = "Цена";
            this.Col_price.MinimumWidth = 8;
            this.Col_price.Name = "Col_price";
            this.Col_price.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.englishStoreDataSetGoodBindingSource;
            // 
            // englishStoreDataSetGoodBindingSource
            // 
            this.englishStoreDataSetGoodBindingSource.DataSource = this.englishStoreDataSetGood;
            this.englishStoreDataSetGoodBindingSource.Position = 0;
            // 
            // englishStoreDataSetGood
            // 
            this.englishStoreDataSetGood.DataSetName = "EnglishStoreDataSetGood";
            this.englishStoreDataSetGood.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.radioButtonU);
            this.groupBox1.Controls.Add(this.radioButtonV);
            this.groupBox1.Location = new System.Drawing.Point(742, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по наименованию";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSort.Location = new System.Drawing.Point(232, 57);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(40, 40);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "O";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // radioButtonU
            // 
            this.radioButtonU.AutoSize = true;
            this.radioButtonU.Location = new System.Drawing.Point(26, 65);
            this.radioButtonU.Name = "radioButtonU";
            this.radioButtonU.Size = new System.Drawing.Size(134, 24);
            this.radioButtonU.TabIndex = 1;
            this.radioButtonU.TabStop = true;
            this.radioButtonU.Text = "По убыванию";
            this.radioButtonU.UseVisualStyleBackColor = true;
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Location = new System.Drawing.Point(26, 35);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(159, 24);
            this.radioButtonV.TabIndex = 0;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "По возрастанию";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(742, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(10, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя товара";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(742, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 81);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтрация";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "Manufacturer", true));
            this.comboBox1.DataSource = this.manufacturerBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.englishStoreDataSet;
            // 
            // englishStoreDataSet
            // 
            this.englishStoreDataSet.DataSetName = "EnglishStoreDataSet";
            this.englishStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Редактировать запись";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(483, 389);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(244, 47);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Удалить запись";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(752, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PowderBlue;
            this.button5.Location = new System.Drawing.Point(752, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 47);
            this.button5.TabIndex = 8;
            this.button5.Text = "Назад на главную форму";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(886, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 46);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 490);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewGood);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSetGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSetGood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGood;
        private System.Windows.Forms.BindingSource englishStoreDataSetGoodBindingSource;
        private EnglishStoreDataSetGood englishStoreDataSetGood;
        private System.Windows.Forms.BindingSource productBindingSource;
        private EnglishStoreDataSetGoodTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonU;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnSort;
        private EnglishStoreDataSet englishStoreDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private EnglishStoreDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_facture;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_price;
        private System.Windows.Forms.Button btnClear;
    }
}