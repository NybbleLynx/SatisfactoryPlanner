#region File Header
// ---------------------------------------------------------------------
// Filename: SatisfactoryPlannerDatabaseContext.cs
// Description: Entity Framework database context. Contains logic to set up database structure and model.
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

using Microsoft.EntityFrameworkCore;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    public class SatisfactoryPlannerDatabaseContext : DbContext
    {
        #region Entity DbSet Objects

        public DbSet<NodePurity> NodePurities { get; set; }

        #endregion

        public SatisfactoryPlannerDatabaseContext(DbContextOptions options) : base(options) { }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}