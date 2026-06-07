using TestAPBD.Data;

namespace TestAPBD.Services
{
    public class DbService : IDbService
    {
        private readonly AppDbContext _dbContext;
        public DbService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
