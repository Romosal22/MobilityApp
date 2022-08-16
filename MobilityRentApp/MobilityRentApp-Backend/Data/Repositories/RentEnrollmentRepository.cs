using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Data.Base;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public class RentEnrollmentRepository : Repository<RentEnrollment, ApplicationDbContext>, IRentEnrollmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RentEnrollmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        List<RentEnrollment> IRentEnrollmentRepository.GetByUser(int userId)
        {
            var db = _dbContext;
            var query = from rent in db.RentEnrollments
                        where rent.UserId == userId
                        select rent;

            return query.ToList();
        }
    }
}
