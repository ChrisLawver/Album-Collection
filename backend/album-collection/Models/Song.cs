using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Song
    {
       public int Id { get; set; }
       public string Title { get; set; }
       public int Duration { get; set; }                // Seconds, To Be converted Later
        public string Link { get; set; }
       public int AlbumId { get; set; }
       [System.Text.Json.Serialization.JsonIgnore]

       public virtual Album Album { get; set; }

       public Song()
       {

       }

        public Song(int id, string title, int duration, string link, int albumId, Album album)
        {
                Id = id;
                Title = title;
                Duration = duration;
                Link = link;
                AlbumId = albumId;
                Album = album;
        }

    }

}
