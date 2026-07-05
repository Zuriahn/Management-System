using WebApp.Entities;

namespace WebApp.UseCases.Interfaces
{
  public interface IUserRepository
  {
    public Task AddAsync(User user);

    public void Update(User user);

    public void Disabled(User user);

    public Task<User?> GetByIdAsync(Guid id);

    public Task<User?> GetByEmailAsync(string email);

    public Task<List<User>> GetAllAsync();

  }
}
