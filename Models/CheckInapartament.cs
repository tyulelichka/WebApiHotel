using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class CheckInapartament
{
    public int IdCheckInApartament { get; set; }

    public DateOnly StartCheck { get; set; }

    public DateOnly EndCheck { get; set; }

    public int IdOrderHotel { get; set; }
}
