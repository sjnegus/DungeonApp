using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        // This is NOT intended to be a datatype class, so it will not
        // have fields, properties or constructors. It will simply serve
        // as a "warehouse" for a variety of methods related to combat.

        // Let's create a method to handle a one-sided attack
        public static void DoAttack(Character attacker, Character defender)
        {
            // Get a random number from 1-100
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            // Nothing is TRULY random in programming. The code execution of
            // our Random.Next() relies upon the time it is executed to influence 
            // the outcome. So, we can pause code execution briefly to help 
            // simulate the feeling of more random results. We can use
            // System.Threading.Thread.Sleep() for this.

            System.Threading.Thread.Sleep(30); // The number of milliseconds to pause code execution. 3% of one second.

            // If the attacker "hits"
            if (roll<=(attacker.CalcHitChance() - defender.CalcBlock()))
            {
                // Calculate the damage
                int damageDealt = attacker.CalcDamage();

                // Subtract and assign the damage to the defender's life
                defender.Life -= damageDealt;

                // Output the result - Red text helps indicate damage
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);

                Console.ResetColor();

            }
            // If the attacker misses,
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }

        }

        // Now, we can create a method to handle "battle" -- attacks from both sides

        public static void DoBattle(Player player, Monster monster)
        {
            #region Customization option - Initiative

            // Consider adding an Initiative property to Character, then check the 
            // Initiative of the Player and the Monster to determine who attacks first.

            // if (player.Initiative >= monster.Initiative)
            // {
            //     DoAttack(player, monster);
            // }
            // else
            // {
            //       DoAttack(monster, player);
            // }

            #endregion

            // For our example, we'll grant the Player "initiative" by default
            DoAttack(player, monster);
            // If the monster survives, they get to attack the Player back
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }


        }


    }
}
