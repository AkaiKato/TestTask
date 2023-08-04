namespace WinFormsApp1
{
    partial class CreateEmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            FullNameTextBox = new TextBox();
            ServiceNumberTextBox = new TextBox();
            PositionTextBox = new TextBox();
            EmailTextBox = new TextBox();
            NumberTextBox = new TextBox();
            DivisionComboBox = new ComboBox();
            DateAppointDateTimePicker = new DateTimePicker();
            CreateformOkBtn = new Button();
            CreatefromCancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 55);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Таб.№";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Должность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 127);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Подразделение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 171);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 210);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 249);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 6;
            label7.Text = "Дата Приема";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(136, 12);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(265, 23);
            FullNameTextBox.TabIndex = 7;
            // 
            // ServiceNumberTextBox
            // 
            ServiceNumberTextBox.Location = new Point(136, 47);
            ServiceNumberTextBox.Name = "ServiceNumberTextBox";
            ServiceNumberTextBox.Size = new Size(265, 23);
            ServiceNumberTextBox.TabIndex = 8;
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(136, 85);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(265, 23);
            PositionTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(136, 163);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(265, 23);
            EmailTextBox.TabIndex = 11;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(136, 202);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(265, 23);
            NumberTextBox.TabIndex = 12;
            // 
            // DivisionComboBox
            // 
            DivisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisionComboBox.FormattingEnabled = true;
            DivisionComboBox.Location = new Point(136, 124);
            DivisionComboBox.Name = "DivisionComboBox";
            DivisionComboBox.Size = new Size(265, 23);
            DivisionComboBox.TabIndex = 14;
            // 
            // DateAppointDateTimePicker
            // 
            DateAppointDateTimePicker.Location = new Point(136, 241);
            DateAppointDateTimePicker.Name = "DateAppointDateTimePicker";
            DateAppointDateTimePicker.Size = new Size(265, 23);
            DateAppointDateTimePicker.TabIndex = 15;
            // 
            // CreateformOkBtn
            // 
            CreateformOkBtn.Location = new Point(123, 291);
            CreateformOkBtn.Name = "CreateformOkBtn";
            CreateformOkBtn.Size = new Size(75, 23);
            CreateformOkBtn.TabIndex = 16;
            CreateformOkBtn.Text = "Ок";
            CreateformOkBtn.UseVisualStyleBackColor = true;
            CreateformOkBtn.Click += CreateformOkBtn_Click;
            // 
            // CreatefromCancelBtn
            // 
            CreatefromCancelBtn.Location = new Point(232, 291);
            CreatefromCancelBtn.Name = "CreatefromCancelBtn";
            CreatefromCancelBtn.Size = new Size(75, 23);
            CreatefromCancelBtn.TabIndex = 17;
            CreatefromCancelBtn.Text = "Закрыть";
            CreatefromCancelBtn.UseVisualStyleBackColor = true;
            CreatefromCancelBtn.Click += CreatefromCancelBtn_Click;
            // 
            // CreateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 325);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateEmployeeForm";
            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox FullNameTextBox;
        private TextBox ServiceNumberTextBox;
        private TextBox PositionTextBox;
        private TextBox EmailTextBox;
        private TextBox NumberTextBox;
        private ComboBox DivisionComboBox;
        private DateTimePicker DateAppointDateTimePicker;
        private Button CreateformOkBtn;
        private Button CreatefromCancelBtn;
    }
}