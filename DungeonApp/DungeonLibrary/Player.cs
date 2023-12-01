using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        // -- FIELDS --



        // -- PROPERTIES --

        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }


        // -- CONSTRUCTORS --

        public Player(string name, int maxLife, int hitChance, int block, int life, Race characterRace, Weapon equippedWeapon) : base(name, maxLife, hitChance, block, life)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;

        }


    // -- METHODS --

    public override string ToString()
        {
            return base.ToString() + "\nRace: " + CharacterRace + "\nWeapon: " + EquippedWeapon + "\n";
        }

        public override int CalcDamage()
        { 
            Random rand = new Random();

            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

    }
}
