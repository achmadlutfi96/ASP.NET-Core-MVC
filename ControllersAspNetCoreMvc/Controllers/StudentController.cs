using Microsoft.AspNetCore.Mvc;

namespace ControllersAspNetCoreMvc.Controllers
{
    public class StudentController : Controller{
        // public IActionResult Index(){
        //     return View();
        // }
        public string GetAllStudents(){
            return "Return All Students";
        }

        public string GetStudentsByName(string name){
            return $"Return All Students with Name : {name}";
        }
    }    
}