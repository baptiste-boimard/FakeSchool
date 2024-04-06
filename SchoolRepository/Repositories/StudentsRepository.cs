using Microsoft.EntityFrameworkCore;
using SchoolRepository.Data;
using SchoolRepository.Interfaces;
using SchoolRepository.Models;

namespace SchoolRepository.Repositories;

public class StudentsRepository : IStudentsRepository
{
  private readonly FakeschoolContext _context;

  public StudentsRepository(FakeschoolContext context)
  {
    _context = context;
  }

  public async Task<IEnumerable<Student>> GetAll()
  {
    return await _context.Students.Include(i => i.Group).OrderBy(i => i.Id).ToListAsync();
  }

  public async Task<Student> GetbyIdAsyncNoTracking(Guid id)
  {
    return await _context.Students.Include(i => i.Group).AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
  }

  public Task<Student> GetbyIdAsync(Guid Id)
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