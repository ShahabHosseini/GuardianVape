using Share.DTO.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class CollectionDto 
    {
        [MaxLength(36)]
        public int? ParentId { get; set; }
        public string Guid { get; set; } = string.Empty;
        public TitleDescriptionDto TitleDescription { get; set; } = new TitleDescriptionDto();
        public CollectionTypeDto CollectionType { get; set; } = new CollectionTypeDto();
        public ImageDto? Image { get; set; }
    }
}
