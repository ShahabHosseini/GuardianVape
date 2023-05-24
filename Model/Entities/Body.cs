using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Body :EntityBase
{
    public string? BodyText { get; set; }

    public byte[]? Media { get; set; }

    public virtual ICollection<TimeLine> TimeLines { get; set; } = new List<TimeLine>();
}
