using Microsoft.Office.Interop.Excel;
using WinFormsApp1.forms.employees;
using WinFormsApp1.models;
using WinFormsApp1.tablework;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        readonly DivisionTableWork divisionTableWork = new();
        readonly EmployeesTableWork employeesTableWork = new();
        bool flag = true;
        bool selFlag = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmployeesTableHeders()
        {
            MainDataGridView.Columns.Clear();
            MainDataGridView.Columns.Add("Id", "№");
            MainDataGridView.Columns.Add("FullName", "ФИО");
            MainDataGridView.Columns.Add("ServiceNumber", "Таб.№");
            MainDataGridView.Columns.Add("Position", "Должность");
            MainDataGridView.Columns.Add("Division", "Подразделение");
            MainDataGridView.Columns.Add("Email", "Email");
            MainDataGridView.Columns.Add("Number", "Телефон ");
            MainDataGridView.Columns.Add("DateOfAppointment", "Дата приема");
            MainDataGridView.Columns.Add("DateOfDismisal", "Дата увольнения");
            MainDataGridView.Columns.Add("State", "Состояние");
            MainDataGridView.Columns["DateOfAppointment"].DefaultCellStyle.Format = "dd/MM/yyyy";
            MainDataGridView.Columns["DateOfDismisal"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void MakeEmployeesTable()
        {
            EmployeesTableHeders();
            flag = true;
            var list = employeesTableWork.GetAllEmployees();
            Helper.FillEmployees(MainDataGridView, list);
        }

        private void DivisionTableHeders()
        {
            MainDataGridView.Columns.Clear();
            MainDataGridView.Columns.Add("Id", "№");
            MainDataGridView.Columns.Add("DivisionName", "Наименование");
            MainDataGridView.Columns.Add("HeadDivision", "Головное подразделение");
            MainDataGridView.Columns.Add("Manager", "Руководитель");
            MainDataGridView.Columns.Add("State", "Состояние");
        }

        private void MakeDivisionTable()
        {
            DivisionTableHeders();
            flag = false;
            var list = divisionTableWork.GetAllDivisions();
            Helper.FillDivisions(MainDataGridView, list);
        }

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm createForm = new();
            createForm.ShowDialog(this);
            MakeEmployeesTable();
        }

        private void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (!flag)
                return;

            if (!CheckSelectedRow())
                return;

            var employee = employeesTableWork.GetEmployeeById((int)MainDataGridView.SelectedRows[0].Cells[0].Value);
            UpdateEmployeeForm updateEmployeeForm = new(employee);
            updateEmployeeForm.ShowDialog(this);
            MakeEmployeesTable();
        }

        private void FireEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (!flag)
                return;

            if (!CheckSelectedRow())
                return;

            if (MessageBox.Show("Вы уверены?", "Подтвердите", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var employee = employeesTableWork.GetEmployeeById((int)MainDataGridView.SelectedRows[0].Cells[0].Value);
                employee.DateOfDismissal = DateTime.Now;
                employee.Status = (int)Helper.State.Close;
                employeesTableWork.FireEmployee(employee);
                MakeEmployeesTable();
            }
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (!flag)
                return;

            if (!CheckSelectedRow())
                return;

            if (MessageBox.Show("Вы уверены?", "Подтвердите", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                employeesTableWork.DeleteEmployee((int)MainDataGridView.SelectedRows[0].Cells[0].Value);
                MakeEmployeesTable();
            }
        }

        private void EmploeesBtn_Click(object sender, EventArgs e)
        {
            MakeEmployeesTable();
        }

        private void DivisionsBtn_Click(object sender, EventArgs e)
        {
            MakeDivisionTable();
        }

        private void CreateDivisionBtn_Click(object sender, EventArgs e)
        {
            CreateDivisionForm createDivisionForm = new();
            createDivisionForm.ShowDialog(this);
            MakeDivisionTable();
        }

        private void UpdateDivisionBtn_Click(object sender, EventArgs e)
        {
            if (flag)
                return;

            if (!CheckSelectedRow())
                return;

            var division = divisionTableWork.GetDivisionById((int)MainDataGridView.SelectedRows[0].Cells[0].Value);

            UpdateDivisionForm updateDivisionForm = new(division);
            updateDivisionForm.ShowDialog(this);
            MakeDivisionTable();
        }

        private void DeleteDivisionBtn_Click(object sender, EventArgs e)
        {
            if (flag)
                return;

            if (!CheckSelectedRow())
                return;

            if (MessageBox.Show("Вы уверены?", "Подтвердите", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                divisionTableWork.DeleteDivision((int)MainDataGridView.SelectedRows[0].Cells[0].Value);
                MakeDivisionTable();
            }
        }

        private bool CheckSelectedRow()
        {
            int sel = MainDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (sel == 0)
                return false;
            if (sel > 1)
                return false;

            return true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
                return;

            EmployeesTableHeders();
            var list = employeesTableWork.SearchEmployees(SearchTextBox.Text);
            Helper.FillEmployees(MainDataGridView, list);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DivisionComboBox.SelectedIndex = 0;
            MakeEmployeesTable();
        }

        private void DivisionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selFlag)
                return;

            if ((int)DivisionComboBox.SelectedValue == 0)
            {
                ResetBtn.PerformClick();
                return;
            }

            EmployeesTableHeders();
            var list = employeesTableWork.GetAllDivisionEmployees((int)DivisionComboBox.SelectedValue);
            Helper.FillEmployees(MainDataGridView, list);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MakeEmployeesTable();
            flag = true;

            FillComboBox();

            StatisticComboBox.Items.Add(new TransferObject { Id = 0, Name = "Принятие на работу" });
            StatisticComboBox.Items.Add(new TransferObject { Id = 1, Name = "Увольнения" });
            StatisticComboBox.ValueMember = "Id";
            StatisticComboBox.DisplayMember = "Name";
            StatisticComboBox.SelectedIndex = 0;
        }

        private void FillComboBox()
        {
            var ListOfDivisions = new List<TransferObject>
            {
                new TransferObject { Id = 0, Name = "" }
            };
            ListOfDivisions.AddRange(divisionTableWork.GetDivisionsIdNames());

            DivisionComboBox.DataSource = ListOfDivisions;
            DivisionComboBox.ValueMember = "Id";
            DivisionComboBox.DisplayMember = "Name";
            DivisionComboBox.SelectedIndex = 0;
            selFlag = true;

            var ListOfDivisionsStat = new List<TransferObject>();
            ListOfDivisions.ForEach(d => { ListOfDivisionsStat.Add(d); });
            StatDivComboBox.DataSource = ListOfDivisionsStat;
            StatDivComboBox.ValueMember = "Id";
            StatDivComboBox.DisplayMember = "Name";
            StatDivComboBox.SelectedIndex = 0;
        }

        private void SeeBtn_Click(object sender, EventArgs e)
        {
            int StatId = StatisticComboBox.SelectedIndex;
            var StartTime = MinDateTimePicker.Value;
            var EndTime = MaxDateTimePicker.Value;
            int StatDiv = (int)StatDivComboBox.SelectedValue;

            if (StartTime > EndTime)
            {
                MessageBox.Show("Стартовая дата должна быть меньше конечной", "Внимание", MessageBoxButtons.OK);
                return;
            }

            EmployeesTableHeders();
            if (StatId == 0)
            {
                var list = employeesTableWork.GetStatAppointmentEmployees(StartTime, EndTime, StatDiv);
                Helper.FillEmployees(MainDataGridView, list);
                MessageBox.Show($"С {StartTime} по {EndTime} " +
                    $"{(StatDiv == 0 ? "" : $"в подразделении {StatDivComboBox.GetItemText(StatDivComboBox.SelectedItem)} ")}" +
                    $"было принято {list.Count} работника(-ов)");
            }
            else if (StatId == 1)
            {
                var list = employeesTableWork.GetStatFireEmployees(StartTime, EndTime, StatDiv);
                Helper.FillEmployees(MainDataGridView, list);
                MessageBox.Show($"С {StartTime} по {EndTime} " +
                    $"{(StatDiv == 0 ? "" : $"в подразделении {StatDivComboBox.GetItemText(StatDivComboBox.SelectedItem)} ")}" +
                    $"были уволены {list.Count} работника(-ов)");
            }

        }

        private void LoadExcel_Click(object sender, EventArgs e)
        {
            ReadExcel();
        }

        private void ReadExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Microsoft.Office.Interop.Excel.Application excel = new();
                MakeDivisions(excel, filePath);
                MakeEmployees(excel, filePath);
                MakeEmployeesTable();
                FillComboBox();
            }
        }

        private void MakeDivisions(Microsoft.Office.Interop.Excel.Application excel, string filePath)
        {
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[2];

            var range = ws.UsedRange;

            for (int i = 2; i < range.Rows.Count + 1; i++)
            {
                if (ws.Cells[2][i].Value == null)
                    continue;

                var div = new Division
                {
                    DivisionName = ws.Cells[2][i].Value.ToString()
                };
                divisionTableWork.CreateDivision(div);
            }

            for (int i = 2; i < range.Rows.Count + 1; i++)
            {
                if (ws.Cells[3][i].Value == null)
                    continue;

                var div = divisionTableWork.GetDivisionById(i - 1);

                div.HeadDivision = divisionTableWork.GetDivisionByName(ws.Cells[3][i].Value);

                divisionTableWork.UpdateDivision(div);
            }
        }

        private void MakeEmployees(Microsoft.Office.Interop.Excel.Application excel, string filePath)
        {
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            var range = ws.UsedRange;

            for (int i = 2; i < range.Rows.Count + 1; i++)
            {
                var employee = new Employees();

                for (int j = 2; j < range.Columns.Count + 1; j++)
                {
                    if (j == 2)
                        employee.FullName = ws.Cells[j][i].Value.ToString();
                    if (j == 3)
                        employee.ServiceNumber = ws.Cells[j][i].Value.ToString();
                    if (j == 4)
                        employee.Position = ws.Cells[j][i].Value.ToString();
                    if (j == 5)
                        employee.Division = divisionTableWork.GetDivisionByName(ws.Cells[j][i].Value.ToString());
                    if (j == 6)
                        employee.Email = ws.Cells[j][i].Value.ToString();
                    if (j == 7)
                        employee.Number = ws.Cells[j][i].Value.ToString();
                    if (j == 8)
                        employee.DateOfAppointment = ws.Cells[j][i].Value;
                    if (j == 9 && ws.Cells[j][i].Value != null)
                    {
                        employee.DateOfDismissal = ws.Cells[j][i].Value;
                        employee.Status = (int)Helper.State.Close;
                    }
                }
                employeesTableWork.CreateEmployeeExcel(employee);
            }


        }
    }

}