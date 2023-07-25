using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Reservationapartament
{
    public int IdReservationApartament { get; set; }

    public DateOnly StartReserv { get; set; }

    public DateOnly EndReserv { get; set; }

    public int IdOrderHotel { get; set; }
}
