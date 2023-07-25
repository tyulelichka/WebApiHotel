using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Spahotel
{
    public int IdSpaHotel { get; set; }

    public int PriceSpa { get; set; }

    public string Regulations { get; set; } = null!;

    public string NameSpa { get; set; } = null!;

    public string LinkSpa { get; set; } = null!;

    public int Duration { get; set; }
}
