using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
  public class DepartmentController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
