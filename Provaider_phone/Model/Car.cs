namespace Provaider_phone
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int id { get; set; }

        [StringLength(100)]
        public string make { get; set; }

        [StringLength(100)]
        public string model { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }
    }
}
