using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ConditionType
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ConditionRoleType> ConditionRoleTypes { get; set; } = new List<ConditionRoleType>();
}
