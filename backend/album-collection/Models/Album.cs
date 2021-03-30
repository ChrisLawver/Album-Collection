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

        // public string RecordLabel { get; set; }

        public virtual IEnumerable<Song> Songs { get; set; }


        public Album()
        {
        }

        public Album(int id, string name, int artistId, string image) // , string recordLabel)
        {
            Id = id;
            Name = name;
            ArtistId = artistId;
            Image = image;
            // RecordLabel = recordLabel;
        }
    }

       
}
