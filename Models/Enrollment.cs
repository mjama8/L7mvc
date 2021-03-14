namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        // Assigning integers and declaring different items for later use
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        // The ? after the Grade type declaration indicates that the Grade property is nullable.
        // It can be null in the database
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}