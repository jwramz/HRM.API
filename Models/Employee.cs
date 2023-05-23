namespace HRM.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Designation { get; set; } = string.Empty;
        public string? FathersName { get; set; } = string.Empty;
        public string? MothersName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
