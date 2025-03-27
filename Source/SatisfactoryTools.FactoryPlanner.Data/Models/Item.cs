using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    [Table("itemCategory", Schema = "satisfactoryPlanner")]
    [Index(nameof(Name))]
    public class Item
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("category")]
        public ItemCategory ItemCategory { get; set; }

        [Required]
        [Column("stackSize")]
        public int StackSize { get; set; }

        [Required]
        [Column("sinkable")]
        public bool Sinkable { get; set; }

        [Required]
        [Column("sinkPoints")]
        public int AwesomeSinkPoints { get; set; }

        [Required]
        [Column("radioactive")]
        public bool Radioactive { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

    }
}