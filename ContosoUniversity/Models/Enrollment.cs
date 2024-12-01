namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } //primary Key 
        public int CourseID { get; set; } //foriegn key to Course 
        public int StudentID { get; set; }//foriegn key to Student
        public Grade? Grade { get; set; } /// <summary> // ? means is nullable , not graded yet 
        /// 
        /// </summary>

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
