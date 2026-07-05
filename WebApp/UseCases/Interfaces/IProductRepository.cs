using WebApp.Entities;

namespace WebApp.UseCases.Interfaces
{
  public interface IProductRepository
  {
    public Task AddAsync(Product product);

    public void Update(Product product);

    public void Disabled(Product product);

    public Task<Product?> GetByIdAsync(Guid id);
    public Task<List<Product>> GetAllAsync();

  }
}
