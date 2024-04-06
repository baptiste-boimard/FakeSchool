using Microsoft.AspNetCore.Mvc;

namespace SchoolRepository.Controllers;

public class StudentController : Controller
{
  private readonly IStudentRepository _studentRepository;

  public StudentController(IStudentRepository studentRepository)
  {
    _studentRepository = studentRepository;
  }
  
  /// <summary>
  /// Information sur l'état de l'API
  /// </summary>
  [HttpGet]
  [Route("/v1/Students")]
  public async Task<IActionResult> GetAll()
  {
    try
    {
      var response = await _studentRepository.GetAll();
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
}