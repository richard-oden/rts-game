using rts_game.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models
{
    public class Settler : BaseUnit
    {
        public override int MaxHealth { get; set; } = 5;

        public override int MovementRadius { get; set; } = 3;

        public override int AttackRadius { get; set; } = 0;

        public override int AttackDamage { get; set; } = 0;

        public override int Armor { get; set; } = 0;
    }
}
