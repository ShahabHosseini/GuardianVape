using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;
public partial class ConditionRoleType : EntityBase
{
    public int? ConditionRoleId { get; set; }

    public int? ConditionTypeId { get; set; }

    public int? VendorId { get; set; }

    public int? ProductTypeId { get; set; }

    public int? CategoryId { get; set; }

    public int? TagId { get; set; }

    public int? CollectionId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Collection? Collection { get; set; }

    public virtual ConditionType? ConditionRole { get; set; }

    public virtual ConditionType? ConditionType { get; set; }

    public virtual ProductType? ProductType { get; set; }

    public virtual Tag? Tag { get; set; }

    public virtual Vendor? Vendor { get; set; }
}
