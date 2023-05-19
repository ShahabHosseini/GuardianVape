using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Entities;

namespace DataAccess.Models;

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


    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=localhost;Database=GuardianVape;User Id=sa;Password=123;TrustServerCertificate=true;Encrypt=false;");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("GV_DBConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Address1");

            entity.ToTable("Address");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(200)
                .HasColumnName("Address");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.FristName).HasMaxLength(50);
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.House).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneId).HasColumnName("PhoneID");
            entity.Property(e => e.Postcode).HasMaxLength(10);

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Address1_Address1");
        });

        modelBuilder.Entity<Body>(entity =>
        {
            entity.ToTable("Body");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Media)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryGroupId).HasColumnName("CategoryGroupID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.CategoryGroup).WithMany(p => p.Categories)
                .HasForeignKey(d => d.CategoryGroupId)
                .HasConstraintName("FK_Category_CategoryGroup");
        });

        modelBuilder.Entity<CategoryGroup>(entity =>
        {
            entity.ToTable("CategoryGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Collection>(entity =>
        {
            entity.ToTable("Collection");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.MetaDescription).HasMaxLength(500);
            entity.Property(e => e.PageTitle).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Collection_Collection1");
        });

        modelBuilder.Entity<ConditionRole>(entity =>
        {
            entity.ToTable("ConditionRole");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<ConditionRoleType>(entity =>
        {
            entity.ToTable("ConditionRoleType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CollectionId).HasColumnName("CollectionID");
            entity.Property(e => e.ConditionRoleId).HasColumnName("ConditionRoleID");
            entity.Property(e => e.ConditionTypeId).HasColumnName("ConditionTypeID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");

            entity.HasOne(d => d.Category).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ConditionRoleType_Category");

            entity.HasOne(d => d.Collection).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("FK_ConditionRoleType_Collection");

            entity.HasOne(d => d.ConditionRole).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.ConditionRoleId)
                .HasConstraintName("FK_ConditionRoleType_ConditionRole");

            entity.HasOne(d => d.ConditionType).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.ConditionTypeId)
                .HasConstraintName("FK_ConditionRoleType_ConditionType");

            entity.HasOne(d => d.ProductType).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_ConditionRoleType_ProductType");

            entity.HasOne(d => d.Tag).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK_ConditionRoleType_Tag");

            entity.HasOne(d => d.Vendor).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_ConditionRoleType_Vendor");
        });

        modelBuilder.Entity<ConditionType>(entity =>
        {
            entity.ToTable("ConditionType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaCode).HasMaxLength(10);
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.AgreedSms).HasColumnName("AgreedSMS");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FristName).HasMaxLength(50);
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Language)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

            entity.HasOne(d => d.Address).WithMany(p => p.Customers)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Customer_Address");

            entity.HasOne(d => d.Phone).WithMany(p => p.Customers)
                .HasForeignKey(d => d.PhoneId)
                .HasConstraintName("FK_Customer_Customer");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ShopLocationId).HasColumnName("ShopLocationID");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");

            entity.HasOne(d => d.Product).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Product");
        });

        modelBuilder.Entity<Medium>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CollectionId).HasColumnName("CollectionID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("URL");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.Collection).WithMany(p => p.MediaNavigation)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("FK_Media_Collection");

            entity.HasOne(d => d.Product).WithMany(p => p.Media)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Media_Product");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeliveryMethodId).HasColumnName("DeliveryMethodID");
            entity.Property(e => e.FulfillmentStatusId).HasColumnName("FulfillmentStatusID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");
            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Order_Customer");

            entity.HasOne(d => d.OrderProduct).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderProductId)
                .HasConstraintName("FK_Order_OrderProduct");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.ToTable("OrderProduct");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderProduct_Order");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_OrderProduct_Product");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.ToTable("Phone");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(12);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompareatPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CostPerItem).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.SearchEnginListingId).HasColumnName("SearchEnginListingID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");

            entity.HasOne(d => d.ProductType).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_Product_ProductType");

            entity.HasOne(d => d.SearchEnginListing).WithMany(p => p.Products)
                .HasForeignKey(d => d.SearchEnginListingId)
                .HasConstraintName("FK_Product_SearchEnginListing");

            entity.HasOne(d => d.Unit).WithMany(p => p.Products)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Unit");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Products)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Vendor");
        });

        modelBuilder.Entity<ProductCollection>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CollectionId).HasColumnName("CollectionID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Collection).WithMany(p => p.ProductCollections)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("FK_ProductCollections_Collection");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCollections)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductCollections_Product");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TagId).HasColumnName("TagID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductTags)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductTags_Product");

            entity.HasOne(d => d.Tag).WithMany(p => p.ProductTags)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK_ProductTags_Tag");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.ToTable("ProductType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductVariant>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Value).HasMaxLength(50);
            entity.Property(e => e.VariantId).HasColumnName("VariantID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductVariants)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariants_Product");

            entity.HasOne(d => d.Variant).WithMany(p => p.ProductVariants)
                .HasForeignKey(d => d.VariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariants_Variant");
        });

        modelBuilder.Entity<RelatedTag>(entity =>
        {
            entity.ToTable("RelatedTag");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CostumerId).HasColumnName("CostumerID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Costumer).WithMany(p => p.RelatedTags)
                .HasForeignKey(d => d.CostumerId)
                .HasConstraintName("FK_RelatedTag_Customer");

            entity.HasOne(d => d.Product).WithMany(p => p.RelatedTags)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_RelatedTag_Product");
        });

        modelBuilder.Entity<SearchEnginListing>(entity =>
        {
            entity.ToTable("SearchEnginListing");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.MetaDescription).HasMaxLength(320);
            entity.Property(e => e.PageTitle).HasMaxLength(70);
            entity.Property(e => e.Urlhandle)
                .HasMaxLength(100)
                .HasColumnName("URLHandle");
        });

        modelBuilder.Entity<ShopLocation>(entity =>
        {
            entity.ToTable("ShopLocation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

            entity.HasOne(d => d.Inventory).WithMany(p => p.ShopLocations)
                .HasForeignKey(d => d.InventoryId)
                .HasConstraintName("FK_ShopLocation_Product");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("Tag");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Tag_Tag");
        });

        modelBuilder.Entity<TimeLine>(entity =>
        {
            entity.ToTable("TimeLine");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BodyId).HasColumnName("BodyID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Header).HasMaxLength(200);
            entity.Property(e => e.TimelineTypeId).HasColumnName("TimelineTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Body).WithMany(p => p.TimeLines)
                .HasForeignKey(d => d.BodyId)
                .HasConstraintName("FK_TimeLine_Body");

            entity.HasOne(d => d.Customer).WithMany(p => p.TimeLines)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_TimeLine_Customer");

            entity.HasOne(d => d.User).WithMany(p => p.TimeLines)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_TimeLine_User");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.ToTable("Unit");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
        });

        modelBuilder.Entity<Variant>(entity =>
        {
            entity.ToTable("Variant");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.ToTable("Vendor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
