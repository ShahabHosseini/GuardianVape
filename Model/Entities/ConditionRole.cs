using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ConditionRole : EntityBase
{
    public string? Title { get; set; }

    public virtual ICollection<ConditionRoleType> ConditionRoleTypes { get; set; } = new List<ConditionRoleType>();
}
