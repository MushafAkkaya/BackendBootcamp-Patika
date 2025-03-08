using CodeFirstExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstExample.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext>options) : base(options)
        {
            
        }
        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        public DbSet<GameEntity> Games => Set<GameEntity>();
    }
}
