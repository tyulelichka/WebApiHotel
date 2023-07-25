using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Newsletter
{
    public int IdNewsletter { get; set; }

    public string TextNewsletter { get; set; } = null!;

    public DateOnly DateNewsletter { get; set; }

    public int IdCategoriApartament { get; set; }

    public int IdSpaHotel { get; set; }

    public int Sale { get; set; }
}
