using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases.Interfaces
{
  public interface IViewGetCategoryById
  {
    public Task<ErrorOr<CategoryVM>> ExecuteAsync(Guid id);
  }
}
