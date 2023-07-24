using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class ConditionDto
    {
        public ConditionTypeDto ConditionType { get; set; } 
        public string EqualType { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        public bool AllCondition { get; set; } = false;
        public bool AnyCondition { get; set; } = false;
    }
}
