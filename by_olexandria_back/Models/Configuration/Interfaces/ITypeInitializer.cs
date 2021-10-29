using by_olexandria_back.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Configuration.Interfaces
{
    public interface ITypeInitializer
    {
        Task Init(ApplicationContext context);
    }
}
