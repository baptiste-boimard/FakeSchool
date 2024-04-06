using Microsoft.AspNetCore.Mvc;
using SchoolRepository.Interfaces;

namespace SchoolRepository.Controllers;

public class StudentsController : Controller
{
  private readonly IStudentsRepository _studentsRepository;

  public StudentsController(IStudentsRepository studentsRepository)
  {
    _studentsRepository = studentsRepository;
  }
  
  /// <summary>
  /// Tous les étudiants
  /// </summary>
  [HttpGet]
  [Route("/v1/Students")]
  public async Task<IActionResult> GetAll()
  {
    try
    {
      var response = await _studentsRepository.GetAll();
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  
  /// <summary>
  /// Un étudiant
  /// </summary>
  [HttpGet]
  [Route("/v1/Students/{id}")]
  public async Task<IActionResult> GetbyIdAsyncNoTracking(Guid id)
  {
    try
    {
      var response = await _studentsRepository.GetbyIdAsyncNoTracking(id);
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
}