﻿using rts_game.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models
{
    public class Faction
    {
        public string Name { get; set; }

        public HashSet<City> Cities { get; set; }

        public HashSet<BaseUnit> Units { get; set; }

        public int Currency { get; set; }
    }
}