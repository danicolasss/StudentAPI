using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.DataAccess
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet<StudentDTO> StudentsDTO { get; set; }
    }
}
