using AR.Domain.DTO;
using AR.Domain.Entities;
using AutoMapper;

namespace AR.Domain.Mappings
{
    public class EntityToDTOMappingProfile : Profile
    {
        public EntityToDTOMappingProfile()
        {
            CreateMap<EmployeeCLT, EmployeeCltDTO>().ReverseMap();
            CreateMap<EmployeePJ, EmployeePjDTO>().ReverseMap();
        }
    }
}
