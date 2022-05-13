namespace Provaider_phone
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adre
    {
        public int id { get; set; }

        [StringLength(100)]
        public string contry { get; set; }

        [StringLength(100)]
        public string city { get; set; }

        [StringLength(100)]
        public string street { get; set; }

        [StringLength(100)]
        public string house { get; set; }

        [StringLength(100)]
        public string apartment { get; set; }
    }
}
