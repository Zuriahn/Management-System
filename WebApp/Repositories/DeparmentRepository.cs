using Microsoft.EntityFrameworkCore;
using WebApp.EFConfiguration;
using WebApp.Entities;
using WebApp.Interfaces;

namespace WebApp.Repositories
{
  public class DepartmentRepository : IDepartmentRepository
  {
    private readonly ApplicationDbContext _applicationDbContext;

    public DepartmentRepository(ApplicationDbContext applicationDbContext)
    {
      _applicationDbContext = applicationDbContext;
    }

    public async Task AddAsync(Department department)
    {
      await _applicationDbContext.AddAsync(department);
    }

    public void Update(Department department)
    {
      _applicationDbContext.Update(department);
    }

    public void Disabled(Department department)
    {
      department.IsDeleted = true;
      _applicationDbContext.Update(department);
    }

    public async Task<Department?> GetByIdAsync(Guid id)
    {
      return await _applicationDbContext.Departments.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<List<Department>> GetAllAsync()
    {
      return await _applicationDbContext.Departments.AsNoTracking().ToListAsync();
    }

  }
}
