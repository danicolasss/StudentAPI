
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.DataAccess;
using StudentAPI.Entity;
using StudentAPI.Models;
using System.Collections.Generic;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MapperConfig mapperConfig;

        public StudentController( MapperConfig mapperConfig)
        {

        }

    }
}
