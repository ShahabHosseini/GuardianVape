using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class TimeLine : EntityBase
{
    public int? TimelineTypeId { get; set; }

    public string? Header { get; set; }

    public int? BodyId { get; set; }

    public int? CustomerId { get; set; }

    public int? UserId { get; set; }

    public virtual Body? Body { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual User? User { get; set; }
}
