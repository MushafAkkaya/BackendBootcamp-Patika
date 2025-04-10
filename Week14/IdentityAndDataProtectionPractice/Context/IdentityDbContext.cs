using IdentityAndDataProtectionPractice.Entites;
using Microsoft.EntityFrameworkCore;

namespace IdentityAndDataProtectionPractice.Context
{
    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
