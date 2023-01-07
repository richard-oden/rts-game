using rts_game.Interfaces;

namespace rts_game.Models
{
    public class World
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public HashSet<IMappable> Mappables { get; set; } = new();
    }
}
