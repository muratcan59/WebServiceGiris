namespace WebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderPayments
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public double Price { get; set; }

        public string Bank { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool IsDelete { get; set; }

        public int OrderType { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
