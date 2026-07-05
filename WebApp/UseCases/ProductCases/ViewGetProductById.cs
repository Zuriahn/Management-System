using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases
{
  public class ViewGetProductById : IViewGetProductById
  {
    private readonly IProductRepository _productRepository;
    public ViewGetProductById(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<ErrorOr<ProductVM>> ExecuteAsync(Guid id)
    {
      var product = await _productRepository.GetByIdAsync(id);
      if (product == null)
      {
        return Errors.Product.NotFound;
      }

      var productVM = new ProductVM(
        product.Id,
        product.Name,
        product.Description,
        product.CategoryId
      );

      return productVM;
    }

  }
}
