using MobilityRentApp_Backend.Model.Base;

namespace MobilityRentApp_Backend.Model.Dtos.Mobility
{
    public class UpdateMobilityDto : CreateMobilityDto, IHasId
    {
        public int Id { get; set; }
    }
}
