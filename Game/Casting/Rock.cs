namespace greed.Game.Casting
{
    /// <summary>
    /// <para>Rocks on the space.</para>
    /// <para>
    /// The responsibility of the rocks is to make the player loses a point if hits the rock.
    /// </para>
    /// </summary>
    public class Rock : Actor
    {
        private string message = "-1";

        /// <summary>
        /// Constructs a new instance of a Rock.
        /// </summary>
        public Rock()
        {
        }

        /// <summary>
        /// Gets the rock message.
        /// </summary>
        /// <returns>The message.</returns>
        public string GetMessage()
        {
            return message;
        }
    }
}