namespace WebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Baskets
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool IsDelete { get; set; }

        public virtual Products Products { get; set; }
    }
}
