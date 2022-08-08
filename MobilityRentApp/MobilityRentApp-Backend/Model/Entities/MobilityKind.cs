using MobilityRentApp_Backend.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Entities
{
    public class MobilityKind : IHasId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public double RentFee { get; set; }
    }
}
