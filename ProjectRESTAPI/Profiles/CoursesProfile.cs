using AutoMapper;

namespace ProjectRESTAPI.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Dtos.CourseCreateDto, Models.Course>(); 
            CreateMap<Models.Course, Dtos.CourseCreateDto>();
            CreateMap<Dtos.CourseDto, Models.Course>();
            CreateMap<Models.Course, Dtos.CourseDto>();
        }
    }
}
