using WinFormsApp1.models;
using WinFormsApp1.tablework;

namespace WinFormsApp1
{
    public static class Helper
    {
        static DivisionTableWork divisionTableWork = new();
        static EmployeesTableWork employeesTableWork = new();
        public enum State
        {
            Open,
            Close
        }

        public static void FillEmployees(DataGridView dataGridView, List<Employees> employees)
        {
            int i = 0;
            foreach (var item in employees)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = item.Id;
                dataGridView.Rows[i].Cells[1].Value = item.FullName;
                dataGridView.Rows[i].Cells[2].Value = item.ServiceNumber;
                dataGridView.Rows[i].Cells[3].Value = item.Position;

                if (item.Division != 0)
                    dataGridView.Rows[i].Cells[4].Value = divisionTableWork.GetDivisionNameById(item.Division);

                dataGridView.Rows[i].Cells[5].Value = item.Email;
                dataGridView.Rows[i].Cells[6].Value = item.Number;
                dataGridView.Rows[i].Cells[7].Value = item.DateOfAppointment;
                dataGridView.Rows[i].Cells[8].Value = item.DateOfDismissal;
                dataGridView.Rows[i].Cells[9].Value = item.Status == 0 ? "Открыта" : "Закрыта";
                i++;
            }
        }

        public static void FillDivisions(DataGridView dataGridView, List<Division> divisions)
        {
            int i = 0;
            foreach (var item in divisions)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = item.Id;
                dataGridView.Rows[i].Cells[1].Value = item.DivisionName;

                if (item.HeadDivision != 0)
                    dataGridView.Rows[i].Cells[2].Value = divisionTableWork.GetDivisionNameById(item.HeadDivision);

                if (item.Manager != 0)
                    dataGridView.Rows[i].Cells[3].Value = employeesTableWork.GetEmployeeNameById(item.Manager);

                dataGridView.Rows[i].Cells[4].Value = item.StatusOfDivision == 0 ? "Открыта" : "Закрыта";
                i++;
            }
        }
    }
}
