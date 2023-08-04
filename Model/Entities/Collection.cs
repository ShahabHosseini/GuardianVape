using Model.Base;

namespace Model.Entities;
public partial class Collection : EntityBase
{
    public string Title { get; set; } = null!;

    public string? Description { get; set; }
    public int CollectionTypeId { get; set; }
    public  int? ImageId { get; set; }
    public virtual Image? Image { get; set; } 
    public virtual CollectionType CollectionType { get; set; }
}
