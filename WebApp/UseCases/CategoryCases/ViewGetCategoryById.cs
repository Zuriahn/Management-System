using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewGetCategoryById : IViewGetCategoryById
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewGetCategoryById(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
