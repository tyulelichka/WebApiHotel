using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Categoriapartament
{
    public int IdCategoriApartament { get; set; }

    public string NameCategori { get; set; } = null!;

    public int PriceCategori { get; set; }

    public string ImageApartament { get; set; } = null!;

    public string LinkApartament { get; set; } = null!;
}
