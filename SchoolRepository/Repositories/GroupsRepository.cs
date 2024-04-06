using Microsoft.EntityFrameworkCore;
using SchoolRepository.Data;
using SchoolRepository.Interfaces;
using SchoolRepository.Models;

namespace SchoolRepository.Repositories;

public class GroupsRepository : IGroupsRepository
{
  private readonly FakeschoolContext _context;

  public GroupsRepository(FakeschoolContext context)
  {
    _context = context;
  }

  public async Task<IEnumerable<Group>> GetAll()
  {
    return await _context.Groups.OrderBy(i => i.Id).ToListAsync();
  }

  public async Task<Group> GetbyIdAsync(Guid id)
  {
    return await _context.Groups.FirstOrDefaultAsync(i => i.Id == id);
  }

  public Task<Group> GetbyIdAsyncNoTracking(Guid Id)
  {
    throw new NotImplementedException();
  }

  public bool Add(Group group)
  {
    throw new NotImplementedException();
  }

  public bool Update(Group group)
  {
    throw new NotImplementedException();
  }

  public bool Delete(Group group)
  {
    throw new NotImplementedException();
  }

  public bool Save()
  {
    throw new NotImplementedException();
  }
}