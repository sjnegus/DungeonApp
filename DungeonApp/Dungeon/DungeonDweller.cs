namespace DungeonApp
{
    class Dungeon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dungeon Dweller!\n");
            Console.WriteLine("To begin the game, create a player.");
            // TODO Create Player
            bool main = false;

            do
            {
                Console.WriteLine("\nPlease complete the following:\n" +
                    "M) Create Monster\n" +
                    "R) Create Room\n");

                string create = Console.ReadLine().ToUpper();

                Console.Clear();


                switch (create)
                {
                    case "M":
                        Console.WriteLine("Create a Monster!");
                        // TODO Create Monster
                        break;

                    case "R":
                        Console.WriteLine("Create a Room!");
                        // TODO Create Room
                        break;

                    default:
                        Console.WriteLine("Input not recognized. Please try again.");
                        break;
                }
                bool inner = false;
                do
                {
                    Console.WriteLine("You entered a room with a horde of bats. How do you proceed?\n" +
                        "A) Attack\n" +
                        "R) Run\n" +
                        "C) Character Info\n" +
                        "M) Monster Info\n" +
                        "X) eXit\n");

                    string action = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (action)
                    {
                        case "A":
                            Console.WriteLine("Attack");
                            break;
                        case "R":
                            Console.WriteLine("Run");
                            break;
                        case "C":
                            Console.WriteLine("Character Info");
                            break;
                        case "M":
                            Console.WriteLine("Monster Info");
                            break;
                        case "X":
                            Console.WriteLine("Thanks for playing!");
                            inner = true;
                            break;
                        default:
                            Console.WriteLine("Input not recognized. Please try again.");
                            break;

                    }



                } while (!inner);

            } while (!main);

        }

    }
    
}