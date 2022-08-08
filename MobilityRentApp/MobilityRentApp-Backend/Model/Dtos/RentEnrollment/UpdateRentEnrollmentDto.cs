using MobilityRentApp_Backend.Model.Base;

namespace MobilityRentApp_Backend.Model.Dtos.RentEnrollment
{
    public class UpdateRentEnrollmentDto : CreateRentEnrollmentDto, IHasId
    {
        public int Id { get; set; }
    }
}
