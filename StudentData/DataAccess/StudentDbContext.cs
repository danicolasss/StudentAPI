using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.DataAccess
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet<StudentDTO> StudentsDTO { get; set; }
    }
}
