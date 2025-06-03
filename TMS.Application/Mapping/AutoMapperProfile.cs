using AutoMapper;
using TMS.Application.DTOs;
using TMS.Domain.Entities;

namespace TMS.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Team, TeamDto>().ReverseMap();

        }
    }
}
