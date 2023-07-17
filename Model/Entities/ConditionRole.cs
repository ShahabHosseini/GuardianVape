using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ConditionRole : EntityBase
{
public string Title    { get; set; }=string.Empty;
    public string MyProperty { get; set; } = string.Empty;
}
