using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Offerhotel
{
    public int IdUserHotel { get; set; }

    public int IdNewsletter { get; set; }

    public sbyte Usage { get; set; }
}
