using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewCreateCategory : IViewCreateCategory
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewCreateCategory(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
