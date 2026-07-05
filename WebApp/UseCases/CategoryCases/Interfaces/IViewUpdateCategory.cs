using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases.Interfaces
{
  public interface IViewUpdateCategory
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(Guid id, UpdateCategoryVM category);
  }
}
