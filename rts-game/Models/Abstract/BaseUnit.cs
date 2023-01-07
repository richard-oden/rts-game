using rts_game.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts_game.Models.Abstract
{
    public abstract class BaseUnit : IMappable
    {
        private int _health;

        public virtual int MaxHealth { get; set; }

        public int Health
        {
            get => _health;
            set => _health = Math.Min(MaxHealth, value);
        }

        public virtual int MovementRadius { get; set; }

        public virtual int AttackRadius { get; set; }

        public virtual int AttackDamage { get; set; }

        public virtual int Armor { get; set; }

        public virtual int CurrencyCost { get; set; }

        public virtual int PopulationCost { get; set; }

        public Coordinate Coordinate { get; set; }

        public BaseUnit()
        {
            _health = MaxHealth;
        }
    }
}
