using SchoolRepository.Models;

namespace SchoolRepository.DTO;

public class GroupDTO
{
  public Guid Id { get; set; }
  public string? Name { get; set; } = null;
  public IEnumerable<Course> Courses { get; set; }
}