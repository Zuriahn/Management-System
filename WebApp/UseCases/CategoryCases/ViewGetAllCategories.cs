using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewGetAllCategories : IViewGetAllCategories
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewGetAllCategories(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<List<CategoryVM>>> ExecuteAsync()
    {
      var categories = await _categoryRepository.GetAllAsync();

      var categoryVMs = categories.Select(c => new CategoryVM(
        c.Id,
        c.Name
      )).ToList();

      return categoryVMs;
    }

  }
}
