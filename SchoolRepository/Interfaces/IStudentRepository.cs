using SchoolRepository.Models;

namespace SchoolRepository;

public interface IStudentRepository
{
  Task<IEnumerable<Student>> GetAll();
  Task<Student> GetbyIdAsync(Guid Id);
  Task<Student> GetbyIdAsyncNoTracking(Guid Id);
  bool Add(Student student);
  bool Update(Student student);
  bool Delete(Student student);
  bool Save();
}