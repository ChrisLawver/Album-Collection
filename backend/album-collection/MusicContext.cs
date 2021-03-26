using album_collection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist()
                {
                    Id = 1,
                    Name = "Hannah Montana",
                    Image = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/4B95C840AF54D3C2580D53C19CFA240B0D9FD728A95A3F6814BD354CA746FF5F/scale?width=1200&aspectRatio=1.78&format=jpeg",
                    RecordLabel = "Walt Disney"
                },
                new Artist()
                {
                    Id = 2,
                    Name = "Logic",
                    Image = "https://www.universalmusic.com/wp-content/uploads/2019/05/credit-ryan-jay.jpg",
                    RecordLabel = "Visionary"
                }
                );


            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 1,
                    Name = "Hannah Montana Forever",
                    ArtistId = 1,
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/6/60/Hannah_Montana_Forever.png/220px-Hannah_Montana_Forever.png"
                },
                new Album()
                {
                    Id = 2,
                    Name = "No Pressure",
                    ArtistId = 2,
                    Image = "https://upload.wikimedia.org/wikipedia/en/4/4c/Logic_No_Pressure_album_cover.jpeg"
                }
                );

            modelBuilder.Entity<Song>().HasData(
                new Song()
                {
                    Id = 1,
                    Title = "Gonna Get This",
                    Duration = 196,
                    Link = "https://www.youtube.com/watch?v=DcvB9cxDvvY",
                    AlbumId = 1,
                },

                new Song()
                {
                    Id = 2,
                    Title = "No Pressure Intro",
                    Duration = 153,
                    Link = "https://www.youtube.com/watch?v=LsfnODTWgss",
                    AlbumId = 2,
                }
                );


        }

        public DbSet<album_collection.Models.Song> Song { get; set; }
    }
}