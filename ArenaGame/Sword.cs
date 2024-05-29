using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Sword:Weapon
    {
        private const int Strength = 5;
        public Sword(int power) : base(power)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            int fifthDamage = incomingDamage * 5;
            incomingDamage = incomingDamage + (fifthDamage * 5 / 100);
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
