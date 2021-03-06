namespace greed.Game.Casting
{
    /// <summary>
    /// <para>Gem flying in the space</para>
    /// <para>
    /// The responsibility of the gem is make the player earns a pointif hits the gem.
    /// </para>
    /// </summary>
    public class Gem : Actor
    {
        private int message = 1;

        /// <summary>
        /// Constructs a new instance of Gem.
        /// </summary>
        public Gem()
        {
        }

        /// <summary>
        /// Gets the Gem message.
        /// </summary>
        /// <returns>The message.</returns>
        public int GetMessage()
        {
            return message;
        }

    }
}