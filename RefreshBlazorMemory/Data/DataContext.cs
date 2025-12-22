using Microsoft.EntityFrameworkCore;
using RefreshBlazorMemory.Models;

namespace RefreshBlazorMemory.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Music> Musics { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Music>().ToTable("Musics");
            modelBuilder.Entity<Music>().HasData(
                new Music
                {
                    Id = 1,
                    AlbumTitle = "Pepe",
                    Artist = "Mic Pepper",
                    Description = "Dope nok",
                    ReleaseYear = 1999
                },
                new Music
                {
                    Id = 2,
                    AlbumTitle = "MoreDance",
                    Artist = "Jens Musikmand",
                    Description = "Vildt Nok",
                    ReleaseYear = 2000
                },
                new Music
                {
                    Id = 3,
                    AlbumTitle = "SuperDanse",
                    Artist = "Danse Mus",
                    Description = "Jeg er træt",
                    ReleaseYear = 2001
                }
            );
        }
    }
}
