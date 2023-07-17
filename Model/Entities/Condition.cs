using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Condition :EntityBase
    {
        public ConditionType Type { get; set; } = new ConditionType();
        public ConditionRole Role { get; set; } = new ConditionRole();
        public string Value { get; set; } = string.Empty;
        public bool AllCondition { get; set; } = false;
        public bool AnyCondition { get; set; } = false;
    }
}
