namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public partial class Place
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaceID { get; set; }

        [Required]
        [StringLength(255)]
        public string PlaceName { get; set; }

        public int? PlaceTypeID { get; set; }

        [Required]
        [StringLength(255)]
        public string PlaceAddress { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        public int PlaceRate { get; set; }

        public virtual PlaceType PlaceType { get; set; }
    }
}
