using Model.Base;
using System;

namespace Model.Entities
{
    public class Condition : EntityBase
    {
        public string Result { get; set; } = string.Empty;

        // Relationship
        public int ConditionTypeId { get; set; }
        public virtual ConditionType ConditionType { get; set; }
        public int EqualTypeId { get; set; }
        public virtual EqualType EqualType { get; set; }

        public bool AllCondition { get; set; } = false;
    }
}
