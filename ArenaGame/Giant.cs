using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Giant:Hero
    {
        const int BlockDamageChance = 15;
        private const int SuperDamageChance = 10;

       
        public Giant(string name) : base(name)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
         
            int damageReduceCoef = Random.Shared.Next(20, 61);
            incomingDamage =
                incomingDamage - ((incomingDamage * damageReduceCoef) / 100);
         
            if (ThrowDice(BlockDamageChance)) incomingDamage = 0;
        
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(SuperDamageChance)) attack = attack * 150 / 100;
            return attack;
        }
    }
}
