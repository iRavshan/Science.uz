using AutoMapper;
using Science.DTO.Student;

namespace Science.Utility.MappingProfiles.Student
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentCreationDto, Entity.Student>()
                      .ForMember(
                           dest => dest.Id,
                           opt => opt.MapFrom(src => Guid.NewGuid())
                       )
                       .ForMember(
                           dest => dest.PhoneNumber,
                           opt => opt.MapFrom(src => string.Empty)
                       );
        }
    }
}
