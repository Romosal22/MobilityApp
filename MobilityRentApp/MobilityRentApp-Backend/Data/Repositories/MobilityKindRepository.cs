using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Data.Base;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public class MobilityKindRepository : Repository<MobilityKind, ApplicationDbContext>, IMobilityKindRepository
    {
        public MobilityKindRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

    }
}
