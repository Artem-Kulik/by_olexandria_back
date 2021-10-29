using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class User : IdentityUser
    {
        public virtual UserAdditionalInfo UserAdditionalInfo { get; set; }
    }
}
