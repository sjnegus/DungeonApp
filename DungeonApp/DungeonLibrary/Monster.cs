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
        private int _maxDamage;
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
                if (value >= _maxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = MaxDamage;
                }
            }
        }
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public MonsterType GetMonsterType { get; set; }

        // -- CONSTRUCTORS --

        public Monster(MonsterType getMonsterType, string name, int maxLife, int hitChance, int block, int life, int minDamage, int maxDamage, string description)
            : base(name, maxLife, hitChance, block, life)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
            GetMonsterType = getMonsterType;
        }

        // -- METHODS --

        public override string ToString()
        {
            return string.Format($"{Name}\n{GetMonsterType}\n\nHP: {Life}/{MaxLife}\nDamage: {MinDamage} - {MaxDamage}\nBlock Chance: {Block}\nDescription: {Description}");
        }


    }
}
