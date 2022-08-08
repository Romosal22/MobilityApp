using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Dtos.Role
{
    public class CreateRoleDto
    {
        [Required]
        [StringLength(8)]
        public string Name { get; set; }
    }
}
