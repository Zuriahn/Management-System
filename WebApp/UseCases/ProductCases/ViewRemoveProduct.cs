using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;

namespace WebApp.UseCases.ProductCases
{
  public class ViewRemoveProduct : IViewRemoveProduct
  {
    private readonly IProductRepository _productRepository;
    public ViewRemoveProduct(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(Guid id)
    {
      var product = await _productRepository.GetByIdAsync(id);
      if (product == null)
      {
        return Errors.Product.NotFound;
      }

      _productRepository.Disabled(product);

      return product.Id;
    }

  }
}
