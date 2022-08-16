using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Data.Base;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public class MobilityRepository : Repository<Mobility, ApplicationDbContext>, IMobilityRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MobilityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }

        public double CalculateRentCost(int mobilityId)
        {
            var db = _dbContext;
            var query = from mobility in db.Mobilities
                        join mobKind in db.MobilityKinds
                        on mobility.MobilityKindId equals mobKind.Id
                        where mobility.Id == mobilityId
                        select mobility.Price * mobKind.RentFee;

            return query.FirstOrDefault();
        }
    }
}