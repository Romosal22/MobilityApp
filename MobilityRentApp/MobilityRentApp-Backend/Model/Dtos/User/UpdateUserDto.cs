using MobilityRentApp_Backend.Model.Base;

namespace MobilityRentApp_Backend.Model.Dtos.User
{
    public class UpdateUserDto : CreateUserDto, IHasId
    {
        public int Id { get; set; }
    }
}
