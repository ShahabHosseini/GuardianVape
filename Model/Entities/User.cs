using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public virtual ICollection<TimeLine> TimeLines { get; set; } = new List<TimeLine>();
}
