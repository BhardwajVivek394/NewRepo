namespace WebApplication1.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }  //One To Many relationship
        public Course Course { get; set; }     //One To Many relationship
    }
}
