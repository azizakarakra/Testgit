namespace Task5.Service.StudentCourse
{
    public interface IStudentCourseService
    {
        Task<List<Tables.StudentCourse>> GetAll();
        Task<Tables.StudentCourse> GetById(int id);
    }
}
