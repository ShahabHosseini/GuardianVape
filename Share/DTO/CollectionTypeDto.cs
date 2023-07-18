using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class CollectionTypeDto
    {
        public IList<ConditionDto> Conditions { get; set; }
        //public bool CollectionType { get; set; } = true;
        //public bool ConditionType { get; set; } = true;
    }
}
