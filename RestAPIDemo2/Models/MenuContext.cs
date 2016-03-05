namespace RestAPIDemo2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuModel")
        {
        }

        public virtual DbSet<menu_category> menu_category { get; set; }
        public virtual DbSet<menu_item> menu_item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<menu_category>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<menu_category>()
                .HasMany(e => e.menu_item)
                .WithRequired(e => e.menu_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<menu_item>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<menu_item>()
                .Property(e => e.url)
                .IsFixedLength();

            modelBuilder.Entity<menu_item>()
                .Property(e => e.component)
                .IsFixedLength();
        }
    }
}
