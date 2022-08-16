using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Data.Base;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public interface IRentEnrollmentRepository : IRepository<RentEnrollment>
    {
        List<RentEnrollment> GetByUser(int userId);
    }
}
