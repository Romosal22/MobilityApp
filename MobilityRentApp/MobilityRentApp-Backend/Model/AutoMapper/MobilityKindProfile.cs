using AutoMapper;
using MobilityRentApp_Backend.Model.Dtos.MobilityKind;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Model.AutoMapper
{
    public class MobilityKindProfile : Profile
    {
        public MobilityKindProfile()
        {
            CreateMap<CreateMobilityKindDto, MobilityKind>();
            CreateMap<UpdateMobilityKindDto, MobilityKind>();
            CreateMap<MobilityKind, MobilityKindDto>();
        }
    }
}
