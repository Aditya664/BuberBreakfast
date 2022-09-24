
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
namespace BuberBreakfast.Services.Breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfasts requst);
        Breakfasts GetBreakfast(Guid id);
        IEnumerable<Breakfasts> GetBreakfast();

        Breakfasts CreateBreakfastWithRequest(CreateBreakfastRequest request);
        BreakfastResponse CreateBreakfastResponse(Breakfasts response);
        

    }
}