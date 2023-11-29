using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        public int MaxDamage
        { 
            get { return _maxDamage; } 
            set { _maxDamage = value; } 
        }

        public string Name
        { 
            get { return _name; }
            set {  _name = value; } 
        }

        public int BonusHitChance
        { 
            get { return _bonusHitChance; } 
            set { _bonusHitChance = value; } 
        }

        public bool IsTwoHanded 
        { 
            get {  return _isTwoHanded; } 
            set { _isTwoHanded = value; } 
        }

        public int MinDamage
        {  
            get { return _minDamage; }
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

        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        public override string ToString() 
        {
            return string.Format($"{Name}\nDamage: {MinDamage} - {MaxDamage}\nBonus Hit: {BonusHitChance}\n" +
                $"Type: {(IsTwoHanded ? "Two Handed" : "One Handed")}")
        }


    }

    
}
