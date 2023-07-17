using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ConditionType : EntityBase
{
    public string Title { get; set; } = string.Empty;

}
