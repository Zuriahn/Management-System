using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;

namespace WebApp.UseCases.ProductCases
{
  public class ViewGetProductById : IViewGetProductById
  {
    private readonly IProductRepository _productRepository;
    public ViewGetProductById(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
