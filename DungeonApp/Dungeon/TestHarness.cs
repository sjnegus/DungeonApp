using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Harness for Dungeon Dweller.");

           // Player pc1 = new Player("sam", 100, 75, 50, 100, Race.Shadow, WeaponType.Wand );
           // Console.WriteLine(pc1);

            Monster mon1 = new Monster(MonsterType.Witch, "Rhea of the Coos", 15,10,10,15,2,5,"Evil and darkness consume everything around her." );
            Console.WriteLine(mon1);
        }
    }
}
