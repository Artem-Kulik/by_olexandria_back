using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class Worship
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public string Theme { get; set; }
        public string PhotoFon { get; set; }
        public string Speaker { get; set; }
        public string Description { get; set; }
        public string PhoneHelp { get; set; }
        public string DayVerse { get; set; }
        public int CountVisited { get; set; }
        public int WorshipTypeId { get; set; }
        public int SongsCollectionId { get; set; }

        public virtual WorshipType WorshipType { get; set; }
        public virtual SongsCollection SongsCollection { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
