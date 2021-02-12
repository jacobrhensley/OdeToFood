using OdeToFood.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.data.Services
{
    public interface IRestrauntData
    {
        IEnumerable<Restraunt> GetAll();
    }
}
