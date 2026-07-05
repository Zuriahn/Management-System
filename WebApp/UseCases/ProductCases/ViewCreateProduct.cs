using WebApp.UseCases.Interfaces;
using WebApp.UseCases.ProductCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Entities;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases
{
  public class ViewCreateProduct : IViewCreateProduct
  {
    private readonly IProductRepository _productRepository;
    public ViewCreateProduct(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(CreateProductVM product)
    {
      if (product == null)
      {
        return Errors.Product.ProductIsEmpty;
      }

      var newProduct = new Product(
          Guid.NewGuid(),
          product.Name,
          product.Description,
          product.CategoryId
        );

      await _productRepository.AddAsync(newProduct);

      return newProduct.Id;
    }

  }
}
