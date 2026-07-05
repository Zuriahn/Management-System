using WebApp.Entities;

namespace WebApp.Interfaces
{
  public interface ICategoryRepository
  {
    public Task AddAsync(Category category);

    public void Update(Category category);

    public void Disabled(Category category);

    public Task<Category?> GetByIdAsync(Guid id);
    public Task<List<Category>> GetAllAsync();

  }
}
