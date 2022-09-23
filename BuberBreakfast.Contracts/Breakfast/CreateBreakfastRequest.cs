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
<<<<<<< HEAD
);
=======
)
>>>>>>> 81a4ea47e7a66fabd865f6085f498e2d164d1827
