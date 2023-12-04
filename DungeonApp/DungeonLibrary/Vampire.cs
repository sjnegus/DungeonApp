﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Vampire : Monster
    {
        public DateTime HourChangeBack { get; set; }

        public Vampire(MonsterType getMonsterType, string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description)
            : base(getMonsterType, name, maxLife, hitChance, block, life, maxDamage, minDamage, description)
        {
            HourChangeBack = DateTime.Now;

            // At night, our Vampire becomes significantly more dangerous

            if (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18)
            {
                HitChance = 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}\n{1}",
                            base.ToString(),
                            HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18 ? "Empowered by the night" : "Weakened by the daylight");
        }
    }
}
