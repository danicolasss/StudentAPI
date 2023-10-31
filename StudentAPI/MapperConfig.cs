using AutoMapper;
using StudentAPI.Entity;
using StudentAPI.Models;
namespace AutoMapper
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}