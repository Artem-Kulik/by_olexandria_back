using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class WorshipType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Worship> Worships { get; set; }
    }
}
