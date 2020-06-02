namespace WebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAddresses
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool IsDelete { get; set; }

        public int? CityNum { get; set; }

        public int? DistrictNum { get; set; }
    }
}
