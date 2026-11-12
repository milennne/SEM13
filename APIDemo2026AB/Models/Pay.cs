namespace APIDemo2026AB.Models
{
    public class Pay
    {
        public int PayId { get; set; }
        public int EnrollmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }

        public Enrollment Enrollment { get; set; }
    }

}
