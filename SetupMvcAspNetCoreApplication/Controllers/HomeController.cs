using Microsoft.AspNetCore.Mvc;

namespace SetupMvcAspNetCoreApplication
{
    public class HomeController : Controller
    {
        public string Index(){
            return "This is Index action from MVC Controller";
        }
    }
}