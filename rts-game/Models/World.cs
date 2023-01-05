using rts_game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models
{
    public class World
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public HashSet<IMappable> Mappables { get; set; } = new();
    }
}
