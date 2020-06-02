namespace WebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Baskets = new HashSet<Baskets>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public int? BrandId { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }

        public int Stock { get; set; }

        public double Discount { get; set; }

        public string ImageUrl { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Baskets> Baskets { get; set; }
    }
}
