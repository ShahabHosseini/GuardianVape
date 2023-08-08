using Share.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class ConditionDto 
    {
        public string Guid { get; set; } = string.Empty;
        public IdTitleDto ConditionType { get; set; } 
        public IdTitleDto EqualType { get; set; }
        public string Result { get; set; } = string.Empty;
        public bool AllCondition { get; set; } = false;
        public bool AnyCondition { get; set; } = false;
    }
}
