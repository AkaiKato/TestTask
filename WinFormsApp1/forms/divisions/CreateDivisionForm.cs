using WinFormsApp1.models;
using WinFormsApp1.tablework;

namespace WinFormsApp1
{
    public partial class CreateDivisionForm : Form
    {
        DivisionTableWork divisionTableWork = new();
        EmployeesTableWork employeesTableWork = new();

        public CreateDivisionForm()
        {
            InitializeComponent();

            var ListOfDivisions = new List<TransferObject>
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfDivisions.AddRange(divisionTableWork.GetDivisionsIdNames());

            HeadDivisionComboBox.DataSource = ListOfDivisions;
            HeadDivisionComboBox.ValueMember = "Id";
            HeadDivisionComboBox.DisplayMember = "Name";
            HeadDivisionComboBox.SelectedIndex = 0;

            var ListOfManagers = new List<TransferObject>
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfManagers.AddRange(employeesTableWork.GetEmployeeIdNames());

            ManagerComboBox.DataSource = ListOfManagers;
            ManagerComboBox.ValueMember = "Id";
            ManagerComboBox.DisplayMember = "Name";
            ManagerComboBox.SelectedIndex = 0;
        }

        private void CreateformOkBtn_Click(object sender, EventArgs e)
        {
            if(DivisionNameTextBox.Text == "")
            {
                MessageBox.Show("Поле названия подразделения не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (divisionTableWork.HaveDivision(DivisionNameTextBox.Text))
            {
                MessageBox.Show("Такое названия подразделения уже существует", "Внимание", MessageBoxButtons.OK);
                return;
            }

            string Name = DivisionNameTextBox.Text;
            int HeadDivisionId = (int)HeadDivisionComboBox.SelectedValue;
            int ManagerId = (int)ManagerComboBox.SelectedValue;

            Division division = new()
            {
                DivisionName = Name,
                StatusOfDivision = (int)Helper.State.Open,
                HeadDivision = HeadDivisionId,
                Manager = ManagerId
            };

            divisionTableWork.CreateDivision(division);

            this.Close();
        }

        private void CreatefromCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
