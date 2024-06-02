namespace пр23бд
{
    partial class fmGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmGroup));
            System.Windows.Forms.Label name_groupLabel;
            System.Windows.Forms.Label kursLabel;
            this.decanatDataSet = new пр23бд.DecanatDataSet();
            this.groupaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupaTableAdapter = new пр23бд.DecanatDataSetTableAdapters.GroupaTableAdapter();
            this.tableAdapterManager = new пр23бд.DecanatDataSetTableAdapters.TableAdapterManager();
            this.groupaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.groupaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_groupTextBox = new System.Windows.Forms.TextBox();
            this.kursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            name_groupLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupaBindingNavigator)).BeginInit();
            this.groupaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // decanatDataSet
            // 
            this.decanatDataSet.DataSetName = "DecanatDataSet";
            this.decanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupaBindingSource
            // 
            this.groupaBindingSource.DataMember = "Groupa";
            this.groupaBindingSource.DataSource = this.decanatDataSet;
            // 
            // groupaTableAdapter
            // 
            this.groupaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BallTableAdapter = null;
            this.tableAdapterManager.GroupaTableAdapter = this.groupaTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = пр23бд.DecanatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupaBindingNavigator
            // 
            this.groupaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupaBindingNavigator.BindingSource = this.groupaBindingSource;
            this.groupaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.groupaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.groupaBindingNavigatorSaveItem});
            this.groupaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupaBindingNavigator.Name = "groupaBindingNavigator";
            this.groupaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupaBindingNavigator.Size = new System.Drawing.Size(456, 33);
            this.groupaBindingNavigator.TabIndex = 0;
            this.groupaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // groupaBindingNavigatorSaveItem
            // 
            this.groupaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupaBindingNavigatorSaveItem.Image")));
            this.groupaBindingNavigatorSaveItem.Name = "groupaBindingNavigatorSaveItem";
            this.groupaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.groupaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.groupaBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupaBindingNavigatorSaveItem_Click);
            // 
            // name_groupLabel
            // 
            name_groupLabel.AutoSize = true;
            name_groupLabel.Location = new System.Drawing.Point(75, 61);
            name_groupLabel.Name = "name_groupLabel";
            name_groupLabel.Size = new System.Drawing.Size(61, 20);
            name_groupLabel.TabIndex = 1;
            name_groupLabel.Text = "Группа";
            // 
            // name_groupTextBox
            // 
            this.name_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupaBindingSource, "Name_group", true));
            this.name_groupTextBox.Location = new System.Drawing.Point(173, 61);
            this.name_groupTextBox.Name = "name_groupTextBox";
            this.name_groupTextBox.Size = new System.Drawing.Size(163, 26);
            this.name_groupTextBox.TabIndex = 2;
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Location = new System.Drawing.Point(75, 120);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(43, 20);
            kursLabel.TabIndex = 3;
            kursLabel.Text = "Курс";
            // 
            // kursNumericUpDown
            // 
            this.kursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.groupaBindingSource, "Kurs", true));
            this.kursNumericUpDown.Location = new System.Drawing.Point(173, 120);
            this.kursNumericUpDown.Name = "kursNumericUpDown";
            this.kursNumericUpDown.Size = new System.Drawing.Size(163, 26);
            this.kursNumericUpDown.TabIndex = 4;
            this.kursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 193);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursNumericUpDown);
            this.Controls.Add(name_groupLabel);
            this.Controls.Add(this.name_groupTextBox);
            this.Controls.Add(this.groupaBindingNavigator);
            this.Name = "fmGroup";
            this.Text = "Справочник Группы";
            this.Load += new System.EventHandler(this.fmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupaBindingNavigator)).EndInit();
            this.groupaBindingNavigator.ResumeLayout(false);
            this.groupaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DecanatDataSet decanatDataSet;
        private System.Windows.Forms.BindingSource groupaBindingSource;
        private DecanatDataSetTableAdapters.GroupaTableAdapter groupaTableAdapter;
        private DecanatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton groupaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox name_groupTextBox;
        private System.Windows.Forms.NumericUpDown kursNumericUpDown;
    }
}