namespace WebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Districts
    {
        [Key]
        public int DistrictNum { get; set; }

        public string Name { get; set; }

        public int CityNum { get; set; }

        public virtual Cities Cities { get; set; }
    }
}
