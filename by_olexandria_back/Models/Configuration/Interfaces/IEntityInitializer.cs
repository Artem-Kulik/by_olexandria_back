using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Configuration.Interfaces
{
    public interface IEntityInitializer
    {
        Task SeedData();
        void AddConfig(ITypeInitializer typeInitializer);
    }
}
