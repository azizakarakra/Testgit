namespace Task5.Service.Course
{
    public interface ICourseService
    {
        Task<List<Tables.Course>> GetAll();
        Task<Tables.Course> GetById(int id);
    }
}
