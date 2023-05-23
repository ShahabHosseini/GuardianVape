using DataAccess.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Entities;

namespace DataAccess.Context;

public partial class GVDbContext : DbContext
{
    public GVDbContext()
    {
    }

    public GVDbContext(DbContextOptions<GVDbContext> options)
        : base(options)
    {
    }
    #region DbSets

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Body> Bodies { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryGroup> CategoryGroups { get; set; }

    public virtual DbSet<Collection> Collections { get; set; }

    public virtual DbSet<ConditionRole> ConditionRoles { get; set; }

    public virtual DbSet<ConditionRoleType> ConditionRoleTypes { get; set; }

    public virtual DbSet<ConditionType> ConditionTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Medium> Media { get; set; }

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
        #region ModelCreating

        modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new BodyEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryGroupEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CollectionEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ConditionRoleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ConditionRoleTypeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ConditionTypeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CountryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
        modelBuilder.ApplyConfiguration(new InventoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new MediumEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderProductEntityConfiguration());
        modelBuilder.ApplyConfiguration(new PhoneEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCollectionEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductTagEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductTypeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductVariantEntityConfiguration());
        modelBuilder.ApplyConfiguration(new RelatedTagEntityConfiguration());
        modelBuilder.ApplyConfiguration(new SearchEnginListingEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ShopLocationEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TagEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TimeLineEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UnitEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new VariantEntityConfiguration());
        modelBuilder.ApplyConfiguration(new VendorEntityConfiguration());

        #endregion ModelCreating

        OnModelCreatingPartial(modelBuilder);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
