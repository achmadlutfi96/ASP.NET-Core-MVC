using AspNetCoreDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        // Create a reference variable of IStudentRepository
        private readonly IStudentRepository? _repository = null;

        // Initialize the variable through constructor
        public HomeController(IStudentRepository repository){
            _repository = repository; // This is called Constructor Dependency Injection
        }

        public JsonResult Index(){
            // StudentRepository repository = new StudentRepository();
            // List<Student> allStudentDetails = repository.GetAllStudent();
            List<Student>? allStudentDetails = _repository?.GetAllStudent();
            return Json(allStudentDetails);
        }

        // This is called Method Dependency Injection
        // public JsonResult Index([FromServices] IStudentRepository repository)
        // {
        //     List<Student> allStudentDetails = repository.GetAllStudent();
        //     return Json(allStudentDetails);
        // }

        public JsonResult GetStudentDetails(int Id)
        {
            // StudentRepository repository = new StudentRepository();
            // Student studentDetails = repository.GetStudentById(Id);
            Student? studentDetails = _repository?.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}