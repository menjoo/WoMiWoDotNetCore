using System.Collections.Generic;

namespace WoMiWo.Model
{
    /// <summary>
    /// Represents a user who plays boardgames.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Name of the player.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Collection of games in the users own collection.
        /// </summary>
        public ICollection<BoardGame> Collection { get; set; }
    }
}
