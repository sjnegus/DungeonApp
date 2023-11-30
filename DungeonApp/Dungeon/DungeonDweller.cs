using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonApp
{
    class Dungeon
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

            WeaponType userWeapon = (WeaponType)userInput;

            switch (userWeapon)
            {
                case WeaponType.Dagger:
                    Console.WriteLine("Flamethorn, a legendary dagger said to compel its bearer to defeat Gudaga the Crimson.");
                    break;
                case WeaponType.Broadsword:
                    Console.WriteLine("Fiendblade, a masterwork broadsword engraved with the holy symbol of a war god.");
                    break;
                case WeaponType.Bow:
                    Console.WriteLine("Lawtooth, a masterwork longbow said to be imbued with the spirit of the illustrious fighter Nelalwe. It once belonged to the great archer who fell in the War of Malefic Rings.");
                    break;
                case WeaponType.Sceptre:
                    Console.WriteLine("Drakehammer, a magical flail said to lead the one who wields it to wealth and glory");
                    break;
                case WeaponType.Claw:
                    Console.WriteLine("Ghoulclaw, a magical halberd inlaid with mithral. It is said to have been created to slay the Serpent of Underworld.");
                    break;
                case WeaponType.Wand:
                    Console.WriteLine("Corrupt Storm, a magical wand which once belonged to the great warrior Aisen, who fell in the Bloody Campaign.");
                    break;
                case WeaponType.Staff:
                    Console.WriteLine("Abyssal Vengeance, a mythical staff engraved with the holy symbol of a war god. It is said to be the key to open the Hell Gate of the Shadowy Mire.");
                    break;
                case WeaponType.Axe:
                    Console.WriteLine("Wraithrazor, a mythical battleaxe which once belonged to the illustrious warrior Amivy, who perished in the Desolation of Gudama.");
                    break;
                case WeaponType.Club:
                    Console.WriteLine("Fallen Vengeance, a legendary club which was created by the dwarves of the great empire of Khola.");
                    break;
                case WeaponType.Crowbar:
                    Console.WriteLine("Celestial Storm, a finely crafted bar engraved with runes of death. It once belonged to the legendary ranger Tholmge, who perished in the Caro Jungle.");
                    break;
                default:
                    break;
            }

            #endregion

            #region Player
            //TODO create player object
            #endregion


            bool main = false;

            do
            {
                Console.WriteLine(GetRoom());
                bool inner = false;
                do
                {
                    Console.WriteLine("\n\nHow do you proceed?\n" +
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

                            //TODO Add combat functionality
                            break;
                        case "R":
                            Console.WriteLine("Run");

                            //TODO Add run function
                            break;
                        case "C":
                            Console.WriteLine("Character Info");

                            //TODO Add character info
                            break;
                        case "M":
                            Console.WriteLine("Monster Info");

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
                    #endregion


                } while (!inner && !main);

            } while (!main);

            #region Output Final Score / End Game

            //TODO Output score
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