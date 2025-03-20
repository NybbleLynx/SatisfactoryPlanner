using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SatisfactoryTools.FactoryPlanner.Constants.Enums;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    public class FactoryPlannerDatabaseContext : DbContext
    {
        public DbSet<NodePurity> NodePurities { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedNodePurityData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedNodePurityData(ModelBuilder modelBuilder)
        {
            var listOfPurities = new List<NodePurity>
            {
                new()
                {
                    Id = (int) ResourceNodePurityValue.Impure,
                    Name = "Impure",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ResourceNodePurityValue.Normal,
                    Name = "Normal",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ResourceNodePurityValue.Pure,
                    Name = "Pure",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
            modelBuilder.Entity<NodePurity>().HasData(listOfPurities);
        }
    }
}