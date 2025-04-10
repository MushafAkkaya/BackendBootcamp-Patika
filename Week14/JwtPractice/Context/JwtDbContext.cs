using JwtPractice.Entites;
using Microsoft.EntityFrameworkCore;

namespace JwtPractice.Context
{
    public class JwtDbContext : DbContext
    {
        public JwtDbContext(DbContextOptions<JwtDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
