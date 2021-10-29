using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Dto
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public string ChordColor { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
