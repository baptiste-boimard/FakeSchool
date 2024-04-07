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

  public async Task<List<Student>> GetAll()
  {

    // return await _context.Students
      // .Select(student => new StudentDTO
      // {
      //   Id = student.Id,
      //   // Group = student.Group
      //   Group = _context.Groups.Where(group => group.Id == student.GroupId).FirstOrDefault(),
      //   Courses = _context.Coursegroups
      //     .Where( c=> c.GroupsId = student.GroupId)
      //     .Join(_context.Courses, cg=> cg.CoursesId, c=> c.Id, (cg,c) => new Course
      //     {
      //       Id = c.Id
      //     }).ToList()
      // }).ToListAsync<StudentDTO>();

      // var query = from student in _context.Students
      //   join coursegroup in _context.Coursegroups on student.GroupId equals coursegroup.GroupsId
      //   join course in _context.Courses on coursegroup.CoursesId equals course.Id
      //   select new StudentDTO
      //   {
      //     Id = student.Id,
      //     Name = student.Name,
      //     Courses = course,
      //   };
      //
      // var result =  await query.ToListAsync();
      // return result;
      
      var blogs = await _context.Students.FromSqlRaw(
        "SELECT * FROM students"
        // "SELECT * FROM students AS s JOIN courseGroup AS cg ON s.GroupId = cg.GroupsId "
        // "SELECT s.id, c.name FROM students AS s JOIN coursegroup AS cg ON s.GroupId = cg.GroupsId JOIN courses AS c ON cg.CoursesId = c.Id "
        
        
        ).ToListAsync();
      return blogs;


      // return await _context.Students
      //   .Select(student => new StudentDTO
      //   {
      //     Id = student.Id,
      //     Name = student.Name,
      //     Birthday = student.Birthday,
      //     Group = _context.Groups
      //       .Where(g => g.Id == student.GroupId).Select( g => new GroupDTO
      //       {
      //         Id = g.Id,
      //       }).FirstOrDefault(),
      //     Courses = _context.Coursegroups
      //       .Where(cg => cg.Id == student.GroupId)
      //       .Select(c => new CourseDTO
      //       {
      //         Id = c.Id
      //       })
      // Course = _context.Coursegroups
      //   .Where(cg => cg.GroupsId == student.GroupId)
      //   .SelectMany(cg => _context.Courses.Where(course => course.Id == cg.CoursesId))
      //   .Select(course => new CourseDTO 
      //   {
      //     Id = course.Id,
      //     Name = course.Name,
      //     Date = course.Date,
      //   }).ToList()
      // })
      // .ToListAsync();


      // return await _context.Students
      //   .Include(student => student.Group)
      //   .ToListAsync();


      // .Select(student => new StudentDTO
      // {
      //   Id = student.Id,
      //   Name = student.Name,
      //   Birthday = student.Birthday,
      //   Group = _context.Groups
      //     .Where(g => g.Id == student.GroupId)
      //     .Select(group => new GroupDTO
      //     {
      //       Id = student.Group.Id,
      //       Name = student.Group.Name,
      //     }),
      // Course = _context.Coursegroups
      //   .Where(cg => cg.GroupsId == student.GroupId)
      //   .SelectMany(cg => _context.Courses.Where(course => course.Id == cg.CoursesId))
      //   .Select(course => new CourseDTO 
      //   {
      //     Id = course.Id,
      //     Name = course.Name,
      //     Date = course.Date,
      //   }).ToList()
      // })
      // .ToListAsync();
      //
  }

  public async Task<StudentDTO?> GetbyIdAsyncNoTracking(Guid id)
  {
    return null;
    // return await _context.Students
    //   .Where(student => student.Id == id)
    //   .Select(student => new StudentDTO
    //     {
    //       Id = student.Id,
    //       Name = student.Name,
    //       Birthday = student.Birthday,
    //       Group = new GroupDTO
    //       {
    //         Id = student.Group.Id,
    //         Name = student.Group.Name,
    //       }
    //     }
    //   )
    //   .AsNoTracking()
    //   .FirstOrDefaultAsync();
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