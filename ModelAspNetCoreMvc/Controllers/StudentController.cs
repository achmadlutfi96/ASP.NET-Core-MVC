using Microsoft.AspNetCore.Mvc;
using ModelAspNetCoreMvc.Models;

namespace ModelAspNetCoreMvc.Controllers
{
    public class StudentController : Controller{
        public JsonResult GetStudentDetails(int Id)
        {
            StudentRepository repository =  new StudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}