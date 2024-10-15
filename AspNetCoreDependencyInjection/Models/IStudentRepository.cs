using System.Collections.Generic;

namespace AspNetCoreDependencyInjection.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
        List<Student> GetAllStudent();
    }
}