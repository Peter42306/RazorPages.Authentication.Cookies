using Microsoft.EntityFrameworkCore;

namespace RazorPages.Authentication.Cookies.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                Students.Add(new Student { Name = "Иван", Surname = "Иванов", Age = 20, GPA = 10.5 });
                Students.Add(new Student { Name = "Сергей", Surname = "Сергеев", Age = 23, GPA = 11.5 });
                Students.Add(new Student { Name = "Петр", Surname = "Петров", Age = 25, GPA = 12 });
                SaveChanges();
            }
        }
    }
}
