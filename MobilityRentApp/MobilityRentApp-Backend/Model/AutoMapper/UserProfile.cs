using AutoMapper;
using MobilityRentApp_Backend.Model.Dtos.User;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Model.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
