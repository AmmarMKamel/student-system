namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Resource> Resources { get; } = new List<Resource>();
        public ICollection<Homework> HomeworkSubmissions { get; } = new List<Homework>();
        public ICollection<Student> StudentsEnrolled { get; set; } = new List<Student>();
    }
}
