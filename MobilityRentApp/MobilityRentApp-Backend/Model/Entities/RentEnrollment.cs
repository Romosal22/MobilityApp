using MobilityRentApp_Backend.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobilityRentApp_Backend.Model.Entities
{
    public class RentEnrollment : IHasId
    {
        public int Id { get; set; }
        public double TotalCost { get; set; }

        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public Boolean IsActive { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        
        [ForeignKey("Mobility")]
        public int MobilityId { get; set; }

        public User Renter { get; set; }
        public Mobility Mobility { get; set; }

    }
}
