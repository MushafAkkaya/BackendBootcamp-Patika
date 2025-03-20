using CustomIdentity_Live.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomIdentity_Live.Context
{
    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
            
        }



        public DbSet<UserEntity> Users => Set<UserEntity>();

    }
}
