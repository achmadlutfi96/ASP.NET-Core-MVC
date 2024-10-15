using Microsoft.AspNetCore.Mvc;

namespace ViewsAspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
            // return View("Test");
            // return View("Views/Home/Test.cshtml");
        }

        public ViewResult About()
        {
            return View();
        }
    }
}