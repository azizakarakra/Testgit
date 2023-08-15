namespace Task5.Service.Student
{
    public interface IStudentService
    {
        Task<List<Tables.Student>> GetAll();
        Task<Tables.Student> GetById(int id);
    }
}
