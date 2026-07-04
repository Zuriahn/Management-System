using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
  public class RoleController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
