namespace SchoolRepository.DTO;

public class StudentArrayDTO
{
  public Guid Id { get; set; }
  public string? Name { get; set; } = null;
  public string? Surname { get; set; } = null;
  public DateTime Birthday { get; set; }
  public GroupWithoutCoursesDTO Group { get; set; }
}