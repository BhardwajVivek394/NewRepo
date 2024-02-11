using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course>Courses { get; set; }
    }
}
