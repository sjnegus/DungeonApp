using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        // -- FIELDS --
        
        private int _minDamage;


        // -- PROPERTIES -- 

        public int MinDamage
        {
            get
            {
                return _minDamage;
            }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public MonsterType GetMonsterType { get; set; }

        // -- CONSTRUCTORS --

        public Monster(MonsterType getMonsterType, string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description)
            : base(name, maxLife, hitChance, block, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            GetMonsterType = getMonsterType;
        }

        // -- METHODS --

        public override string ToString()
        {
            return string.Format($"**** MONSTER ****\n{Name}\n{GetMonsterType}\n\nHP: {Life}/{MaxLife}\nDamage: {MinDamage} - {MaxDamage}\nBlock Chance: {Block}\nDescription: {Description}");
        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            return rand.Next(MinDamage, MaxDamage + 1);

        }


    }
}
