using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfast;

namespace BuberBreakfast.Services.Breakfast
{
    public class BreakfastService : IBreakfastService
    {
        private static readonly Dictionary<Guid,Breakfasts> _breakfast = new();
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
        public Breakfasts CreateBreakfastWithRequest(CreateBreakfastRequest request){
             Breakfasts breakfast = new Breakfasts(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet);

            return breakfast;
        }

        public BreakfastResponse CreateBreakfastResponse(Breakfasts response)
        {
             BreakfastResponse breakfastResponse = new BreakfastResponse(
                response.Id,
                response.Name,
                response.Description,
                response.StartDateTime,
                response.EndDateTime,
                response.LastModifiedDateTime,
                response.Savory,
                response.Sweet);
                
                return breakfastResponse;

        }
    }
}