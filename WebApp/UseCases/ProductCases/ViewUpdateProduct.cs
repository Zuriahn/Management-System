using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases
{
  public class ViewUpdateProduct : IViewUpdateProduct
  {
    private readonly IProductRepository _productRepository;
    public ViewUpdateProduct(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(Guid id, UpdateProductVM product)
    {
      if (product == null)
      {
        return Errors.Product.ProductIsEmpty;
      }

      var existingProduct = await _productRepository.GetByIdAsync(id);
      if (existingProduct == null)
      {
        return Errors.Product.NotFound;
      }

      existingProduct.Name = product.Name;
      existingProduct.Description = product.Description;
      existingProduct.CategoryId = product.CategoryId;

      _productRepository.Update(existingProduct);

      return existingProduct.Id;
    }

  }
}
