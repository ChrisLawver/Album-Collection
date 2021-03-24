using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string AlbumName { get; set; }

        public string BandName { get; set; }

        public string Image { get; set; }

        public string RecordLabel { get; set; }

      //  public IEnumerable<Songs> Songs { get; set; }      // In Production so this will be red until built


        public Album()
        {
        }

        public Album(int id, string albumName, string bandName, string image, string recordLabel)
        {
            Id = id;
            AlbumName = albumName;
            BandName = bandName;
            Image = image;
            RecordLabel = recordLabel;
        }
    }

       
}
