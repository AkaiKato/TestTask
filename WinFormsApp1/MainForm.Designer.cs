namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmploeesBtn = new Button();
            DivisionsBtn = new Button();
            MainDataGridView = new DataGridView();
            AddNewEmployee = new Button();
            CreateDivisionBtn = new Button();
            UpdateDivisionBtn = new Button();
            DeleteDivisionBtn = new Button();
            UpdateEmployeeBtn = new Button();
            FireEmployeeBtn = new Button();
            DeleteEmployeeBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            groupBox3 = new GroupBox();
            ResetBtn = new Button();
            DivisionComboBox = new ComboBox();
            LoadExcel = new Button();
            groupBox4 = new GroupBox();
            StatDivComboBox = new ComboBox();
            SeeBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            MaxDateTimePicker = new DateTimePicker();
            MinDateTimePicker = new DateTimePicker();
            StatisticComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // EmploeesBtn
            // 
            EmploeesBtn.Location = new Point(6, 22);
            EmploeesBtn.Name = "EmploeesBtn";
            EmploeesBtn.Size = new Size(100, 23);
            EmploeesBtn.TabIndex = 0;
            EmploeesBtn.Text = "Сотрудники";
            EmploeesBtn.UseVisualStyleBackColor = true;
            EmploeesBtn.Click += EmploeesBtn_Click;
            // 
            // DivisionsBtn
            // 
            DivisionsBtn.Location = new Point(112, 22);
            DivisionsBtn.Name = "DivisionsBtn";
            DivisionsBtn.Size = new Size(100, 23);
            DivisionsBtn.TabIndex = 1;
            DivisionsBtn.Text = "Подразделения";
            DivisionsBtn.UseVisualStyleBackColor = true;
            DivisionsBtn.Click += DivisionsBtn_Click;
            // 
            // MainDataGridView
            // 
            MainDataGridView.AllowUserToAddRows = false;
            MainDataGridView.AllowUserToDeleteRows = false;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainDataGridView.Location = new Point(12, 120);
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.RowHeadersVisible = false;
            MainDataGridView.RowTemplate.Height = 25;
            MainDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MainDataGridView.Size = new Size(973, 459);
            MainDataGridView.TabIndex = 2;
            // 
            // AddNewEmployee
            // 
            AddNewEmployee.Location = new Point(991, 193);
            AddNewEmployee.Name = "AddNewEmployee";
            AddNewEmployee.Size = new Size(156, 23);
            AddNewEmployee.TabIndex = 3;
            AddNewEmployee.Text = "Новый Сотрудник";
            AddNewEmployee.UseVisualStyleBackColor = true;
            AddNewEmployee.Click += AddNewEmployee_Click;
            // 
            // CreateDivisionBtn
            // 
            CreateDivisionBtn.Location = new Point(991, 309);
            CreateDivisionBtn.Name = "CreateDivisionBtn";
            CreateDivisionBtn.Size = new Size(156, 23);
            CreateDivisionBtn.TabIndex = 4;
            CreateDivisionBtn.Text = "Новое подразделение";
            CreateDivisionBtn.UseVisualStyleBackColor = true;
            CreateDivisionBtn.Click += CreateDivisionBtn_Click;
            // 
            // UpdateDivisionBtn
            // 
            UpdateDivisionBtn.Location = new Point(991, 338);
            UpdateDivisionBtn.Name = "UpdateDivisionBtn";
            UpdateDivisionBtn.Size = new Size(156, 23);
            UpdateDivisionBtn.TabIndex = 5;
            UpdateDivisionBtn.Text = "Изменить подразделение";
            UpdateDivisionBtn.UseVisualStyleBackColor = true;
            UpdateDivisionBtn.Click += UpdateDivisionBtn_Click;
            // 
            // DeleteDivisionBtn
            // 
            DeleteDivisionBtn.Location = new Point(991, 367);
            DeleteDivisionBtn.Name = "DeleteDivisionBtn";
            DeleteDivisionBtn.Size = new Size(156, 23);
            DeleteDivisionBtn.TabIndex = 6;
            DeleteDivisionBtn.Text = "Удалить подразделение";
            DeleteDivisionBtn.UseVisualStyleBackColor = true;
            DeleteDivisionBtn.Click += DeleteDivisionBtn_Click;
            // 
            // UpdateEmployeeBtn
            // 
            UpdateEmployeeBtn.Location = new Point(991, 222);
            UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            UpdateEmployeeBtn.Size = new Size(156, 23);
            UpdateEmployeeBtn.TabIndex = 7;
            UpdateEmployeeBtn.Text = "Изменить сотрудника";
            UpdateEmployeeBtn.UseVisualStyleBackColor = true;
            UpdateEmployeeBtn.Click += UpdateEmployeeBtn_Click;
            // 
            // FireEmployeeBtn
            // 
            FireEmployeeBtn.Location = new Point(991, 251);
            FireEmployeeBtn.Name = "FireEmployeeBtn";
            FireEmployeeBtn.Size = new Size(156, 23);
            FireEmployeeBtn.TabIndex = 8;
            FireEmployeeBtn.Text = "Уволить сотрудника";
            FireEmployeeBtn.UseVisualStyleBackColor = true;
            FireEmployeeBtn.Click += FireEmployeeBtn_Click;
            // 
            // DeleteEmployeeBtn
            // 
            DeleteEmployeeBtn.Location = new Point(991, 280);
            DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            DeleteEmployeeBtn.Size = new Size(156, 23);
            DeleteEmployeeBtn.TabIndex = 9;
            DeleteEmployeeBtn.Text = "Удалить сотрудника сотрудника";
            DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EmploeesBtn);
            groupBox1.Controls.Add(DivisionsBtn);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 48);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Переключение таблиц";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(SearchTextBox);
            groupBox2.Location = new Point(237, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(216, 48);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(136, 22);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Поиск";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(6, 21);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(124, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ResetBtn);
            groupBox3.Controls.Add(DivisionComboBox);
            groupBox3.Location = new Point(459, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 48);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "По подразделениям";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(141, 22);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 1;
            ResetBtn.Text = "Сбросить";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DivisionComboBox
            // 
            DivisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisionComboBox.FormattingEnabled = true;
            DivisionComboBox.Location = new Point(6, 22);
            DivisionComboBox.Name = "DivisionComboBox";
            DivisionComboBox.Size = new Size(129, 23);
            DivisionComboBox.TabIndex = 0;
            DivisionComboBox.SelectedIndexChanged += DivisionComboBox_SelectedIndexChanged;
            // 
            // LoadExcel
            // 
            LoadExcel.Location = new Point(991, 34);
            LoadExcel.Name = "LoadExcel";
            LoadExcel.Size = new Size(156, 23);
            LoadExcel.TabIndex = 13;
            LoadExcel.Text = "Загрузить данные";
            LoadExcel.UseVisualStyleBackColor = true;
            LoadExcel.Click += LoadExcel_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(StatDivComboBox);
            groupBox4.Controls.Add(SeeBtn);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(MaxDateTimePicker);
            groupBox4.Controls.Add(MinDateTimePicker);
            groupBox4.Controls.Add(StatisticComboBox);
            groupBox4.Location = new Point(12, 66);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(669, 48);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Статистика";
            // 
            // StatDivComboBox
            // 
            StatDivComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatDivComboBox.FormattingEnabled = true;
            StatDivComboBox.Location = new Point(453, 21);
            StatDivComboBox.Name = "StatDivComboBox";
            StatDivComboBox.Size = new Size(129, 23);
            StatDivComboBox.TabIndex = 2;
            // 
            // SeeBtn
            // 
            SeeBtn.Location = new Point(588, 21);
            SeeBtn.Name = "SeeBtn";
            SeeBtn.Size = new Size(75, 23);
            SeeBtn.TabIndex = 5;
            SeeBtn.Text = "Показать";
            SeeBtn.UseVisualStyleBackColor = true;
            SeeBtn.Click += SeeBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 27);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "ПО";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 27);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "C";
            // 
            // MaxDateTimePicker
            // 
            MaxDateTimePicker.CustomFormat = "dd-MM-yyyy";
            MaxDateTimePicker.Location = new Point(316, 21);
            MaxDateTimePicker.Name = "MaxDateTimePicker";
            MaxDateTimePicker.Size = new Size(126, 23);
            MaxDateTimePicker.TabIndex = 2;
            // 
            // MinDateTimePicker
            // 
            MinDateTimePicker.CustomFormat = "dd-MM-yyyy";
            MinDateTimePicker.Location = new Point(154, 21);
            MinDateTimePicker.Name = "MinDateTimePicker";
            MinDateTimePicker.Size = new Size(126, 23);
            MinDateTimePicker.TabIndex = 1;
            // 
            // StatisticComboBox
            // 
            StatisticComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatisticComboBox.FormattingEnabled = true;
            StatisticComboBox.Location = new Point(6, 21);
            StatisticComboBox.Name = "StatisticComboBox";
            StatisticComboBox.Size = new Size(121, 23);
            StatisticComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 590);
            Controls.Add(groupBox4);
            Controls.Add(LoadExcel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DeleteEmployeeBtn);
            Controls.Add(FireEmployeeBtn);
            Controls.Add(UpdateEmployeeBtn);
            Controls.Add(DeleteDivisionBtn);
            Controls.Add(UpdateDivisionBtn);
            Controls.Add(CreateDivisionBtn);
            Controls.Add(AddNewEmployee);
            Controls.Add(MainDataGridView);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EmploeesBtn;
        private Button DivisionsBtn;
        private DataGridView MainDataGridView;
        private Button AddNewEmployee;
        private Button CreateDivisionBtn;
        private Button UpdateDivisionBtn;
        private Button DeleteDivisionBtn;
        private Button UpdateEmployeeBtn;
        private Button FireEmployeeBtn;
        private Button DeleteEmployeeBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox SearchTextBox;
        private Button SearchBtn;
        private GroupBox groupBox3;
        private Button ResetBtn;
        private ComboBox DivisionComboBox;
        private Button LoadExcel;
        private GroupBox groupBox4;
        private DateTimePicker MinDateTimePicker;
        private ComboBox StatisticComboBox;
        private Label label2;
        private Label label1;
        private DateTimePicker MaxDateTimePicker;
        private Button SeeBtn;
        private ComboBox StatDivComboBox;
    }
}