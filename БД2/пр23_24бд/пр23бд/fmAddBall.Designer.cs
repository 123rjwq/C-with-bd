namespace пр23бд
{
    partial class fmAddBall
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.txtBall = new System.Windows.Forms.NumericUpDown();
            this.decanatDataSet = new пр23бд.DecanatDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new пр23бд.DecanatDataSetTableAdapters.SubjectTableAdapter();
            this.tableAdapterManager = new пр23бд.DecanatDataSetTableAdapters.TableAdapterManager();
            this.ballBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ballTableAdapter = new пр23бд.DecanatDataSetTableAdapters.BallTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new пр23бд.DecanatDataSetTableAdapters.StudentTableAdapter();
            this.cmdVid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид контроля";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(71, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(255, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "Name_subject", true));
            this.cmbSubject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ballBindingSource, "id_subject", true));
            this.cmbSubject.DataSource = this.subjectBindingSource;
            this.cmbSubject.DisplayMember = "Name_subject";
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(192, 67);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(164, 28);
            this.cmbSubject.TabIndex = 6;
            this.cmbSubject.ValueMember = "Id_subject";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FIO", true));
            this.cmbStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ballBindingSource, "id_subject", true));
            this.cmbStudent.DataSource = this.studentBindingSource;
            this.cmbStudent.DisplayMember = "FIO";
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(192, 131);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(164, 28);
            this.cmbStudent.TabIndex = 7;
            this.cmbStudent.ValueMember = "Id_student";
            // 
            // txtBall
            // 
            this.txtBall.Location = new System.Drawing.Point(192, 193);
            this.txtBall.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtBall.Name = "txtBall";
            this.txtBall.Size = new System.Drawing.Size(120, 26);
            this.txtBall.TabIndex = 8;
            this.txtBall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // decanatDataSet
            // 
            this.decanatDataSet.DataSetName = "DecanatDataSet";
            this.decanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.decanatDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BallTableAdapter = this.ballTableAdapter;
            this.tableAdapterManager.GroupaTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.SubjectTableAdapter = this.subjectTableAdapter;
            this.tableAdapterManager.UpdateOrder = пр23бд.DecanatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ballBindingSource
            // 
            this.ballBindingSource.DataMember = "Ball";
            this.ballBindingSource.DataSource = this.decanatDataSet;
            // 
            // ballTableAdapter
            // 
            this.ballTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.decanatDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // cmdVid
            // 
            this.cmdVid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ballBindingSource, "vid_control", true));
            this.cmdVid.FormattingEnabled = true;
            this.cmdVid.Items.AddRange(new object[] {
            "Экзамен",
            "Зачет",
            "Тестирование"});
            this.cmdVid.Location = new System.Drawing.Point(192, 250);
            this.cmdVid.Name = "cmdVid";
            this.cmdVid.Size = new System.Drawing.Size(164, 28);
            this.cmdVid.TabIndex = 9;
            // 
            // fmAddBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.cmdVid);
            this.Controls.Add(this.txtBall);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmAddBall";
            this.Text = "fmAddBall";
            this.Load += new System.EventHandler(this.fmAddBall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.NumericUpDown txtBall;
        private DecanatDataSet decanatDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private DecanatDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private DecanatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DecanatDataSetTableAdapters.BallTableAdapter ballTableAdapter;
        private System.Windows.Forms.BindingSource ballBindingSource;
        private DecanatDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ComboBox cmdVid;
    }
}