using StudentAPI.DataAccess;
using StudentAPI.Models;

namespace StudentAPI.Repo
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentDbContext _context;

        public StudentRepo()
        {
            _context = new StudentDbContext();
        }
        public StudentDTO DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<StudentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public StudentDTO Insert(StudentDTO studentDTO)
        {
            throw new NotImplementedException();
        }

        public StudentDTO Update(StudentDTO student)
        {
            throw new NotImplementedException();
        }

        void IStudentRepo.DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
