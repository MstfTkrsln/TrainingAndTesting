namespace EntityFrameworkFromExistingDbCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int Id { get; set; }
        [Column("Soyad")]
        [Required]
        [StringLength(10)]
        public string SurName { get; set; }

        public int City { get; set; }

        [Required]
        [StringLength(20)]
        public string Adress { get; set; }

    }
}
