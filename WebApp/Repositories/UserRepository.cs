using WebApp.UseCases.Interfaces;
using WebApp.EFConfiguration;
using WebApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly ApplicationDbContext _applicationDbContext;

    public UserRepository(ApplicationDbContext applicationDbContext) 
    {
      _applicationDbContext = applicationDbContext;
    }

    public async Task AddAsync(User user)
    {
        await _applicationDbContext.AddAsync(user);
    }

    public void Update(User user)
    {
       _applicationDbContext.Update(user);
    }

    public void Disabled(User user)
    {
       user.IsDeleted = true;
      _applicationDbContext.Update(user);
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
      return await _applicationDbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
      return await _applicationDbContext.Users.SingleOrDefaultAsync(u => u.Email == email);
    }

    public async Task<List<User>> GetAllAsync()
    {
      return await _applicationDbContext.Users.AsNoTracking().ToListAsync();
    }

  }
}
