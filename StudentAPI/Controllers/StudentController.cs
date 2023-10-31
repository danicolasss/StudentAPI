using Microsoft.AspNetCore.Mvc;
using StudentAPI.Properties;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MapperConfig mapperConfig;

        public StudentController(MapperConfig mapperConfig)
        {

        }

    }
}
