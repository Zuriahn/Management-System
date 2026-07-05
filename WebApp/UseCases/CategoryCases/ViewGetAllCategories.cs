using WebApp.UseCases.CategoryCases.Interfaces;
using WebApp.UseCases.Interfaces;

namespace WebApp.UseCases.CategoryCases
{
  public class ViewGetAllCategories : IViewGetAllCategories
  {
    private readonly ICategoryRepository _categoryRepository;
    public ViewGetAllCategories(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
