using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Employeesofthespasalon
{
    public int IdEmployeesofthespasalon { get; set; }

    public int UserHotelIdUserHotel { get; set; }

    public int SpaHotelIdSpaHotel { get; set; }

    public string Workingdays { get; set; } = null!;

    public string Openinghours { get; set; } = null!;
}
