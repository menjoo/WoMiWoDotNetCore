namespace WoMiWo.Model
{
    /// <summary>
    /// Represents a board game.
    /// </summary>
    public class BoardGame
    {
        /// <summary>
        /// Name of the game.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier of the game at BoardGameGeek.
        /// </summary>
        public int BggId { get; set; }

        /// <summary>
        /// Uri to an image of for the boxart of the game.
        /// </summary>
        public string BoxArtUri { get; set; }

        /// <summary>
        /// Minimum number of players needed to play the game.
        /// </summary>
        public int MinNrOfPlayers { get; set; }

        /// <summary>
        /// Maximum number of players that can play the game.
        /// </summary>
        public int MaxNrOfPlayers { get; set; }

        /// <summary>
        /// Minimum number of minutes needed to play the game.
        /// </summary>
        public int MinPlayingTime { get; set; }

        /// <summary>
        /// Maximum number of minutes needed to play the game.
        /// </summary>
        public int MaxPlayingTime { get; set; }

        /// <summary>
        /// Recommended age for playing the game.
        /// </summary>
        public int RecommendedAge { get; set; }

    }
}
