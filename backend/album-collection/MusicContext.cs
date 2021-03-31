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
                },

                new Artist() 
                {
                    Id = 3, 
                    Name = "KISS",
                    Image = "https://www.chicagotribune.com/resizer/d2wTT_3wqtN06ELYtlZxNbMkKr4=/1200x0/top/arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/D6JV6O6QCNESRIOKO7WEIPH2AI.jpg",
                    //From Google
                    RecordLabel = "Casablanca Records"
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
                },
                new Album() 
                {
                    Id = 3, 
                    Name = "Dressed To Kill",
                    ArtistId = 3,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/614oEBLBMYL._SL1200_.jpg"
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
                    Id = 1,
                    Title = "Que Sera",
                    Duration = 180,
                    Link = "https://www.youtube.com/watch?v=NH2V5gTjDJ4&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=2",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "Ordinary Girl",
                    Duration = 154,
                    Link = "https://www.youtube.com/watch?v=OP_0CWkqPM8&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=3",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "Kiss it Goodbye",
                    Duration = 147,
                    Link = "https://www.youtube.com/watch?v=fDwu1dsbjf4&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=4",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "I'll Always Remeber You",
                    Duration = 211,
                    Link = "https://www.youtube.com/watch?v=0XVhsUg8dBY&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=5",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "Need a Little Love",
                    Duration = 213,
                    Link = "https://www.youtube.com/watch?v=XzMCASEZIgA&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=6",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "Are You Ready ",
                    Duration = 189,
                    Link = "https://www.youtube.com/watch?v=btGDYSwFPOs&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=7",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "Love That Lets Go",
                    Duration = 184,
                    Link = "https://www.youtube.com/watch?v=G3hfZD4F_0U&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=8",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "I'm Still Good",
                    Duration = 190,
                    Link = "https://www.youtube.com/watch?v=3dKG0Uivy_I&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=9",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "Been Here All Along",
                    Duration = 241,
                    Link = "https://www.youtube.com/watch?v=PSDgpuWL2eY&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=10",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 1,
                    Title = "BareFoot Cinderella",
                    Duration = 154,
                    Link = "https://www.youtube.com/watch?v=JdKxkG6mQLg&list=PLwsw1p2GcXVcBMxwQGrJVodc8JFX0lyR6&index=11",
                    AlbumId = 1,
                },
                new Song()
                {
                    Id = 2,
                    Title = "No Pressure Intro",
                    Duration = 153,
                    Link = "https://www.youtube.com/watch?v=LsfnODTWgss",
                    AlbumId = 2,
                },

                new Song() 
                {
                    Id = 3,
                    Title = "Room Service",
                    Duration = 180,
                    Link = "https://www.youtube.com/watch?v=DVFe9sVcAP8&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Two Timer",
                    Duration = 149,
                    Link = "https://www.youtube.com/watch?v=fA_DmcYtXbA&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=2",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Ladies in Waiting",
                    Duration = 148,
                    Link = "https://www.youtube.com/watch?v=sHEAeCZ-6bA&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=3",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Getaway",
                    Duration = 146,
                    Link = "https://www.youtube.com/watch?v=08ExDDQrgbk&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=4",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Rock Bottom",
                    Duration = 213,
                    Link = "https://www.youtube.com/watch?v=7mIIU7OfG6g&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=5",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "C'Mon and Love Me",
                    Duration = 154,
                    Link = "https://www.youtube.com/watch?v=lwLStZXSHgk&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=6",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Anything For My Baby",
                    Duration = 140,
                    Link = "https://www.youtube.com/watch?v=J8JjiViyZfI&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=7",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "She",
                    Duration = 244,
                    Link = "https://www.youtube.com/watch?v=Z3iV--DenCw&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=8",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Love Her All I Can",
                    Duration = 144,
                    Link = "https://www.youtube.com/watch?v=PnotFAJiFTI&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=9",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 3,
                    Title = "Rock and Roll All Night",
                    Duration = 148,
                    Link = "https://www.youtube.com/watch?v=6E5N9L7HTTk&list=PL6ogdCG3tAWgGC-Wh4oj_sEKcOFrFrSjB&index=10",
                    AlbumId = 3
                }
                );


        }

        public DbSet<album_collection.Models.Song> Song { get; set; }
    }
}