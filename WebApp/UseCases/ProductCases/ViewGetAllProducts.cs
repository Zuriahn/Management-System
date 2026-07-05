using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases
{
  public class ViewGetAllProducts : IViewGetAllProducts
  {
    private readonly IProductRepository _productRepository;
    public ViewGetAllProducts(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<ErrorOr<List<ProductVM>>> ExecuteAsync()
    {
      var products = await _productRepository.GetAllAsync();

      var productVMs = products.Select(p => new ProductVM(
        p.Id,
        p.Name,
        p.Description,
        p.CategoryId
      )).ToList();

      return productVMs;
    }

  }
}
