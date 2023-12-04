using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Rabbit : Monster
    {
        public bool IsFluffy { get; set; }

        public Rabbit(MonsterType getMonsterType, string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description, bool isFluffy)
            : base(getMonsterType, name, maxLife, hitChance, block, life, maxDamage, minDamage, description)
        {
            IsFluffy = isFluffy;
        }

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "Fluffy" : "Not so fluffy");
        }

        public override int CalcBlock()
        {

            int calculatedBlock = Block;

            // Apply 50% increase to rabbits block if it's fluffy

            if (IsFluffy) 
            {
                calculatedBlock += (calculatedBlock / 2);
            } 
            return calculatedBlock;
        }
    }
}
