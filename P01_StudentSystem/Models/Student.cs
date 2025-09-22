namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public required string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
