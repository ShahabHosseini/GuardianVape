using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class EqualType :EntityBase
    {
        public string Title { get; set; } = string.Empty;
        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();
    }
}
