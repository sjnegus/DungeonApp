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
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            #endregion

            #region Variable to keep score
            int score = 0;
            //TODO create variable to keep score
            #endregion

            #region Weapon

            Console.Write("Please choose your Weapon from the list below (enter number only):\n\n");

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
                    Console.WriteLine("You selected Flamethorn, a legendary dagger said to compel its bearer to defeat Gudaga the Crimson.\n");
                    //Weapon flamethorn = new Weapon("Flamethorn", 6, 2, 15, false, WeaponType.Dagger);
                    weapon.Name = "Flamethorn";
                    weapon.MaxDamage = 6;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 15;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Dagger;
                    
                    break;
                case WeaponType.Broadsword:
                    Console.WriteLine("You selected Fiendblade, a masterwork broadsword engraved with the holy symbol of a war god.\n");
                    //Weapon weapon = new Weapon("Flamethorn", 6, 2, 15, false, WeaponType.Dagger);
                    weapon.Name = "Fiendblade";
                    weapon.MaxDamage = 7;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 15;
                    weapon.IsTwoHanded = true;
                    weapon.Type= WeaponType.Broadsword;
                    break;
                case WeaponType.Bow:
                    Console.WriteLine("You selected Lawtooth, a masterwork longbow said to be imbued with the spirit of the illustrious fighter Nelalwe. It once belonged to the great archer who fell in the War of Malefic Rings.\n");
                    weapon.Name = "Lawtooth";
                    weapon.MaxDamage = 5;
                    weapon.MinDamage = 0;
                    weapon.BonusHitChance = 8;
                    weapon.IsTwoHanded = true;
                    weapon.Type = WeaponType.Bow;
                    break;
                case WeaponType.Sceptre:
                    Console.WriteLine("You selected Drakehammer, a magical flail said to lead the one who wields it to wealth and glory\n");
                    weapon.Name = "Drakehammer";
                    weapon.MaxDamage = 5;
                    weapon.MinDamage = 1;
                    weapon.BonusHitChance = 10;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Sceptre;
                    break;
                case WeaponType.Claw:
                    Console.WriteLine("You selected Ghoulclaw, a magical halberd inlaid with mithral. It is said to have been created to slay the Serpent of Underworld.\n");
                    weapon.Name = "Ghoulclaw";
                    weapon.MaxDamage = 4;
                    weapon.MinDamage = 0;
                    weapon.BonusHitChance = 12;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Claw;
                    break;
                case WeaponType.Wand:
                    Console.WriteLine("You selected Corrupt Storm, a magical wand which once belonged to the great warrior Aisen, who fell in the Bloody Campaign.\n");
                    weapon.Name = "Corrupt Storm";
                    weapon.MaxDamage = 3;
                    weapon.MinDamage = 0;
                    weapon.BonusHitChance = 5;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Wand;
                    break;
                case WeaponType.Staff:
                    Console.WriteLine("You selected Abyssal Vengeance, a mythical staff engraved with the holy symbol of a war god. It is said to be the key to open the Hell Gate of the Shadowy Mire.\n");
                    weapon.Name = "Abyssal Vengeance";
                    weapon.MaxDamage = 6;
                    weapon.MinDamage = 1;
                    weapon.BonusHitChance = 12;
                    weapon.IsTwoHanded = true;
                    weapon.Type = WeaponType.Staff;
                    break;
                case WeaponType.Axe:
                    Console.WriteLine("You selected Wraithrazor, a mythical battleaxe which once belonged to the illustrious warrior Amivy, who perished in the Desolation of Gudama.\n");
                    weapon.Name = "Wraithrazor";
                    weapon.MaxDamage = 10;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 15;
                    weapon.IsTwoHanded = true;
                    weapon.Type = WeaponType.Axe;
                    break;
                case WeaponType.Club:
                    Console.WriteLine("You selected Fallen Vengeance, a legendary club which was created by the dwarves of the great empire of Khola.\n");
                    weapon.Name = "Fallen Vengeance";
                    weapon.MaxDamage = 9;
                    weapon.MinDamage = 2;
                    weapon.BonusHitChance = 14;
                    weapon.IsTwoHanded = false;
                    weapon.Type = WeaponType.Club;
                    break;
                case WeaponType.Crowbar:
                    Console.WriteLine("You selected Celestial Storm, a finely crafted bar engraved with runes of death. It once belonged to the legendary ranger Tholmge, who perished in the Caro Jungle.\n");
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
            Player player = new Player("Leroy Jenkins", 50, 75, 40, 50, Race.Human, weapon);
            Console.WriteLine(player);
            #endregion
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();

            bool main = false;

            do
            {

                Rabbit rabbit = new Rabbit(MonsterType.Rabbit, "Terry the Tooth", 25, 60, 25, 25, 15, 10, "This is no normal rabbit!", true);
                Rabbit rabbit2 = new Rabbit(MonsterType.Rabbit, "Lil Terry", 15, 50, 25, 15, 10, 2, "rabbit", true);

                Vampire vampire = new Vampire(MonsterType.Vampire, "Vampire", 25, 55, 15, 25, 10, 5, "bad mf");
                Turtle turtle = new(MonsterType.Turtle, "Franklin", 20, 50, 10, 20, 5, 1, "This is no turtle in a half-shell", 30, 15);
                Turtle turtle2 = new(MonsterType.Turtle, "Razortooth", 20, 66, 10, 20, 10, 2, "Does more damage, but he has weaknesses.", 5, 15);
                Monster zombie = new Monster(MonsterType.Zombies, "Undying corpse", 15, 66, 33, 15, 5, 2, "How many times must i kill you!?");
                Monster skeleton = new(MonsterType.Skeletons, "Bone Pile", 15, 66, 15, 15, 5, 1, "Trembling bones, rattling in your ear.");

                Monster[] monsters = {rabbit, rabbit2, vampire, turtle, turtle2, zombie}; 

                Random randMonster = new Random();
                int randNbr = randMonster.Next(monsters.Length);

                Monster chosenMonster = monsters[randNbr];


                Console.WriteLine(GetRoom());


                Console.WriteLine("\nIn this room, you see " + chosenMonster.Name);


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
                                player.Life += 5;
                                   
                                // Or, loot drops! (Note: This would require an Item class, 
                                // as well as a property for the player of type List<Item>):
                                   
                                // Item rubyNecklace = new Item("Ruby Necklace", "Increases Max Life", MaxLife, 10);
                                // player.Inventory.Add(rubyNecklace);
                                // Console.WriteLine($"{player.Name} received {rubyNecklace.Name}!");
                                // Console.WriteLine($"{rubyNecklace}");

                                #endregion

                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("\nYou defeated {0}. Congratulations, you gain 5 life.\n", chosenMonster.Name);

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
                            Console.WriteLine("Try again, this time follow the directions.");
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

            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));


            #endregion
        }
        #region Create GetRoom() Functionality
        public static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of lost souls.", 
                "You enter a desolate library... silence... nothing but silence....", 
                "You arrive in a room scattered with coffins and urns.",
                "You enter a room with a horde of bats.",
                "You are in a dark corridor, only lit by candleflame and spell light. Chanting fills the corridor."
            };
            Random roomRand = new Random();
            int index = roomRand.Next(rooms.Length);
            string room = rooms[index];
            return room;
        }
        #endregion
    }

}