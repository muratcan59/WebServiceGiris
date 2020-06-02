using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class ProductDT
    {
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
    }
}
