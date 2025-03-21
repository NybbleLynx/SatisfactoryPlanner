using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    [Table("buildingCategory", Schema = "satisfactoryPlanner")]
    [Index(nameof(Name))]
    public class BuildingCategory
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}