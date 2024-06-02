namespace пр23бд
{
    partial class fmVed
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
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.ColumnFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonU = new System.Windows.Forms.RadioButton();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFIO,
            this.ColumnGroup,
            this.ColumnSubject,
            this.ColumnBall,
            this.ColumnControl});
            this.dataGridStudent.Location = new System.Drawing.Point(13, 13);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.RowHeadersWidth = 62;
            this.dataGridStudent.RowTemplate.Height = 28;
            this.dataGridStudent.Size = new System.Drawing.Size(811, 350);
            this.dataGridStudent.TabIndex = 0;
            this.dataGridStudent.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridStudent_UserDeletingRow);
            // 
            // ColumnFIO
            // 
            this.ColumnFIO.HeaderText = "ФИО";
            this.ColumnFIO.MinimumWidth = 8;
            this.ColumnFIO.Name = "ColumnFIO";
            this.ColumnFIO.Width = 150;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.HeaderText = "Группа";
            this.ColumnGroup.MinimumWidth = 8;
            this.ColumnGroup.Name = "ColumnGroup";
            this.ColumnGroup.Width = 150;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Предмет";
            this.ColumnSubject.MinimumWidth = 8;
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.Width = 150;
            // 
            // ColumnBall
            // 
            this.ColumnBall.HeaderText = "Оценка";
            this.ColumnBall.MinimumWidth = 8;
            this.ColumnBall.Name = "ColumnBall";
            this.ColumnBall.Width = 150;
            // 
            // ColumnControl
            // 
            this.ColumnControl.HeaderText = "Вид контроля";
            this.ColumnControl.MinimumWidth = 8;
            this.ColumnControl.Name = "ColumnControl";
            this.ColumnControl.Width = 150;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "ФИО",
            "Группа",
            "Предмет",
            "Оценка",
            "Вид контроля"});
            this.listBox1.Location = new System.Drawing.Point(6, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 144);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(22, 311);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(201, 39);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonU);
            this.groupBox1.Controls.Add(this.radioButtonV);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(830, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 361);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButtonU
            // 
            this.radioButtonU.AutoSize = true;
            this.radioButtonU.Location = new System.Drawing.Point(35, 257);
            this.radioButtonU.Name = "radioButtonU";
            this.radioButtonU.Size = new System.Drawing.Size(134, 24);
            this.radioButtonU.TabIndex = 6;
            this.radioButtonU.TabStop = true;
            this.radioButtonU.Text = "По убыванию";
            this.radioButtonU.UseVisualStyleBackColor = true;
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Location = new System.Drawing.Point(35, 206);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(159, 24);
            this.radioButtonV.TabIndex = 5;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "По возрастанию";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(852, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Экспорт в Excell";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(612, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить оценку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmVed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmVed";
            this.Text = "fmVed";
            this.Load += new System.EventHandler(this.fmVed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnControl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonU;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}