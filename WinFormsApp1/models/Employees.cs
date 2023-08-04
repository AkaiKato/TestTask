namespace WinFormsApp1.models
{
    public class Employees
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string ServiceNumber { get; set; } = null!;

        public string Position { get; set; } = null!;

        public int Division { get; set; }

        public string Email { get; set; } = null!;

        public string Number { get; set; } = null!;

        public DateTime DateOfAppointment { get; set; }

        public DateTime? DateOfDismissal { get; set; }

        public int Status { get; set; }

    }
}
