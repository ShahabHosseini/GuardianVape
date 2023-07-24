using Model.Base;
using System.Collections.Generic;

namespace Model.Entities
{
    public class CollectionType : EntityBase
    {
        public ICollection<Condition> Conditions { get; set; }
        public bool CollType { get; set; }
        public bool ConditionType { get; set; } = true;
    }
}
