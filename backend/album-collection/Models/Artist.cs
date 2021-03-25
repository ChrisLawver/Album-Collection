using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Artist
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Image{get; set;}
        public string RecordLabel{get; set;}

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual ICollection<Album> Albums{get; set;}

        public Artist()
        {

        }

        public Artist(int id, string name, string image, string recordLabel)
        {
            Id = id;
            Name = name;
            Image = image;
            RecordLabel = recordLabel;
        }
    }
}
