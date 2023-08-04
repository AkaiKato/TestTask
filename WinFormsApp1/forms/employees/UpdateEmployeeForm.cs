using WinFormsApp1.models;
using WinFormsApp1.tablework;

namespace WinFormsApp1.forms.employees
{
    public partial class UpdateEmployeeForm : Form
    {
        EmployeesTableWork employeesTableWork = new();
        DivisionTableWork divisionTableWork = new();
        Employees employees;
        public UpdateEmployeeForm(Employees _employees)
        {
            employees = _employees;
            InitializeComponent();

            FullNameTextBox.Text = employees.FullName;
            ServiceNumberTextBox.Text = employees.ServiceNumber;
            PositionTextBox.Text = employees.Position;

            var ListOfDivisions = new List<TransferObject>
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfDivisions.AddRange(divisionTableWork.GetDivisionsIdNames());

            DivisionComboBox.DataSource = ListOfDivisions;
            DivisionComboBox.ValueMember = "Id";
            DivisionComboBox.DisplayMember = "Name";
            DivisionComboBox.SelectedIndex = employees.Division;

            EmailTextBox.Text = employees.Email;
            NumberTextBox.Text = employees.Number;
            DateAppointDateTimePicker.Value = employees.DateOfAppointment;

            var ListOfStates = new List<TransferObject>
            {
                new TransferObject{ Id = (int)Helper.State.Open, Name = "Открыто"},
                new TransferObject{ Id = (int)Helper.State.Close, Name = "Закрыто"},
            };

            StateComboBox.DataSource = ListOfStates;
            StateComboBox.ValueMember = "Id";
            StateComboBox.DisplayMember = "Name";
            StateComboBox.SelectedIndex = employees.Status;
        }

        private void CreateformOkBtn_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "")
            {
                MessageBox.Show("Поле ФИО не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (ServiceNumberTextBox.Text == "")
            {
                MessageBox.Show("Поле табельного номера не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (PositionTextBox.Text == "")
            {
                MessageBox.Show("Поле должности не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (EmailTextBox.Text == "")
            {
                MessageBox.Show("Поле почты не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (NumberTextBox.Text == "")
            {
                MessageBox.Show("Поле номера не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }


            string Name = FullNameTextBox.Text;
            string ServiceNumber = ServiceNumberTextBox.Text;
            string Position = PositionTextBox.Text;
            int DivisionId = (int)DivisionComboBox.SelectedValue;
            string Email = EmailTextBox.Text;
            string Number = NumberTextBox.Text;
            DateTime DateApointment = DateAppointDateTimePicker.Value;
            int State = (int)StateComboBox.SelectedValue;

            Employees UpdatedEmployee = new()
            {
                Id = employees.Id,
                FullName = Name,
                ServiceNumber = ServiceNumber,
                Position = Position,
                Division = DivisionId,
                Email = Email,
                Number = Number,
                DateOfAppointment = DateApointment,
                Status = State,
            };

            employeesTableWork.UpdateEmployee(UpdatedEmployee);

            this.Close();
        }

        private void CreatefromCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
