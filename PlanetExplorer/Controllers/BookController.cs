using Microsoft.AspNetCore.Mvc;

namespace PlanetExplorer.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Book()
        {
            return View();
        }
    }
}
