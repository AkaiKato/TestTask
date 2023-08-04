namespace WinFormsApp1.forms.employees
{
    partial class UpdateEmployeeForm
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
            DateAppointDateTimePicker = new DateTimePicker();
            DivisionComboBox = new ComboBox();
            NumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PositionTextBox = new TextBox();
            ServiceNumberTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CreatefromCancelBtn = new Button();
            CreateformOkBtn = new Button();
            label8 = new Label();
            StateComboBox = new ComboBox();
            SuspendLayout();
            // 
            // DateAppointDateTimePicker
            // 
            DateAppointDateTimePicker.Location = new Point(121, 241);
            DateAppointDateTimePicker.Name = "DateAppointDateTimePicker";
            DateAppointDateTimePicker.Size = new Size(265, 23);
            DateAppointDateTimePicker.TabIndex = 29;
            // 
            // DivisionComboBox
            // 
            DivisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisionComboBox.FormattingEnabled = true;
            DivisionComboBox.Location = new Point(121, 124);
            DivisionComboBox.Name = "DivisionComboBox";
            DivisionComboBox.Size = new Size(265, 23);
            DivisionComboBox.TabIndex = 28;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(121, 202);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(265, 23);
            NumberTextBox.TabIndex = 27;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(121, 163);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(265, 23);
            EmailTextBox.TabIndex = 26;
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(121, 85);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(265, 23);
            PositionTextBox.TabIndex = 25;
            // 
            // ServiceNumberTextBox
            // 
            ServiceNumberTextBox.Location = new Point(121, 47);
            ServiceNumberTextBox.Name = "ServiceNumberTextBox";
            ServiceNumberTextBox.Size = new Size(265, 23);
            ServiceNumberTextBox.TabIndex = 24;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(121, 12);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(265, 23);
            FullNameTextBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 249);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 22;
            label7.Text = "Дата Приема";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 210);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 21;
            label6.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 171);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 127);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 19;
            label4.Text = "Подразделение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 18;
            label3.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 55);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 17;
            label2.Text = "Таб.№";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 16;
            label1.Text = "ФИО";
            // 
            // CreatefromCancelBtn
            // 
            CreatefromCancelBtn.Location = new Point(220, 322);
            CreatefromCancelBtn.Name = "CreatefromCancelBtn";
            CreatefromCancelBtn.Size = new Size(75, 23);
            CreatefromCancelBtn.TabIndex = 31;
            CreatefromCancelBtn.Text = "Закрыть";
            CreatefromCancelBtn.UseVisualStyleBackColor = true;
            CreatefromCancelBtn.Click += CreatefromCancelBtn_Click;
            // 
            // CreateformOkBtn
            // 
            CreateformOkBtn.Location = new Point(111, 322);
            CreateformOkBtn.Name = "CreateformOkBtn";
            CreateformOkBtn.Size = new Size(75, 23);
            CreateformOkBtn.TabIndex = 30;
            CreateformOkBtn.Text = "Ок";
            CreateformOkBtn.UseVisualStyleBackColor = true;
            CreateformOkBtn.Click += CreateformOkBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 289);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 32;
            label8.Text = "Дата Приема";
            // 
            // StateComboBox
            // 
            StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Location = new Point(121, 281);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(265, 23);
            StateComboBox.TabIndex = 33;
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 354);
            Controls.Add(StateComboBox);
            Controls.Add(label8);
            Controls.Add(CreatefromCancelBtn);
            Controls.Add(CreateformOkBtn);
            Controls.Add(DateAppointDateTimePicker);
            Controls.Add(DivisionComboBox);
            Controls.Add(NumberTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PositionTextBox);
            Controls.Add(ServiceNumberTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateEmployeeForm";
            Text = "UpdateEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DateAppointDateTimePicker;
        private ComboBox DivisionComboBox;
        private TextBox NumberTextBox;
        private TextBox EmailTextBox;
        private TextBox PositionTextBox;
        private TextBox ServiceNumberTextBox;
        private TextBox FullNameTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CreatefromCancelBtn;
        private Button CreateformOkBtn;
        private Label label8;
        private ComboBox StateComboBox;
    }
}