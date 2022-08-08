using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Data.Base;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public class RentEnrollmentRepository : Repository<RentEnrollment, ApplicationDbContext>, IRentEnrollmentRepository
    {
        public RentEnrollmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
