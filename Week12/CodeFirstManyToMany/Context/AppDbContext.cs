using CodeFirstManyToMany.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstManyToMany.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<StudentEntity> Students => Set<StudentEntity>();
        public DbSet<CourseEntity> Courses => Set<CourseEntity>();
        public DbSet<StudentCourseEntity> StudentCourses => Set<StudentCourseEntity>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Ara tablo
            modelBuilder.Entity<StudentCourseEntity>()
                .HasKey(e => new { e.StudentId, e.CourseId}); //Birincil anahtar olarak 2 sütun

            base.OnModelCreating(modelBuilder);
        }
    }
}
