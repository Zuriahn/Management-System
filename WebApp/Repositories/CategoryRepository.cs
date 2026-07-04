using Microsoft.EntityFrameworkCore;
using WebApp.EFConfiguration;
using WebApp.Entities;
using WebApp.Interfaces;

namespace WebApp.Repositories
{
  public class CategoryRepository : ICategoryRepository
  {
    private readonly ApplicationDbContext _applicationDbContext;

    public CategoryRepository(ApplicationDbContext applicationDbContext)
    {
      _applicationDbContext = applicationDbContext;
    }

    public async Task AddAsync(Category category)
    {
      await _applicationDbContext.AddAsync(category);
    }

    public void Update(Category category)
    {
      _applicationDbContext.Update(category);
    }

    public void Disabled(Category category)
    {
      category.IsDeleted = true;
      _applicationDbContext.Update(category);
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
      return await _applicationDbContext.Categories.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<List<Category>> GetAllAsync()
    {
      return await _applicationDbContext.Categories.AsNoTracking().ToListAsync();
    }

  }
}
