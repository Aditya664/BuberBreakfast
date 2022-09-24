using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfast;

namespace BuberBreakfast.Services.Breakfast
{
    public class BreakfastService : IBreakfastService
    {
        private readonly Dictionary<Guid,Breakfasts> _breakfast = new();
        public void CreateBreakfast(Breakfasts breakfast)
        {
          
           _breakfast.Add(breakfast.Id,breakfast);
        }

        public Breakfasts GetBreakfast(Guid id)
        {
            Console.WriteLine(_breakfast[id]); // It will print Value of key '1'
            return _breakfast[id];
        }

        public IEnumerable<Breakfasts> GetBreakfast()
        {
            foreach(var a in _breakfast){
                yield return a.Value;
            }
        }
    }
}