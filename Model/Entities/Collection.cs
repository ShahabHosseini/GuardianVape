using Model.Base;

namespace Model.Entities;
public partial class Collection : EntityBase
{
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? PageTitle { get; set; }

    public string? MetaDescription { get; set; }

    public GvImage image { get; set; }=new GvImage();
    public bool Automated { get; set; } = true;

    public virtual ICollection<Condition> ConditionRoleTypes { get; set; } = new List<Condition>();

    public ICollection<Product> Products { get; set; } = new List<Product>();
    public SearchEnginListing SearchEnginListing { get; set; } = new SearchEnginListing();
}
