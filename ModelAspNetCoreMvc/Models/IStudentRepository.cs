namespace ModelAspNetCoreMvc.Models
{
    public interface IStudentRepository{
        Student GetStudentById(int StudentId);
    }
}