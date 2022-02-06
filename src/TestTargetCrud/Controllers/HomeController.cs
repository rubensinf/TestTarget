using Microsoft.AspNetCore.Mvc;

namespace TestTargetCrud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
