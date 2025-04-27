using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class TodoController : Controller
    {
        [Route("/todoHome")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/todoAdd")]
        public IActionResult Add()
        {
            return View();
        }
        [Route("/todoEdit")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
