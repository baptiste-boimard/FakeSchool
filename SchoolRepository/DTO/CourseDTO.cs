namespace SchoolRepository.DTO;

public class CourseDTO
{
  public Guid Id { get; set; }
  public string? Name { get; set; } = null;
  public DateTime Date { get; set; }
  
}