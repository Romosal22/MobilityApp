using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Dtos.MobilityKind
{
    public class MobilityKindDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public double RentFee { get; set; }
    }
}
