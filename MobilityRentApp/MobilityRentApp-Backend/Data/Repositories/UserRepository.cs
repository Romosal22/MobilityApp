using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Data.Base;

namespace MobilityRentApp_Backend.Data.Repositories
{
    public class UserRepository : Repository<User, ApplicationDbContext>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        //private readonly DbSet<TEntity> dbSet;
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
