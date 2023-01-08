using rts_game.Enumerations;
using rts_game.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models
{
    public class Faction
    {
        public string Name { get; init; }

        public HashSet<City> Cities { get; set; }

        public HashSet<BaseUnit> Units { get; set; }

        public int Currency { get; set; } = 10;

        public bool IsPlayer { get; init; }

        public Hostility Hostility { get; init; }

        public static Faction InitialPlayerFaction(string playerName, int currency) =>
            new() { Name = playerName, IsPlayer = true, Units = new() { new Settler() }, Currency = currency };

        public static Faction InitialComputerFaction(string computerName, Hostility hostility, int currency) =>
            new() { Name = computerName, Hostility = hostility, Units = new() { new Settler() }, Currency = currency };
    }
}
