using AutoMapper;
using MobilityRentApp_Backend.Model.Dtos.Role;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Model.AutoMapper
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();
            CreateMap<Role, RoleDto>();
        }
    }
}
