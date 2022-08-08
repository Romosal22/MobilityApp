using MobilityRentApp_Backend.Model.Base;

namespace MobilityRentApp_Backend.Model.Dtos.Role
{
    public class UpdateRoleDto : CreateRoleDto, IHasId
    {
        public int Id { get; set; }
    }
}
