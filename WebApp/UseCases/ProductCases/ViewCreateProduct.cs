using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;

namespace WebApp.UseCases.ProductCases
{
  public class ViewCreateProduct : IViewCreateProduct
  {
    private readonly IProductRepository _productRepository;
    public ViewCreateProduct(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
