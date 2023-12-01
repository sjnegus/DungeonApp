using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Turtle : Monster
    {
        public int BonusBlock { get; set; } 
        public int HidePercent { get; set; }

        public Turtle(MonsterType getMonsterType, string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description, int bonusBlock, int hidePercent) : base(getMonsterType, name, maxLife, hitChance, block, life, maxDamage, minDamage, description)
        {
            BonusBlock = bonusBlock;
            HidePercent = hidePercent;
        }

        public override string ToString()
        {
            //return base.ToString();

            return String.Format("{0}\n{1}% chance it will hide, granting {2} bonus block.", base.ToString(), HidePercent, BonusBlock);
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            Random rand = new Random();
            int percent = rand.Next(101);
            if (percent <= HidePercent)
            {
                calculatedBlock += BonusBlock;
            }
            return calculatedBlock;
        }
    }
}
