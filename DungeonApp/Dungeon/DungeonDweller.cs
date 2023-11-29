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
            Console.WriteLine("Welcome to Underworld.\n\nPlease help us to defeat the evil that has taken over our world.\n\n");
            #endregion

            #region Variable to keep score
            int score = 0;
            //TODO create variable to keep score
            #endregion

            #region Weapon

            //TODO create weapon

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
                    Console.WriteLine("How do you proceed?\n" +
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