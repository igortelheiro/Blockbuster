using Microsoft.AspNetCore.Mvc;

namespace Blockbuster.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
