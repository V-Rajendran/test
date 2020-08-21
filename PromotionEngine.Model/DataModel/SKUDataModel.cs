namespace PromotionEngine.Model.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SKUDataModel : DbContext
    {
        public SKUDataModel()
            : base("name=SKUDataModel")
        {
        }

        public virtual DbSet<SKU_UNIT_PRICE> SKU_UNIT_PRICE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SKU_UNIT_PRICE>()
                .Property(e => e.Sku)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SKU_UNIT_PRICE>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
