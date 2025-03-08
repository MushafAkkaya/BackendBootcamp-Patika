using CodeFirst_Live.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Live.Context
{
    public class PatikaGaleriContext : DbContext
    {
        //3 tane sabit kalıp var.
        //1.sabit
        public PatikaGaleriContext(DbContextOptions<PatikaGaleriContext> options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=DESKTOP-HC41P6U; database=PatikaGaleriDb; Trusted_Connection=true; TrustServerCertificate=true");

        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<ArabaEntity> Arabalar => Set<ArabaEntity>(); // get set ile aynı hiçbir fark yok.
    }
}
