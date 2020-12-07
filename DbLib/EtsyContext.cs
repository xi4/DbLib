using DbLib.Models;
using Microsoft.EntityFrameworkCore;

namespace DbLib
{
    public class EtsyContext : DbContext
    {
        public EtsyContext(DbContextOptions<EtsyContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderInvoice> OrderInvoices { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItemDetail> OrderItemDetails { get; set; }
        public DbSet<OrderItemParams> OrderItemParams { get; set; }
        public DbSet<OrderItemWork> OrderItemWorks { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<ListingSku> ListingSkus { get; set; }
        public DbSet<ItemParam> ItemParams { get; set; }
        public DbSet<PhotoItem> PhotoItems { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<WorkListing> WorkListings { get; set; }
        public DbSet<Curse> Curses { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderNum> OrderNums { get; set; }


        public DbSet<Paper> Papers { get; set; }
        public DbSet<DocPaper> DocPapers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItemParams>()
                .HasKey(bc => new {bc.OrderItemId, bc.ItemParamId});

            modelBuilder.Entity<WorkListing>()
                .HasOne(e => e.workType)
                .WithMany(c => c.workListings)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(e => e.order)
                .WithMany(c => c.OrderItems)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(e => e.listing)
                .WithMany(c => c.OrderItems)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrderItem>()
                .HasOne(e => e.listingSku)
                .WithMany(c => c.orderItems)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrderItemWork>()
                .HasOne(e => e.OrderItem)
                .WithMany(c => c.OrderItemWorks)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Billing>()
                .HasOne(e => e.Payment)
                .WithMany(c => c.billings)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Payment>()
                .HasOne(e => e.user)
                .WithMany(c => c.payments)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DocPaper>()
                .HasOne(e => e.Paper)
                .WithMany(c => c.DocPapers)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WorkListing>()
                .HasOne(e => e.listingSku)
                .WithMany(c => c.workListings)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(e => e.Shop)
                .WithMany(e => e.Orders)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItemParams>().HasKey(i => new {i.ItemParamId, i.OrderItemId});

            modelBuilder.Entity<OrderItemParams>()
                .HasOne(e => e.ItemParam)
                .WithMany(e => e.OrderItemParams)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItemParams>()
                .HasOne(e => e.OrderItem)
                .WithMany(e => e.OrderItemParams)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserShop>().HasKey(bc => new {bc.shopId, bc.userId});

            modelBuilder.Entity<UserShop>()
                .HasOne(e => e.shop)
                .WithMany(e => e.worker)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Shop>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderItem>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderItemDetail>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            //modelBuilder.Entity<ItemParam>().Property(x=>x.property_id).IsRequired();

            modelBuilder.Entity<User>().HasIndex(c => c.Name).IsUnique();


            // modelBuilder.Entity<User>().HasData(new User { Name="Kirill", Password="Kirill" });
        }
    }
}