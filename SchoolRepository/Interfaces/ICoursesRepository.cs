using SchoolRepository.DTO;
using SchoolRepository.Models;

namespace SchoolRepository.Interfaces;

public interface ICoursesRepository
{
  Task<List<Course>> GetAll();
  Task<Course> GetbyIdAsync(Guid Id);
  Task<Course> GetbyIdAsyncNoTracking(Guid Id);
  bool Add(Course course);
  bool Update(Course course);
  bool Delete(Course course);
  bool Save();
}