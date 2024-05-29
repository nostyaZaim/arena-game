using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Gnome : Hero
    {
        private const int TripleDamageMagicLastDigit = 7;
        private const int HealEachNthRound = 2;
        private int attackCount;

        public Gnome(string name) : base(name)
        {
            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (attack % 25 == TripleDamageMagicLastDigit)
            {
                attack = attack * 3;
            }
            attackCount = attackCount + 1;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
