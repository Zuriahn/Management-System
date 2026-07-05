using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases.Interfaces
{
  public interface IViewCreateProduct
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(CreateProductVM product);
  }
}
