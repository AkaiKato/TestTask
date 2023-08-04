namespace WinFormsApp1
{
    partial class CreateDivisionForm
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
            DivisionNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CreatefromCancelBtn = new Button();
            CreateformOkBtn = new Button();
            HeadDivisionComboBox = new ComboBox();
            ManagerComboBox = new ComboBox();
            SuspendLayout();
            // 
            // DivisionNameTextBox
            // 
            DivisionNameTextBox.Location = new Point(160, 12);
            DivisionNameTextBox.Name = "DivisionNameTextBox";
            DivisionNameTextBox.Size = new Size(265, 23);
            DivisionNameTextBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 93);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 17;
            label3.Text = "Руководитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 16;
            label2.Text = "Головное подразделение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 15;
            label1.Text = "Название подразделения";
            // 
            // CreatefromCancelBtn
            // 
            CreatefromCancelBtn.Location = new Point(237, 131);
            CreatefromCancelBtn.Name = "CreatefromCancelBtn";
            CreatefromCancelBtn.Size = new Size(75, 23);
            CreatefromCancelBtn.TabIndex = 24;
            CreatefromCancelBtn.Text = "Закрыть";
            CreatefromCancelBtn.UseVisualStyleBackColor = true;
            CreatefromCancelBtn.Click += CreatefromCancelBtn_Click;
            // 
            // CreateformOkBtn
            // 
            CreateformOkBtn.Location = new Point(128, 131);
            CreateformOkBtn.Name = "CreateformOkBtn";
            CreateformOkBtn.Size = new Size(75, 23);
            CreateformOkBtn.TabIndex = 23;
            CreateformOkBtn.Text = "Ок";
            CreateformOkBtn.UseVisualStyleBackColor = true;
            CreateformOkBtn.Click += CreateformOkBtn_Click;
            // 
            // HeadDivisionComboBox
            // 
            HeadDivisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HeadDivisionComboBox.FormattingEnabled = true;
            HeadDivisionComboBox.Location = new Point(160, 47);
            HeadDivisionComboBox.Name = "HeadDivisionComboBox";
            HeadDivisionComboBox.Size = new Size(265, 23);
            HeadDivisionComboBox.TabIndex = 25;
            // 
            // ManagerComboBox
            // 
            ManagerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManagerComboBox.FormattingEnabled = true;
            ManagerComboBox.Location = new Point(160, 85);
            ManagerComboBox.Name = "ManagerComboBox";
            ManagerComboBox.Size = new Size(265, 23);
            ManagerComboBox.TabIndex = 26;
            // 
            // CreateDivisionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 169);
            Controls.Add(ManagerComboBox);
            Controls.Add(HeadDivisionComboBox);
            Controls.Add(CreatefromCancelBtn);
            Controls.Add(CreateformOkBtn);
            Controls.Add(DivisionNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateDivisionForm";
            Text = "CreateDivisionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox DivisionNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CreatefromCancelBtn;
        private Button CreateformOkBtn;
        private ComboBox HeadDivisionComboBox;
        private ComboBox ManagerComboBox;
    }
}