using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Entities;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewCreateCategory : IViewCreateCategory
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewCreateCategory(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(CreateCategoryVM category)
    {
      if (category == null)
      {
        return Errors.Category.CategoryIsEmpty;
      }

      var newCategory = new Category(
          Guid.NewGuid(),
          category.Name
        );

      await _categoryRepository.AddAsync(newCategory);

      return newCategory.Id;
    }

  }
}
