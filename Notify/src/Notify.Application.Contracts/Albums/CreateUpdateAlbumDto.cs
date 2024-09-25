using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notify.Albums
{
    public class CreateUpdateAlbumDto
    {
        public string Title { get; set; }
        public TypeGenre Genre { get; set; }
        public DateTime releaseDate { get; set; } 
        public TimeSpan length { get; set; }
        public string country { get; set; }
        public bool released { get; set; }
        public uint playCount { get; set; }
    }
}
