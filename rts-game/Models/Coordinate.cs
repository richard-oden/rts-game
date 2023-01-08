using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models
{
    public struct Coordinate
    {
        public int X;

        public int Y;

        public double DistanceTo(Coordinate other) =>
            Math.Sqrt((Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)));
    }
}
