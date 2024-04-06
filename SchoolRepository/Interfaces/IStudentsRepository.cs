using SchoolRepository.DTO;
using SchoolRepository.Models;

namespace SchoolRepository.Interfaces;

public interface IStudentsRepository
{
  Task<List<StudentDTO>> GetAll();
  Task<Student> GetbyIdAsync(Guid id);
  Task<StudentDTO?> GetbyIdAsyncNoTracking(Guid id);
  bool Add(Student student);
  bool Update(Student student);
  bool Delete(Student student);
  bool Save();
}