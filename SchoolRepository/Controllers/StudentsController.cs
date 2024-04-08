using Microsoft.AspNetCore.Mvc;
using SchoolRepository.DTO;
using SchoolRepository.Interfaces;
using SchoolRepository.Repositories;

namespace SchoolRepository.Controllers;

public class StudentsController : Controller
{
  private readonly StudentsRepository _studentsRepository;

  public StudentsController(StudentsRepository studentsRepository)
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
      var response =  _studentsRepository.GetAll();
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