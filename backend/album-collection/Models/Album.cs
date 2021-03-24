using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }

        public string Image { get; set; }

        public string RecordLabel { get; set; }

      //  public virtual IEnumerable<Songs> Songs { get; set; }      // In Production so this will be red until built


        public Album()
        {
        }

        public Album(int id, string albumName, string artist, string image, string recordLabel)
        {
            Id = id;
            AlbumName = albumName;
            Artist = artist;
            Image = image;
            RecordLabel = recordLabel;
        }
    }

       
}
