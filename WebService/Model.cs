namespace WebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelE")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Baskets> Baskets { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderPayments> OrderPayments { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserAddresses> UserAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.Orders)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderPayments)
                .WithOptional(e => e.Orders)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Baskets)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId);
        }
    }
}
