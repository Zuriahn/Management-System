using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases.Interfaces
{
  public interface IViewCreateCategory
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(CreateCategoryVM category);
  }
}
