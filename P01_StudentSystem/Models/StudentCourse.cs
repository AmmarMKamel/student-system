namespace P01_StudentSystem.Models
{
    internal class StudentCourse
    {
        public int StudentsId { get; set; }
        public int CoursesId { get; set; }
        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
