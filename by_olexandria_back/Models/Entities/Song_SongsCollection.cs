using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class Song_SongsCollection
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int SongsCollectionId { get; set; }

        public virtual Song Song { get; set; }
        public virtual SongsCollection SongsCollection { get; set; }
    }
}
