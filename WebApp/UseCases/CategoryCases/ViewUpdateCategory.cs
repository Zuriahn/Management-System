using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewUpdateCategory : IViewUpdateCategory
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewUpdateCategory(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
