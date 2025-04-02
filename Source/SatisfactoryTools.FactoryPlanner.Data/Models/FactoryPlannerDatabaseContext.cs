using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SatisfactoryTools.FactoryPlanner.Constants.Enums;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    public class FactoryPlannerDatabaseContext : DbContext
    {
        public DbSet<NodePurity> NodePurities { get; set; }
        public DbSet<BuildingCategory> BuildingCategories { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedNodePurityData(modelBuilder);
            SeedBuildingCategoryData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedNodePurityData(ModelBuilder modelBuilder)
        {
            var listOfPurities = new List<NodePurity>
            {
                new()
                {
                    Id = (int) NodePurityId.Impure,
                    Name = "Impure",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) NodePurityId.Normal,
                    Name = "Normal",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) NodePurityId.Pure,
                    Name = "Pure",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
            modelBuilder.Entity<NodePurity>().HasData(listOfPurities);
        }

        private void SeedBuildingCategoryData(ModelBuilder modelBuilder)
        {
            var listOfBuildingCategories = new List<BuildingCategory>
            {
                new()
                {
                    Id = (int) BuildingCategoryId.Special,
                    Name = "Special",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Extractors,
                    Name = "Extractors",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Smelting,
                    Name = "Smelting",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Manufacturing,
                    Name = "Manufacturing",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.PowerGenerator,
                    Name = "Power Generators",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.PowerGrid,
                    Name = "Power Grid",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.ItemConveyor,
                    Name = "Item Conveyors",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.FluidPipeline,
                    Name = "Fluid Pipelines",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Sorters,
                    Name = "Sorters",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Vehicles,
                    Name = "Vehicles",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Railway,
                    Name = "Railways",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Hypertubes,
                    Name = "Hypertubes",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.PioneerTransport,
                    Name = "Pioneer Transportation",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Organization,
                    Name = "Organization",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryId.Storage,
                    Name = "Storage",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                
                new()
                {
                    Id = (int) BuildingCategoryId.HolidayEvent,
                    Name = "Holiday Event",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
            modelBuilder.Entity<BuildingCategory>().HasData(listOfBuildingCategories);
        }
    }
}