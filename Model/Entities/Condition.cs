using Model.Base;
using System;

namespace Model.Entities
{
    public class Condition : EntityBase
    {
        public string EqualType { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;

        // Relationship
        public int ConditionTypeId { get; set; }
        public ConditionType ConditionType { get; set; } = new ConditionType();

        // Navigation property
        public int CollectionTypeId { get; set; }
        public CollectionType CollectionType { get; set; }

        public bool AllCondition { get; set; } = false;
    }
}
