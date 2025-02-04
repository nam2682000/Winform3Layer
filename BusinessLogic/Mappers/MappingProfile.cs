using AutoMapper;
using BusinessLogic.Dtos;
using DataAccess.Entities;

namespace BusinessLogic.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Định nghĩa mapping
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
