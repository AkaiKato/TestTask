using WinFormsApp1.models;
using WinFormsApp1.tablework;

namespace WinFormsApp1
{
    public partial class UpdateDivisionForm : Form
    {
        DivisionTableWork divisionTableWork = new();
        EmployeesTableWork employeesTableWork = new();
        Division division;
        public UpdateDivisionForm(Division _division)
        {
            division = _division;
            InitializeComponent();

            DivisionNameTextBox.Text = division.DivisionName;

            var ListOfDivisions = new List<TransferObject>
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfDivisions.AddRange(divisionTableWork.GetDivisionsIdNames());

            HeadDivisionComboBox.DataSource = ListOfDivisions;
            HeadDivisionComboBox.ValueMember = "Id";
            HeadDivisionComboBox.DisplayMember = "Name";
            HeadDivisionComboBox.SelectedIndex = division.HeadDivision;

            var ListOfManagers = new List<TransferObject>
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfManagers.AddRange(employeesTableWork.GetEmployeeIdNames());

            ManagerComboBox.DataSource = ListOfManagers;
            ManagerComboBox.ValueMember = "Id";
            ManagerComboBox.DisplayMember = "Name";
            ManagerComboBox.SelectedIndex = division.Manager;

            var ListOfStates = new List<TransferObject>
            {
                new TransferObject{ Id = (int)Helper.State.Open, Name = "Открыто"},
                new TransferObject{ Id = (int)Helper.State.Close, Name = "Закрыто"},
            };

            StateComboBox.DataSource = ListOfStates;
            StateComboBox.ValueMember = "Id";
            StateComboBox.DisplayMember = "Name";
            StateComboBox.SelectedIndex = division.StatusOfDivision;
        }

        private void CreateformOkBtn_Click(object sender, EventArgs e)
        {
            string Name = DivisionNameTextBox.Text;
            int HeadDivisionId = (int)HeadDivisionComboBox.SelectedValue;
            int ManagerId = (int)ManagerComboBox.SelectedValue;
            int State = (int)StateComboBox.SelectedValue;

            if(HeadDivisionComboBox.GetItemText(HeadDivisionComboBox.SelectedItem) == Name)
            {
                MessageBox.Show("Объект не может быть сам для себя головным подразделением", "Внимание", MessageBoxButtons.OK);
                return;
            }

            Division UpdatedDivision = new()
            {
                Id = division.Id,
                DivisionName = Name,
                StatusOfDivision = State,
                HeadDivision = HeadDivisionId,
                Manager = ManagerId
            };

            divisionTableWork.UpdateDivision(UpdatedDivision);

            this.Close();
        }

        private void CreatefromCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
