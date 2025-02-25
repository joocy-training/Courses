namespace Courses.Models;

public enum CourseLevel
{
    Beginner,
    Intermediate,
    Advanced
}
public class Course
{
    public long Id { get; set; }
    public string Code { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public CourseLevel Level { get; set; }
}