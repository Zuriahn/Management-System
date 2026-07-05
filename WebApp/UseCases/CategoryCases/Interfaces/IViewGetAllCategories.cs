using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases.Interfaces
{
  public interface IViewGetAllCategories
  {
    public Task<ErrorOr<List<CategoryVM>>> ExecuteAsync();
  }
}
