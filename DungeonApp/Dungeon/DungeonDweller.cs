using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace Dungeon
{
    class DungeonDweller
    {
        static void Main(string[] args)
        {

            #region Title/Intro
            TitleIntro.Header("DUNGEON DWELLER");
            Console.WriteLine("\n\nWelcome to Underworld.\n\nPlease help us to defeat the evil that has taken over our world.\n\n");
            #endregion

            #region Variable to keep score
            int score = 0;
            //TODO create variable to keep score
            #endregion

            #region Weapon

            Console.Write("To continue, please choose your Weapon from the list below (enter number only):\n\n");

            int index = 0;

            foreach (var item in Enum.GetValues(typeof(WeaponType)))
            {
                Console.WriteLine(index + " - " + item);
                index++;
            }

            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();

            WeaponType userWeapon = (WeaponType)userInput;

            Weapon weapon = new Weapon();

            switch (userWeapon)
            {
                case WeaponType.Dagger:
                    Console.WriteLine("Flamethorn, a legendary dagger said to compel its bearer to defeat Gudaga the Crimson.\n");
                    //Weapon flamethorn = new Weapon("Flamethorn", 6, 2, 15, false, WeaponType.Dagger);
                    weapon.Name = "Flamethorn";
                    weapon.MaxDamage = 6;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 15;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Dagger;
                    
                    break;
                case WeaponType.Broadsword:
                    Console.WriteLine("Fiendblade, a masterwork broadsword engraved with the holy symbol of a war god.\n");
                    //Weapon weapon = new Weapon("Flamethorn", 6, 2, 15, false, WeaponType.Dagger);
                    weapon.Name = "Fiendblade";
                    weapon.MaxDamage = 7;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 15;
                    weapon.IsTwoHanded = true;
                    weapon.Type= WeaponType.Broadsword;
                    break;
                case WeaponType.Bow:
                    Console.WriteLine("Lawtooth, a masterwork longbow said to be imbued with the spirit of the illustrious fighter Nelalwe. It once belonged to the great archer who fell in the War of Malefic Rings.\n");
                    weapon.Name = "Lawtooth";
                    weapon.MaxDamage = 5;
                    weapon.MinDamage = 0;
                    weapon.BonusHitChance = 8;
                    weapon.IsTwoHanded = true;
                    weapon.Type = WeaponType.Bow;
                    break;
                case WeaponType.Sceptre:
                    Console.WriteLine("Drakehammer, a magical flail said to lead the one who wields it to wealth and glory\n");
                    weapon.Name = "Drakehammer";
                    weapon.MaxDamage = 5;
                    weapon.MinDamage = 1;
                    weapon.BonusHitChance = 10;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Sceptre;
                    break;
                case WeaponType.Claw:
                    Console.WriteLine("Ghoulclaw, a magical halberd inlaid with mithral. It is said to have been created to slay the Serpent of Underworld.\n");
                    weapon.Name = "Ghoulclaw";
                    weapon.MaxDamage = 4;
                    weapon.MinDamage = 0;
                    weapon.BonusHitChance = 12;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Claw;
                    break;
                case WeaponType.Wand:
                    Console.WriteLine("Corrupt Storm, a magical wand which once belonged to the great warrior Aisen, who fell in the Bloody Campaign.\n");
                    weapon.Name = "Corrupt Storm";
                    weapon.MaxDamage = 3;
                    weapon.MinDamage = 0;
                    weapon.BonusHitChance = 5;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Wand;
                    break;
                case WeaponType.Staff:
                    Console.WriteLine("Abyssal Vengeance, a mythical staff engraved with the holy symbol of a war god. It is said to be the key to open the Hell Gate of the Shadowy Mire.\n");
                    weapon.Name = "Abyssal Vengeance";
                    weapon.MaxDamage = 6;
                    weapon.MinDamage = 1;
                    weapon.BonusHitChance = 12;
                    weapon.IsTwoHanded = true;
                    weapon.Type = WeaponType.Staff;
                    break;
                case WeaponType.Axe:
                    Console.WriteLine("Wraithrazor, a mythical battleaxe which once belonged to the illustrious warrior Amivy, who perished in the Desolation of Gudama.\n");
                    weapon.Name = "Wraithrazor";
                    weapon.MaxDamage = 10;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 15;
                    weapon.IsTwoHanded = true;
                    weapon.Type = WeaponType.Axe;
                    break;
                case WeaponType.Club:
                    Console.WriteLine("Fallen Vengeance, a legendary club which was created by the dwarves of the great empire of Khola.\n");
                    weapon.Name = "Fallen Vengeance";
                    weapon.MaxDamage = 9;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 14;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Club;
                    break;
                case WeaponType.Crowbar:
                    Console.WriteLine("Celestial Storm, a finely crafted bar engraved with runes of death. It once belonged to the legendary ranger Tholmge, who perished in the Caro Jungle.\n");
                    weapon.Name = "Celestial Storm";
                    weapon.MaxDamage = 7;
                    weapon.MinDamage = 1;
                    weapon.BonusHitChance = 11;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Crowbar;
                    break;
                default:
                    break;
            }

            #endregion

            #region Player
            Player player = new Player("Leroy Jenkins", 70, 5, 40, 40, Race.Human, weapon);
            #endregion


            bool main = false;

            do
            {

                 Rabbit rabbit = new Rabbit(rabbit, "white rabbit", 50, 25, 25, 50, 20, 2, "rabbit", true);
                 Rabbit rabbit2 = new Rabbit(rabbit2, "white rabbit", 50, 25, 25, 50, 20, 2, "rabbit", true);

                 Vampire vampire = new Vampire( "Vampire", 50, 15, 15, 50, 10, 5, "bad mf");

                Monster[] monsters = {rabbit, rabbit2, vampire}; 

                Random randMonster = new Random();
                int randNbr = randMonster.Next(monsters.Length);

                Monster chosenMonster = monsters[randNbr];


                Console.WriteLine(GetRoom());


                Console.WriteLine("\nIn this room, you see a " + chosenMonster.Name);


                bool inner = false;
                do
                {
                    Console.WriteLine("\nHow do you proceed?\n" +
                        "A) Attack\n" +
                        "R) Run\n" +
                        "C) Character Info\n" +
                        "M) Monster Info\n" +
                        "X) eXit\n");
                    //ConsoleKey userChoice = Console.ReadKey(true).Key;   EXECUTES UPON INPUT, WITHOUT HITTING ENTER
                    string action = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (action)
                    {
                        case "A":
                            Console.WriteLine("Attack");

                            #region Option - Racial/Weapon Bonus

                            // You could consider giving bonuses based on the player's race, 
                            // weapon, the monster they are facing, etc.

                            // if (player.CharacterRace == Race.Leonin)
                            // {
                            //     Combat.DoAttack(player, chosenMonster);
                            // }
                            // if (player.EquippedWeapon.Name == "Fiendslayer" && chosenMonster.GetType().ToString() == "Fiend")
                            // {
                            //     Combat.DoAttack(player, chosenMonster);
                            // }


                            #endregion

                            // Execute combat
                            Combat.DoBattle(player, chosenMonster);

                            //Check if the monster is dead
                            if (chosenMonster.Life <= 0)
                            {

                                #region Option - Combat Rewards

                                // You could add some logic here to grant the Player life:
                                // player.Life += 5;
                                   
                                // Or, loot drops! (Note: This would require an Item class, 
                                // as well as a property for the player of type List<Item>):
                                   
                                // Item rubyNecklace = new Item("Ruby Necklace", "Increases Max Life", MaxLife, 10);
                                // player.Inventory.Add(rubyNecklace);
                                // Console.WriteLine($"{player.Name} received {rubyNecklace.Name}!");
                                // Console.WriteLine($"{rubyNecklace}");

                                #endregion

                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("\nYou killed {0}\n", chosenMonster.Name);

                                Console.ResetColor();

                                score++;

                                // Flip inner bool to exit the menu loop and get a new room and new monster
                                inner = true;
                            }

                            break;
                        case "R":
                            Console.WriteLine("{0} chooses to run away!", player.Name);

                            Console.WriteLine($"{chosenMonster.Name} attacks {player.Name} as they flee!");

                            Combat.DoAttack(chosenMonster, player);

                            Console.WriteLine();

                            inner = true;

                            break;
                        case "C":
                            Console.WriteLine(player);                            
                            
                            break;
                        case "M":
                            Console.WriteLine(chosenMonster);

                            //TODO Add monster info
                            break;
                        case "X":
                            Console.WriteLine("Thanks for playing!");
                            main = true;
                            break;
                        default:
                            Console.WriteLine("Input not recognized. Please try again.");
                            break;

                    }

                    #region Check Player Life
                    //TODO Check Player Life

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been vanquished.");

                        main |= true;
                    }
                    #endregion


                } while (!inner && !main);

            } while (!main);

            #region Output Final Score / End Game

            Console.WriteLine("You defeated " + score + " monster " + ((score == 1) ? "." : "s."));


            #endregion
        }
        #region Create GetRoom() Functionality
        public static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of lost souls.", 
                "You enter a quiet library... silence... nothing but silence....", 
                "You arrive in a room filled with chairs and a ticket stub machine... the dreaded DMV",
                "You entered a room with a horde of bats."
            };
            Random roomRand = new Random();
            int index = roomRand.Next(rooms.Length);
            string room = rooms[index];
            return room;
        }
        #endregion
    }

}