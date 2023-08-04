using WinFormsApp1.models;
using WinFormsApp1.tablework;

namespace WinFormsApp1
{
    public partial class CreateEmployeeForm : Form
    {
        DivisionTableWork divisionTableWork = new();
        EmployeesTableWork employeesTableWork = new();
        public CreateEmployeeForm()
        {
            InitializeComponent();
            var ListOfDivisions = new List<TransferObject>()
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfDivisions.AddRange(divisionTableWork.GetDivisionsIdNames());

            DivisionComboBox.DataSource = ListOfDivisions;
            DivisionComboBox.ValueMember = "Id";
            DivisionComboBox.DisplayMember = "Name";
            DivisionComboBox.SelectedIndex = 0;
        }

        private void CreateformOkBtn_Click(object sender, EventArgs e)
        {
            if(FullNameTextBox.Text == "")
            {
                MessageBox.Show("Поле ФИО не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (ServiceNumberTextBox.Text == "")
            {
                MessageBox.Show("Поле табельного номера не может быть пустым", "Внимание", MessageBoxButtons.OK);
                return;
            }

            if (employeesTableWork.HaveServiceNumber(ServiceNumberTextBox.Text))
            {
                MessageBox.Show("Работник с таким табельным номером уже существует", "Внимание", MessageBoxButtons.OK);
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

            Employees employees = new()
            {
                FullName = Name,
                ServiceNumber = ServiceNumber,
                Position = Position,
                Division = DivisionId,
                Email = Email,
                Number = Number,
                DateOfAppointment = DateApointment,
                Status = (int)Helper.State.Open,
            };

            employeesTableWork.CreateEmployee(employees);
            this.Close();
        }

        private void CreatefromCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
