using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class OrderhotelHasUserhotel
{
    public int IdOrderHotel { get; set; }

    public int IdUserHotel { get; set; }

    public sbyte PaymentSing { get; set; }
}
