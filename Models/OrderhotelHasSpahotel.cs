using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class OrderhotelHasSpahotel
{
    public DateOnly SessionSpa { get; set; }

    public int PriceSpa { get; set; }

    public int IdSpaHotel { get; set; }

    public int IdOrderHotel { get; set; }

    public int IdUserHotel { get; set; }
}
