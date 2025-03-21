using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SatisfactoryTools.FactoryPlanner.Constants.Enums;

namespace SatisfactoryTools.FactoryPlanner.Data.Models
{
    public class FactoryPlannerDatabaseContext : DbContext
    {
        public DbSet<NodePurity> NodePurities { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<BuildingCategory> BuildingCategories { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedNodePurityData(modelBuilder);
            SeedItemCategoryData(modelBuilder);
            SeedBuildingCategoryData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedNodePurityData(ModelBuilder modelBuilder)
        {
            var listOfPurities = new List<NodePurity>
            {
                new()
                {
                    Id = (int) ResourcePurityValue.Impure,
                    Name = "Impure",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ResourcePurityValue.Normal,
                    Name = "Normal",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ResourcePurityValue.Pure,
                    Name = "Pure",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
            modelBuilder.Entity<NodePurity>().HasData(listOfPurities);
        }

        private void SeedItemCategoryData(ModelBuilder modelBuilder)
        {
            var listOfItemCategories = new List<ItemCategory>
            {
                new()
                {
                    Id = (int) ItemCategoryValue.RawResource,
                    Name = "Raw Resource",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Liquid,
                    Name = "Liquid",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Gas,
                    Name = "Gas",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Fuel,
                    Name = "Fuel",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Component,
                    Name = "Component",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Equipment,
                    Name = "Equipment",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Collectible,
                    Name = "Collectible",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Flora,
                    Name = "Flora",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Fauna,
                    Name = "Fauna",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.HolidayEvent,
                    Name = "Holiday Event",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) ItemCategoryValue.Misc,
                    Name = "Miscellaneous",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
            };
            modelBuilder.Entity<ItemCategory>().HasData(listOfItemCategories);
        }

        private void SeedBuildingCategoryData(ModelBuilder modelBuilder)
        {
            var listOfBuildingCategories = new List<BuildingCategory>
            {
                new()
                {
                    Id = (int) BuildingCategoryValue.Special,
                    Name = "Special",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Extractors,
                    Name = "Extractors",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Smelting,
                    Name = "Smelting",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Manufacturing,
                    Name = "Manufacturing",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.PowerGenerator,
                    Name = "Power Generators",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.PowerGrid,
                    Name = "Power Grid",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.ItemConveyor,
                    Name = "Item Conveyors",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.FluidPipeline,
                    Name = "Fluid Pipelines",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Sorters,
                    Name = "Sorters",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Vehicles,
                    Name = "Vehicles",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Railway,
                    Name = "Railways",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Hypertubes,
                    Name = "Hypertubes",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.PioneerTransport,
                    Name = "Pioneer Transportation",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Organization,
                    Name = "Organization",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Storage,
                    Name = "Storage",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Foundations,
                    Name = "Foundations",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Walls,
                    Name = "Walls",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new()
                {
                    Id = (int) BuildingCategoryValue.Architecture,
                    Name = "Architecture",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
            modelBuilder.Entity<BuildingCategory>().HasData(listOfBuildingCategories);
        }
    }
}