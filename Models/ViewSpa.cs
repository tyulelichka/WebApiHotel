using System;
using System.Collections.Generic;

namespace WebApiHotel.Models;

public partial class ViewSpa
{
    public int Id { get; set; }
    public string Імя { get; set; } = null!;

    public string Прізвище { get; set; } = null!;

    public string ПоБатькові { get; set; } = null!;

    public string Стать { get; set; } = null!;

    public DateOnly ДатаНародження { get; set; }

    public string НомерТелефону { get; set; } = null!;

    public string Пошта { get; set; } = null!;

    public string Документ { get; set; } = null!;

    public int НомерБронювання { get; set; }

    public DateOnly ДатаБронювання { get; set; }

    public string НазваСпа { get; set; } = null!;

    public int Ціна { get; set; }

    public DateOnly Відвідування { get; set; }

    public long КількістьВідвідуванняСпа { get; set; }
}
