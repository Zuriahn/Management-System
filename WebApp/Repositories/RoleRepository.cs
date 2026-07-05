using Microsoft.EntityFrameworkCore;
using WebApp.EFConfiguration;
using WebApp.Entities;
using WebApp.UseCases.Interfaces;

namespace WebApp.Repositories
{
  public class RoleRepository : IRoleRepository
  {
    private readonly ApplicationDbContext _applicationDbContext;

    public RoleRepository(ApplicationDbContext applicationDbContext)
    {
      _applicationDbContext = applicationDbContext;
    }

    public async Task AddAsync(Role role)
    {
      await _applicationDbContext.AddAsync(role);
    }

    public void Update(Role role)
    {
      _applicationDbContext.Update(role);
    }

    public void Disabled(Role role)
    {
      role.IsDeleted = true;
      _applicationDbContext.Update(role);
    }

    //public async Task<Role?> GetByIdAsync(Guid id)
    //{
    //  return await _applicationDbContext.Roles.SingleOrDefaultAsync(u => u.Id == id);
    //}

    //public async Task<List<Role>> GetAllAsync()
    //{
    //  return await _applicationDbContext.Roles.AsNoTracking().ToListAsync();
    //}

  }
}
