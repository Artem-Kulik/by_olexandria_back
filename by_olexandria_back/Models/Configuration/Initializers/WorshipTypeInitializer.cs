using by_olexandria_back.Models.Configuration.Interfaces;
using by_olexandria_back.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Configuration.Initializers
{
    public class WorshipTypeInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            WorshipType[] types = new WorshipType[] {
                new WorshipType(){
                Type="Evening"
                },
                new WorshipType(){
                Type="Morning"
                },
                new WorshipType(){
                Type="Youth"
                },
                new WorshipType(){
                Type="Outbound"
                },
                new WorshipType(){
                Type="Special"
                }
            };

            await context.Set<WorshipType>().AddRangeAsync(types);
        }
    }
}
