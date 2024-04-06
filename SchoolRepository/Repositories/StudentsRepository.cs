using Microsoft.EntityFrameworkCore;
using SchoolRepository.Data;
using SchoolRepository.DTO;
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

  public async Task<List<StudentDTO>> GetAll()
  {

    return await _context.Students
      .Select(student => new StudentDTO
      {
        Id = student.Id,
        Name = student.Name,
        Birthday = student.Birthday,
        Group = new GroupDTO
        {
          Id = student.Group.Id,
          Name = student.Group.Name,
        },
        Course = _context.Coursegroups
          .Where(cg => cg.GroupsId == student.GroupId)
          .SelectMany(cg => _context.Courses.Where(course => course.Id == cg.CoursesId))
          .Select(course => new CourseDTO 
          {
            Id = course.Id,
            Name = course.Name,
            Date = course.Date,
          }).ToList()
      })
      .ToListAsync();
      
  }

  public async Task<StudentDTO?> GetbyIdAsyncNoTracking(Guid id)
  {
    return await _context.Students
      .Where(student => student.Id == id)
      .Select(student => new StudentDTO
        {
          Id = student.Id,
          Name = student.Name,
          Birthday = student.Birthday,
          Group = new GroupDTO
          {
            Id = student.Group.Id,
            Name = student.Group.Name,
          }
        }
      )
      .AsNoTracking()
      .FirstOrDefaultAsync();
  }

  public Task<Student> GetbyIdAsync(Guid id)
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