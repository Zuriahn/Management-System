using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
  public class TicketController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
