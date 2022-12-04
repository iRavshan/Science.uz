using AutoMapper;
using Science.DTO.Student;

namespace Science.Utility.AutoMapperProfiles.Student
{
    public class StudentMappingProfiles : Profile
    {
        public StudentMappingProfiles() 
        {
            CreateMap<StudentDto, Science.Entity.Student>().ReverseMap();
            CreateMap<StudentCreationDto, Science.Entity.Student>()
               .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => Guid.NewGuid())
                )
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.Firstname}")
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => $"{src.Lastname}")
                );
  
        }
    }
}
