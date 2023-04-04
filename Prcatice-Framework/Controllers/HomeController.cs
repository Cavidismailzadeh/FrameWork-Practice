using Microsoft.AspNetCore.Mvc;



namespace Prcatice_Framework.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}