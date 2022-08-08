using MobilityRentApp_Backend.Data.Base;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public class RoleRepository : Repository<Role, ApplicationDbContext>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
