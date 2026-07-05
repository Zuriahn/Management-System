using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.ProductCases.Interfaces
{
  public interface IViewGetAllProducts
  {
    public Task<ErrorOr<List<ProductVM>>> ExecuteAsync();
  }
}
