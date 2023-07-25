using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Orderhotel
{
    public int IdOrderHotel { get; set; }

    public int PriceHotel { get; set; }

    public DateOnly DateOrderHotel { get; set; }

    public int IdApartment { get; set; }
}
