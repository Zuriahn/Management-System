using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewUpdateCategory : IViewUpdateCategory
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewUpdateCategory(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(Guid id, UpdateCategoryVM category)
    {
      if (category == null)
      {
        return Errors.Category.CategoryIsEmpty;
      }

      var existingCategory = await _categoryRepository.GetByIdAsync(id);
      if (existingCategory == null)
      {
        return Errors.Category.NotFound;
      }

      existingCategory.Name = category.Name;

      _categoryRepository.Update(existingCategory);

      return existingCategory.Id;
    }

  }
}
