using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Dtos.RentEnrollment
{
    public class CreateRentEnrollmentDto
    {
        public double TotalCost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public Boolean IsActive { get; set; }
    }
}
