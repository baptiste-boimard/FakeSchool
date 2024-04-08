using Microsoft.EntityFrameworkCore;
using SchoolRepository.Data;
using SchoolRepository.DTO;
using SchoolRepository.Interfaces;
using SchoolRepository.Models;

namespace SchoolRepository.Repositories;

public class CoursesRepository : ICoursesRepository
{
  private readonly FakeschoolContext _context;

  public CoursesRepository(FakeschoolContext context)
  {
    _context = context;
  }
  public async Task<List<Course>> GetAll()
  {
    return await _context.Courses.ToListAsync();
  }

  public async Task<Course> GetbyIdAsync(Guid id)
  {
    return await _context.Courses.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
  }

  public Task<Course> GetbyIdAsyncNoTracking(Guid Id)
  {
    throw new NotImplementedException();
  }

  public bool Add(Course course)
  {
    throw new NotImplementedException();
  }

  public bool Update(Course course)
  {
    throw new NotImplementedException();
  }

  public bool Delete(Course course)
  {
    throw new NotImplementedException();
  }

  public bool Save()
  {
    throw new NotImplementedException();
  }

  public static CourseDTO ToDTO(Course course)
  {
    return (new CourseDTO
    {
      Id = course.Id,
      Name = course.Name,
      Date = course.Date
    });
  }
}