using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Reservationspa
{
    public int IdReservationSpa { get; set; }

    public int SpaHotelIdSpaHotel { get; set; }

    public int UserHotelIdUserHotel { get; set; }

    public DateOnly DateReserv { get; set; }

    public TimeOnly TimeReserv { get; set; }

    public int OrderHotelIdOrderHotel { get; set; }
}
