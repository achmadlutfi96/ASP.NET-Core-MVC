namespace SingletonVsScopedVsTransientServicesInAspNetCore.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
        List<Student> GetAllStudent();
    }
}