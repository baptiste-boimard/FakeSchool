using Microsoft.EntityFrameworkCore;
using SchoolRepository.Controllers;
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

  public static StudentDTO ToDTO(Student student, Group group, IEnumerable<Course> courses)
  {
    return (new StudentDTO
    {
      Id = student.Id,
      Name = student.Name,
      Surname = student.Surname,
      Group = GroupsRepository.ToDTO(group, courses)
    });
  }
  
  public IEnumerable<StudentDTO> GetAll()
  {
    var r = _context.Students.Join(_context.Groups, i => i.GroupId, i => i.Id, (s, g) => new
      {
        Student = s,
        Group = g
      })
      .Select(i => new
      {
        Student = i.First().Student,
        Group = i.First().Group,
      }).Select(i => ToDTO(i.Student, i.Group, null))
      .OrderBy(i => i.Student.Id);

    return r;
  }

  public async Task<IEnumerable<StudentDTO>> GetbyIdAsyncNoTracking(Guid id)
  {
    var r =  _context.Students
      .Where(i => i.Id == id)
      .Join(_context.Groups, i => i.GroupId, i => i.Id, ((s, g) => new
      {
        Student = s,
        Group = g,
      }))
      .Join(_context.Coursegroups, i => i.Group.Id, i => i.GroupsId, (i, cg) => new
      {
        i.Student,
        i.Group,
        Coursegroup = cg,
      })
      .Join(_context.Courses, i => i.Coursegroup.CoursesId, i => i.Id, (i, c) => new
      {
        Student = i.Student,
        Group = i.Group,
        Courses = c,
      })
      .GroupBy(i => i.Student.Id)
      .ToArray()
      .Select(i => new
      {
        Student = i.First().Student,
        Group = i.First().Group,
        Courses = i.Select(i => i.Courses)
      })
      .Select(i => ToDTO(i.Student, i.Group, i.Courses));
    
    return r;

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