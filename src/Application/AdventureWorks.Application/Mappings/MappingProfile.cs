using AdventureWorks.Application.Features.Humanresources.Queries.Department;
using AdventureWorks.Application.Features.Humanresources.Queries.Shift;
using AdventureWorks.Domain.Entities;
using AutoMapper;

namespace AdventureWorks.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentVm>().ReverseMap();
            CreateMap<Shift, ShiftVm>().ReverseMap();            
        }
    }
}
