using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Dtos.Role
{
    public class RoleDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string Name { get; set; }
    }
}
