using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Dtos.Mobility
{
    public class MobilityDto
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
    }
}
