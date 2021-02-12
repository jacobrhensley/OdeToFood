using OdeToFood.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.data.Services
{
    public class InMemoryRestrauntData : IRestrauntData
    {

        List<Restraunt> restraunts;

        public InMemoryRestrauntData()
        {
            restraunts = new List<Restraunt>()
            {
                new Restraunt { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
                new Restraunt { Id = 2, Name = "Tersiguels", Cuisine = CuisineType.French},
                new Restraunt { Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian},
            };
        }
        public IEnumerable<Restraunt> GetAll()
        {
            return restraunts.OrderBy(r => r.Name);
        }
    }
}
