using rts_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Interfaces
{
    public interface IMappable
    {
        Coordinate Coordinate { get; set; }
    }
}
