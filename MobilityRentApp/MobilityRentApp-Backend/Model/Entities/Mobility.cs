using MobilityRentApp_Backend.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobilityRentApp_Backend.Model.Entities
{
    public class Mobility : IHasId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public Boolean IsActive { get; set; }


        public int MobilityKindId { get; set; }
        public MobilityKind Kind { get; set; }

       public int RentEnrollmentId { get; set; }
        public RentEnrollment RentEnrollment { get; set; }



    }
}
