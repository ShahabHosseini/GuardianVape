using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Entities;
using System.Reflection;

namespace DataAccess.Context;

public partial class GVDbContext : DbContext
{
    public GVDbContext(){ }

    public GVDbContext(DbContextOptions<GVDbContext> options)
        : base(options){  }

    #region DbSets

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Body> Bodies { get; set; }
    public virtual DbSet<EqualType> EqualTypes { get; set; }
    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryGroup> CategoryGroups { get; set; }

    public virtual DbSet<Collection> Collections { get; set; }

    public virtual DbSet<CollectionType> CollectionTypes { get; set; }

    public virtual DbSet<ConditionType> ConditionTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Image> Image { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCollection> ProductCollections { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductVariant> ProductVariants { get; set; }

    public virtual DbSet<RelatedTag> RelatedTags { get; set; }

    public virtual DbSet<SearchEnginListing> SearchEnginListings { get; set; }

    public virtual DbSet<ShopLocation> ShopLocations { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TimeLine> TimeLines { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Variant> Variants { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    #endregion DbSets

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("GV_DBConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
