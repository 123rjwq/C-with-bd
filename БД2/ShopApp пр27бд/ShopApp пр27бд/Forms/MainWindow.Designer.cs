namespace ShopApp_пр27бд.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtNameGood = new System.Windows.Forms.TextBox();
            this.labelCountGood = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.dvgGoods = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureGood = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelNameGood = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGoods)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(1043, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог товаров";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopApp_пр27бд.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboSort);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboCategory);
            this.panel2.Controls.Add(this.txtNameGood);
            this.panel2.Controls.Add(this.labelCountGood);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 124);
            this.panel2.TabIndex = 1;
            // 
            // comboSort
            // 
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboSort.Location = new System.Drawing.Point(635, 50);
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(226, 28);
            this.comboSort.TabIndex = 6;
            this.comboSort.SelectedIndexChanged += new System.EventHandler(this.comboSort_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(465, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Сортировка по";
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(241, 51);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(205, 28);
            this.comboCategory.TabIndex = 4;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // txtNameGood
            // 
            this.txtNameGood.Location = new System.Drawing.Point(469, 11);
            this.txtNameGood.Name = "txtNameGood";
            this.txtNameGood.Size = new System.Drawing.Size(392, 26);
            this.txtNameGood.TabIndex = 3;
            this.txtNameGood.TextChanged += new System.EventHandler(this.txtNameGood_TextChanged);
            // 
            // labelCountGood
            // 
            this.labelCountGood.AutoSize = true;
            this.labelCountGood.Location = new System.Drawing.Point(17, 92);
            this.labelCountGood.Name = "labelCountGood";
            this.labelCountGood.Size = new System.Drawing.Size(158, 20);
            this.labelCountGood.TabIndex = 2;
            this.labelCountGood.Text = "Результат запроса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите категорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите наименование товара для поиска:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripName,
            this.stripRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1197, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripName
            // 
            this.stripName.Name = "stripName";
            this.stripName.Size = new System.Drawing.Size(135, 25);
            this.stripName.Text = "Пользователь: ";
            // 
            // stripRole
            // 
            this.stripRole.Name = "stripRole";
            this.stripRole.Size = new System.Drawing.Size(67, 25);
            this.stripRole.Text = "Статус:";
            // 
            // dvgGoods
            // 
            this.dvgGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGoods.Dock = System.Windows.Forms.DockStyle.Left;
            this.dvgGoods.Location = new System.Drawing.Point(0, 199);
            this.dvgGoods.Name = "dvgGoods";
            this.dvgGoods.RowHeadersWidth = 62;
            this.dvgGoods.RowTemplate.Height = 28;
            this.dvgGoods.Size = new System.Drawing.Size(811, 383);
            this.dvgGoods.TabIndex = 4;
            this.dvgGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgGoods_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureGood);
            this.panel3.Controls.Add(this.labelPrice);
            this.panel3.Controls.Add(this.labelNameGood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(850, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 383);
            this.panel3.TabIndex = 5;
            // 
            // pictureGood
            // 
            this.pictureGood.Image = ((System.Drawing.Image)(resources.GetObject("pictureGood.Image")));
            this.pictureGood.Location = new System.Drawing.Point(57, 143);
            this.pictureGood.Name = "pictureGood";
            this.pictureGood.Size = new System.Drawing.Size(206, 176);
            this.pictureGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGood.TabIndex = 2;
            this.pictureGood.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(53, 86);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(63, 23);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена";
            // 
            // labelNameGood
            // 
            this.labelNameGood.AutoSize = true;
            this.labelNameGood.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameGood.Location = new System.Drawing.Point(53, 25);
            this.labelNameGood.Name = "labelNameGood";
            this.labelNameGood.Size = new System.Drawing.Size(184, 23);
            this.labelNameGood.TabIndex = 0;
            this.labelNameGood.Text = "Название товара";
            this.labelNameGood.Click += new System.EventHandler(this.labelNameGood_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 614);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dvgGoods);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGoods)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtNameGood;
        private System.Windows.Forms.Label labelCountGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripName;
        private System.Windows.Forms.ToolStripStatusLabel stripRole;
        private System.Windows.Forms.DataGridView dvgGoods;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureGood;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelNameGood;
    }
}