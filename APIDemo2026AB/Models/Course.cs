namespace APIDemo2026AB.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationHours { get; set; }
        public int InstructorId { get; set; }
        public bool IsActive { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
