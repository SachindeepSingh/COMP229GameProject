namespace COMP229GameProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Team1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Team2 { get; set; }

        public int Team1Score { get; set; }

        public int Team2Score { get; set; }
    }
}
