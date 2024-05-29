using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Axe:Weapon
    {

        private const int Strength = 3;
        public Axe(int power) : base(power)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            int tripleDamage = incomingDamage * 3;
            incomingDamage = incomingDamage + (tripleDamage * 3 / 100);
            if (Damage < incomingDamage) incomingDamage = 0;

            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack() + Strength;
            return attack;
        }
    }
}
