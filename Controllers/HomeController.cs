using Microsoft.AspNetCore.Mvc;
namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View("projects");
        }

        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View("contact");
        }
    }
}