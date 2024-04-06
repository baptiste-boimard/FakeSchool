using SchoolRepository.Models;

namespace SchoolRepository;

public interface IGroupsRepository
{
  Task<IEnumerable<Group>> GetAll();
  Task<Group> GetbyIdAsync(Guid Id);
  Task<Group> GetbyIdAsyncNoTracking(Guid Id);
  bool Add(Group group);
  bool Update(Group group);
  bool Delete(Group group);
  bool Save();
}