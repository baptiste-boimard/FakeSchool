using SchoolRepository.Models;

namespace SchoolRepository.DTO;

public class StudentDTO
{
  public Guid Id { get; set; }
  public string? Name { get; set; } = null;
  public string? Surname { get; set; } = null;
  public DateTime Birthday { get; set; }
  public GroupDTO? Group { get; set; }
  public List<CourseDTO>? Course { get; set; }
}