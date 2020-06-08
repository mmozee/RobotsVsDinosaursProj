using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {// member variables - Has A
        List<Weapon> nameofweaponsinList2; // The Fleet has 3 weapons to use


        // constructor - Spawner


        public Herd()   //constructors do not require return types because it is the object itself
        //accessibility (public)   Name of the Method(Fleet)    Parameters (whatever is needed)  

        {
            nameofweaponsinList2 = new List<Weapon>(); //instantiation has now been completed
            Weapon laser = new Weapon(79, "Gertie", "Shooty");//created new weapon
            nameofweaponsinList2.Add(laser);
            Weapon flameThrower = new Weapon(49, "Ted", "Firey");
            nameofweaponsinList2.Add(flameThrower);
            Weapon tailBlade = new Weapon(62, "Amanda", "Slashy");
            nameofweaponsinList2.Add(tailBlade);


        }
    }
}
