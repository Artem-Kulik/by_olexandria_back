using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class UserAdditionalInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }

        public virtual User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
