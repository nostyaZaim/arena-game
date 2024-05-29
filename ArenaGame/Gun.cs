using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Gun : Weapon
    {

        private const int Strength = 2;
        public Gun(int power) : base(power)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            int doubleDamage = incomingDamage * 2;
            incomingDamage = incomingDamage + (doubleDamage * 2 / 100);
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
