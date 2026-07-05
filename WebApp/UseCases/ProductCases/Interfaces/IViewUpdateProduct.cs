using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases.Interfaces
{
  public interface IViewUpdateProduct
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(Guid id, UpdateProductVM product);
  }
}
