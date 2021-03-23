using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public IEnumerable<Songs> Songs { get; set; }      // In Production so this will be red until built

        public string RecordLabel { get; set; }
    }
}
