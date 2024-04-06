using Microsoft.EntityFrameworkCore;
using SchoolRepository.Data;
using SchoolRepository.Models;

namespace SchoolRepository.Repositories;

public class StudentRepository : IStudentRepository
{
  private readonly FakeschoolContext _context;

  public StudentRepository(FakeschoolContext context)
  {
    _context = context;
  }
  public async Task<IEnumerable<Student>> GetAll()
  {
    return await _context.Students.Include(s => s.Group).FirstOrDefaultAsync(s => s.Id == StudentId);

  public Task<Student> GetbyIdAsync(Guid Id)
  {
    throw new NotImplementedException();
  }

  public Task<Student> GetbyIdAsyncNoTracking(Guid Id)
  {
    throw new NotImplementedException();
  }

  public bool Add(Student student)
  {
    throw new NotImplementedException();
  }

  public bool Update(Student student)
  {
    throw new NotImplementedException();
  }

  public bool Delete(Student student)
  {
    throw new NotImplementedException();
  }

  public bool Save()
  {
    throw new NotImplementedException();
  }
}