using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Character
    {
        // -- FIELDS --

        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        // -- PROPERTIES -- 
        public string Name
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public int HitChance
        { 
            get { return _hitChance; }
            set { _hitChance = value; } 
        }
        
        public int Block
        { 
            get { return _block; } 
            set {  _block = value; } 
        }

        public int MaxLife
        { 
            get { return _maxLife; } 
            set { _maxLife = value; } 
        }

        public int Life
        { 
            get { return _life; }
            set
            {
                if (value <= MaxLife)

                    _life = value;
                else
                {
                    _life = MaxLife;
                }
            }
        }

        // -- CONSTRUCTORS --

        public Character(string name, int maxLife, int hitChance, int block, int life)
        {
            Name = name;
            MaxLife = maxLife;
            HitChance = hitChance;  
            Block = block;  
            Life = life;
        }

        // -- METHODS --

        public override string ToString()
        {
            //return base.ToString();
            return string.Format($"{Name}\nHP: {Life}/{MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}");
        }

    }
}
