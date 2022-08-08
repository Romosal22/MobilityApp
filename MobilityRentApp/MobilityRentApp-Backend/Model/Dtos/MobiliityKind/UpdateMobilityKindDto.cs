using MobilityRentApp_Backend.Model.Base;

namespace MobilityRentApp_Backend.Model.Dtos.MobilityKind
{
    public class UpdateMobilityKindDto : CreateMobilityKindDto, IHasId
    {
        public int Id { get; set; }
    }
}
