using CodeFirstOneToMany.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstOneToMany.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>()
                .HasOne(e => e.User) //Her post bir kullanıcı tarafından yazılmıştır.
                .WithMany(e => e.Posts) //Her kullanıcının birden fazla postu olabilir.
                .HasForeignKey(e => e.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
