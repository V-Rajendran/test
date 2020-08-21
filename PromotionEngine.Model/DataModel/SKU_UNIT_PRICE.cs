namespace PromotionEngine.Model.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PM.SKU_UNIT_PRICE")]
    public partial class SKU_UNIT_PRICE
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1)]
        public string Sku { get; set; }

        public decimal Price { get; set; }
    }
}
