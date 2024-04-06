using Microsoft.AspNetCore.Mvc;
using SchoolRepository.Interfaces;

namespace SchoolRepository.Controllers;

public class GroupsController : Controller
{
  private readonly IGroupsRepository _groupsRepository;

  public GroupsController(IGroupsRepository groupsRepository)
  {
    _groupsRepository = groupsRepository;
  }
  
  /// <summary>
  /// Tous les groupes
  /// </summary>
  [HttpGet]
  [Route("/v1/Groups")]
  public async Task<IActionResult> GetAll()
  {
    try
    {
      var response = await _groupsRepository.GetAll();
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  
  /// <summary>
  /// Un groupe
  /// </summary>
  [HttpGet]
  [Route("/v1/Groups/{id}")]
  public async Task<IActionResult> GetbyIdAsync(Guid id)
  {
    try
    {
      var response = await _groupsRepository.GetbyIdAsync(id);
      return Ok(response);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  
}