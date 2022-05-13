namespace Provaider_phone
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phone_info
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string surname { get; set; }

        [Required]
        [StringLength(100)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(100)]
        public string date_of_birth { get; set; }

        [Required]
        [StringLength(100)]
        public string phone_number { get; set; }
    }
}
