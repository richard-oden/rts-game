using rts_game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models
{
    public class City : IMappable
    {
        private int _infrastructure;
        private int _population;

        public int MaxInfrastructure { get; set; }

        public int Infrastructure
        {
            get => _infrastructure;
            set => _infrastructure = Math.Min(MaxInfrastructure, value);
        }

        public int MaxPopulation { get; set; }

        public int Population 
        {
            get => _population;
            set => _population = Math.Min(MaxPopulation, value);
        }

        public int Radius => Population / 5;

        public Coordinate Coordinate { get; set; }
    }
}
