using StudentAPI.Models;

namespace StudentAPI.Repo
{
    public interface IStudentRepo
    {
        List<StudentDTO> GetAll();
        StudentDTO Insert(StudentDTO studentDTO);
        StudentDTO GetById(int id);
        StudentDTO Update(StudentDTO student);
        void DeleteById(int id);  
        

    }
}
