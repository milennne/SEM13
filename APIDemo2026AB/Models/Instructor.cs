namespace APIDemo2026AB.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
