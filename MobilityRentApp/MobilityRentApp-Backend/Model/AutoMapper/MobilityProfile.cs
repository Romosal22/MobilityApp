using AutoMapper;
using MobilityRentApp_Backend.Model.Dtos.Mobility;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Model.AutoMapper
{
    public class MobilityProfile : Profile
    {
        public MobilityProfile()
        {
            CreateMap<CreateMobilityDto, Mobility>();
            CreateMap<UpdateMobilityDto, Mobility>();
            CreateMap<Mobility, MobilityDto>();
        }
    }
}
