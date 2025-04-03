#region File Header
// ---------------------------------------------------------------------
// Filename: NodePurity.cs
// Description: Add description here
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    [Table("nodePurity", Schema = "satisfactoryPlanner")]
    [Index(nameof(Name), IsUnique = true)]
    public class NodePurity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}