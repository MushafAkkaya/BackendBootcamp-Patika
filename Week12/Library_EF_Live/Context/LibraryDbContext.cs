using Library_EF_Live.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_EF_Live.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<AuthorEntity> Authors => Set<AuthorEntity>();
        public DbSet<StudentEntity> Students => Set<StudentEntity>();
        public DbSet<BookTypeEntity> BookTypes => Set<BookTypeEntity>();
        public DbSet<BookEntity> Books => Set<BookEntity>();
    }
}
