using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Weapon
    {
        public int Power { get; private set; }

        public int Damage { get; private set; }
        public bool IsBroke { get { return Power <= 0; } }

        public Weapon(int power)
        {
            Power = power;
        }

        public virtual int Attack()
        {
            return (Power * Random.Shared.Next(80, 121)) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Damage = Damage - incomingDamage;
        }
    }
}
