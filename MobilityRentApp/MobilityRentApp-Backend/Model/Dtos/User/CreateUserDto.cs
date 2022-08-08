using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Dtos.User
{
    public class CreateUserDto
    {

        [Required]
        [StringLength(15)]
        public string Username { get; set; }

        [Required]
        [StringLength(15)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        public Boolean IsActive { get; set; }
    }
}
