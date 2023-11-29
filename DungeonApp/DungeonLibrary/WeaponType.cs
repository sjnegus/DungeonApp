using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public enum WeaponType
    {
        
        /*  1. Open the Dungeon Application project in Visual Studio
            2. Open Git Repository and make sure that the Main branch is checked out.
            3. Right click on the Main branch and select pull to ensure you have the latest version of the code.
            4. Right click on the Main branch and select New Branch From
            5. Enter a name for the branch. The suggested name is Block3Lab.
            6. In the DungeonLibrary project, add a public enum called Race to hold player type values. The enum should contain a minimum of 5 values.
            a. Examples of values:
            i. Orc
            ii. Human
            iii. Elf
            iv. Dwarf
            7. In the DungeonLibrary project, add a public enum called WeaponType. The enum should contain a minimum of 5 values
            a. Example Values
            i. Sword
            ii. Knife
            iii. Projectile
            iv. Laser
            8. Update the Weapon class to use the WeaponType enum
            a. Add a field/property for Type with is of data type WeaponType
            b. Add Type to the FQCTOR
            c. Add Type to the ToString()
            9. Click on Git Changes.
            10. Enter a commit message and then click Commit All and Push (use the dropdown beside the button).
            11. On GitHub, merge the Block3Lab branch into the main branch
        */

        Dagger,
        Broadsword,
        Bow,
        Sceptre,
        Claw,
        Wand,
        Staff,
        Axe,
        Club,
        Crowbar
                 
    }
}
