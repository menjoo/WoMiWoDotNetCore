using System.Collections.Generic;

namespace WoMiWo.Model
{
    /// <summary>
    /// Represents a group of board game players that regularly come together to play games.
    /// </summary>
    public class GamingGroup
    {
        /// <summary>
        /// Name of the group.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Members of the group.
        /// </summary>
        public ICollection<Profile> Members { get; set; }
    }
}
