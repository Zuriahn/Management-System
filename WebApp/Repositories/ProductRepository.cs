using Microsoft.EntityFrameworkCore;
using WebApp.EFConfiguration;
using WebApp.Entities;
using WebApp.UseCases.Interfaces;

namespace WebApp.Repositories
{
  public class ProductRepository : IProductRepository
  {
    private readonly ApplicationDbContext _applicationDbContext;

    public ProductRepository(ApplicationDbContext applicationDbContext)
    {
      _applicationDbContext = applicationDbContext;
    }

    public async Task AddAsync(Product product)
    {
      await _applicationDbContext.AddAsync(product);
    }

    public void Update(Product product)
    {
      _applicationDbContext.Update(product);
    }

    public void Disabled(Product product)
    {
      product.IsDeleted = true;
      _applicationDbContext.Update(product);
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
      return await _applicationDbContext.Products.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<List<Product>> GetAllAsync()
    {
      return await _applicationDbContext.Products.AsNoTracking().ToListAsync();
    }

  }
}
