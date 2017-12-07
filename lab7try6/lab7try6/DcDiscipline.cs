namespace lab7try6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DcDiscipline")]
    public partial class DcDiscipline
    {
        public int DcDisciplineId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
