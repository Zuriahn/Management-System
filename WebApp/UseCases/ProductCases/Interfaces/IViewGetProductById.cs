using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases.Interfaces
{
  public interface IViewGetProductById
  {
    public Task<ErrorOr<ProductVM>> ExecuteAsync(Guid id);
  }
}
