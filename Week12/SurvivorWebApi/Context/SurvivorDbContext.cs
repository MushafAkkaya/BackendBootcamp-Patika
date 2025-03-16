using Microsoft.EntityFrameworkCore;
using SurvivorWebApi.Entites;

namespace SurvivorWebApi.Context
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
        {

        }

        public DbSet<CompetitorsEntity> Competitors => Set<CompetitorsEntity>();
        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // OneToMany
            modelBuilder.Entity<CategoryEntity>()
                .HasMany(c => c.Competitors) //Bir kategori birden fazla yarışmacı içerebilir.
                .WithOne(c => c.Category) //Bir yarışmacı bir kategoride bulunabilir.
                .HasForeignKey(c => c.CategoryId);

            //Kategori tablosuna eklenecek veriler.
            modelBuilder.Entity<CategoryEntity>()
                .HasData(
            new CategoryEntity { Id = 1, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, Name = "Ünlüler" },
            new CategoryEntity { Id = 2, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, Name = "Gönüllüler" }
        );

            //Yarışmacılar tablosuna eklenecek veriler.
            modelBuilder.Entity<CompetitorsEntity>()
                .HasData(
            new CompetitorsEntity { Id = 1, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Acun", LastName = "Ilicali", CategoryId = 1 },
            new CompetitorsEntity { Id = 2, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1 },
            new CompetitorsEntity { Id = 3, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1 },
            new CompetitorsEntity { Id = 4, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1 },
            new CompetitorsEntity { Id = 5, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Özge", LastName = "Açık", CategoryId = 1 },
            new CompetitorsEntity { Id = 6, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Kıvanç", LastName = "Tatırtuğ", CategoryId = 1 },
            new CompetitorsEntity { Id = 7, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2 },
            new CompetitorsEntity { Id = 8, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2 },
            new CompetitorsEntity { Id = 9, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2 },
            new CompetitorsEntity { Id = 10, CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0), IsDeleted = false, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2 }
        );

            base.OnModelCreating(modelBuilder);
        }
    }
}
