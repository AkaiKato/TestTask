namespace WinFormsApp1.models
{
    public class Division
    {
        public int Id { get; set; }

        public string DivisionName { get; set; } = null!;

        public int HeadDivision { get; set; }

        public int Manager { get; set; }

        public int StatusOfDivision { get; set; }

        public List<Employees>? Employees { get; set; }
    }
}
