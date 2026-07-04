using WebApp.Entities;

namespace WebApp.Interfaces
{
  public interface IRoleRepository
  {
    public Task AddAsync(Role role);

    public void Update(Role role);

    public void Disabled(Role role);

    public Task<Role?> GetByIdAsync(Guid id);
    public Task<List<Role>> GetAllAsync();

  }
}
