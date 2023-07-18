using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class CollectionDto
    {
        public TitleDescriptionDto TitleDescription { get; set; } = new TitleDescriptionDto();
        public CollectionTypeDto CollectionType { get; set; } = new CollectionTypeDto();
    }
}
