
using BuberBreakfast.Models;
namespace BuberBreakfast.Services.Breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfasts requst);
        Breakfasts GetBreakfast(Guid id);
        IEnumerable<Breakfasts> GetBreakfast();
        

    }
}