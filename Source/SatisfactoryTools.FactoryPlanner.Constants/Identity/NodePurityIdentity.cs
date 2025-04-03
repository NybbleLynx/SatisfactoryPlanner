#region File Header
// ---------------------------------------------------------------------
// Filename: NodePurityIdentity.cs
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

namespace SatisfactoryTools.FactoryPlanner.Constants.Identity
{
    public class NodePurityIdentity : IdentityBase<NodePurityIdentity>
    {
        public static readonly NodePurityIdentity Impure = new(1, "Impure");
        public static readonly NodePurityIdentity Normal = new(2, "Normal");
        public static readonly NodePurityIdentity Pure = new(3, "Pure");

        /// <inheritdoc />
        public NodePurityIdentity(int id, string name) : base(id, name) { }
    }
}