using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace T_L_EKZ.DB_Model
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=RModel")
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<OrderDish> OrderDish { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Stages> Stages { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderDish)
                .WithOptional(e => e.Orders)
                .HasForeignKey(e => e.OrderID);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Workers)
                .WithOptional(e => e.Roles)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<Stages>()
                .HasMany(e => e.OrderDish)
                .WithOptional(e => e.Stages)
                .HasForeignKey(e => e.StageID);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.WaiterID);
        }
    }
}
