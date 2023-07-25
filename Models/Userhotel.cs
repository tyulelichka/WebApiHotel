using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class Userhotel
{
    public int IdUserHotel { get; set; }

    public string NameUser { get; set; } = null!;

    public string SurnameUser { get; set; } = null!;

    public string MiddleUser { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public DateOnly BithdayUser { get; set; }

    public string PhoneUser { get; set; } = null!;

    public string LoginUser { get; set; } = null!;

    public string PassworldUser { get; set; } = null!;

    public string EmailUser { get; set; } = null!;

    public string Document { get; set; } = null!;

    public int IdRoleHotel { get; set; }
}
