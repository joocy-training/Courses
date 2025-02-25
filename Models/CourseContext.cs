using Microsoft.EntityFrameworkCore;

namespace Courses.Models;

public class CourseContext(DbContextOptions<CourseContext> options) : DbContext(options)
{
    public DbSet<Course> Courses { get; set; } = null!;
}