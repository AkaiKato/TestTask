namespace WinFormsApp1
{
    partial class UpdateDivisionForm
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
            ManagerComboBox = new ComboBox();
            HeadDivisionComboBox = new ComboBox();
            CreatefromCancelBtn = new Button();
            CreateformOkBtn = new Button();
            DivisionNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StateComboBox = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // ManagerComboBox
            // 
            ManagerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManagerComboBox.FormattingEnabled = true;
            ManagerComboBox.Location = new Point(160, 85);
            ManagerComboBox.Name = "ManagerComboBox";
            ManagerComboBox.Size = new Size(265, 23);
            ManagerComboBox.TabIndex = 34;
            // 
            // HeadDivisionComboBox
            // 
            HeadDivisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HeadDivisionComboBox.FormattingEnabled = true;
            HeadDivisionComboBox.Location = new Point(160, 47);
            HeadDivisionComboBox.Name = "HeadDivisionComboBox";
            HeadDivisionComboBox.Size = new Size(265, 23);
            HeadDivisionComboBox.TabIndex = 33;
            // 
            // CreatefromCancelBtn
            // 
            CreatefromCancelBtn.Location = new Point(232, 171);
            CreatefromCancelBtn.Name = "CreatefromCancelBtn";
            CreatefromCancelBtn.Size = new Size(75, 23);
            CreatefromCancelBtn.TabIndex = 32;
            CreatefromCancelBtn.Text = "Закрыть";
            CreatefromCancelBtn.UseVisualStyleBackColor = true;
            CreatefromCancelBtn.Click += CreatefromCancelBtn_Click;
            // 
            // CreateformOkBtn
            // 
            CreateformOkBtn.Location = new Point(123, 171);
            CreateformOkBtn.Name = "CreateformOkBtn";
            CreateformOkBtn.Size = new Size(75, 23);
            CreateformOkBtn.TabIndex = 31;
            CreateformOkBtn.Text = "Ок";
            CreateformOkBtn.UseVisualStyleBackColor = true;
            CreateformOkBtn.Click += CreateformOkBtn_Click;
            // 
            // DivisionNameTextBox
            // 
            DivisionNameTextBox.Location = new Point(160, 12);
            DivisionNameTextBox.Name = "DivisionNameTextBox";
            DivisionNameTextBox.Size = new Size(265, 23);
            DivisionNameTextBox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 93);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 29;
            label3.Text = "Руководитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 28;
            label2.Text = "Головное подразделение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 27;
            label1.Text = "Название подразделения";
            // 
            // StateComboBox
            // 
            StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Location = new Point(160, 124);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(265, 23);
            StateComboBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 132);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 35;
            label4.Text = "Состояние";
            // 
            // UpdateDivisionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 206);
            Controls.Add(StateComboBox);
            Controls.Add(label4);
            Controls.Add(ManagerComboBox);
            Controls.Add(HeadDivisionComboBox);
            Controls.Add(CreatefromCancelBtn);
            Controls.Add(CreateformOkBtn);
            Controls.Add(DivisionNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateDivisionForm";
            Text = "UpdateDivisionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ManagerComboBox;
        private ComboBox HeadDivisionComboBox;
        private Button CreatefromCancelBtn;
        private Button CreateformOkBtn;
        private TextBox DivisionNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox StateComboBox;
        private Label label4;
    }
}