using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class SongsCollection
    {
        public int Id { get; set; }
        public int WorshipId { get; set; }

        public virtual Worship Worship { get; set; }
        public ICollection<Song_SongsCollection> Song_SongsCollections { get; set; }
    }
}
