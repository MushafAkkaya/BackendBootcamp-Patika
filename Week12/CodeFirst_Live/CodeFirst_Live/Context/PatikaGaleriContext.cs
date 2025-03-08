using CodeFirst_Live.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Live.Context
{
    public class PatikaGaleriContext : DbContext
    {
        //DBcontext için 3 büyük var.
        //1. büyük kalıp
        public PatikaGaleriContext(DbContextOptions<PatikaGaleriContext> options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=SRTN-NOTEBOOK\SQLEXPRESS; database=PatikaGaleriDb; Trusted_Connection=true; TrustServerCertificate=true");


        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<ArabaEntity> Arabalar => Set<ArabaEntity>();
    }
}
