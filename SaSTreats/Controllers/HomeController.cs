using Microsoft.AspNetCore.Mvc;

namespace SaSTreats.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}