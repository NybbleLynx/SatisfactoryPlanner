#region File Header
// ---------------------------------------------------------------------
// Filename: IdentityBase.cs
// Description: Provides generic base functionality for constant identity types allowing for optimized enum functionality.
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

using System.Collections.Generic;

namespace SatisfactoryTools.FactoryPlanner.Constants.Identity
{
    public abstract class IdentityBase<T> where T : IdentityBase<T>
    {
        private static readonly Dictionary<int, T> identites = new();

        protected IdentityBase(int id, string name)
        {
            Id = id;
            Name = name;

            identites.Add(id, (T) this);
        }

        public int Id { get; }
        public string Name { get; }

        public static T Get(int id) => identites[id];
    }
}