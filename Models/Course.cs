namespace WebApplication1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public ICollection<StudentCourse> Enrollement { get; set; } //Many To One relationship
    }
}
