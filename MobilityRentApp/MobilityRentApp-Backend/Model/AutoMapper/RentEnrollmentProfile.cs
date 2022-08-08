using AutoMapper;
using MobilityRentApp_Backend.Model.Dtos.RentEnrollment;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Model.AutoMapper
{
    public class RentEnrollmentProfile : Profile
    {
        public RentEnrollmentProfile()
        {
            CreateMap<CreateRentEnrollmentDto, RentEnrollment>();
            CreateMap<UpdateRentEnrollmentDto, RentEnrollment>();
            CreateMap<RentEnrollment, RentEnrollmentDto>();
        }
    }
}
