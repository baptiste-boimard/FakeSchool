using Microsoft.AspNetCore.Mvc;
using SchoolRepository.Interfaces;
using SchoolRepository.Models;

namespace SchoolRepository.Controllers;

public class CoursesController : Controller
{
  private readonly ICoursesRepository _coursesRepository;

  public CoursesController(ICoursesRepository coursesRepository)
  {
    _coursesRepository = coursesRepository;
  }
  
  /// <summary>
  /// Tous les cours
  /// </summary>
  [HttpGet]
  [Route("/v1/Courses")]
  public async Task<IActionResult> GetAll()
  {
    try
    {
      var response = await _coursesRepository.GetAll();
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  
  /// <summary>
  /// Un cour
  /// </summary>
  [HttpGet]
  [Route("/v1/Courses/{id}")]
  public async Task<IActionResult> GetbyIdAsync(Guid id)
  {
    try
    {
      var response = await _coursesRepository.GetbyIdAsync(id);
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  
  
  
  
}