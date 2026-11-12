namespace APIDemo2026AB.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
        public ICollection<Pay> Pays { get; set; }
    }

}
