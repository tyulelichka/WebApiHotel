using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Apartament
{
    public int IdApartment { get; set; }

    public int CountRoom { get; set; }

    public int NumberApartament { get; set; }

    public string Description { get; set; } = null!;

    public int IdCategoriApartament { get; set; }
}
