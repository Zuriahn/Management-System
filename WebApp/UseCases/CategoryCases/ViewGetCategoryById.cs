using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewGetCategoryById : IViewGetCategoryById
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewGetCategoryById(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<CategoryVM>> ExecuteAsync(Guid id)
    {
      var category = await _categoryRepository.GetByIdAsync(id);
      if (category == null)
      {
        return Errors.Category.NotFound;
      }

      var categoryVM = new CategoryVM(
        category.Id,
        category.Name
      );

      return categoryVM;
    }

  }
}
