using System;
using System.Collections.Generic;

namespace BuberBreakfast.Contracts.Breakfast;


public record CreateBreakfastRequest(
    string name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);
