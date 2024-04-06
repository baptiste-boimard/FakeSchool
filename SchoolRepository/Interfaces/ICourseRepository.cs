using SchoolRepository.Models;

namespace SchoolRepository;

public interface ICourseRepository
{
  Task<IEnumerable<Course>> GetAll();
  Task<Course> GetbyIdAsync(Guid Id);
  Task<Course> GetbyIdAsyncNoTracking(Guid Id);
  bool Add(Course course);
  bool Update(Course course);
  bool Delete(Course course);
  bool Save();
}