using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        // member variables - Has A
        List<Weapon> nameofweaponsinList; // The Fleet has 3 weapons to use


        // constructor - Spawner


        public Fleet()   //constructors do not require return types because it is the object itself
        //accessibility (public)   Name of the Method(Fleet)    Parameters (whatever is needed)  

        {
            nameofweaponsinList = new List<Weapon>(); //instantiation has now been completed
            Weapon battleAxe = new Weapon(18, "Bob", "Knifey");//created new weapon
            nameofweaponsinList.Add(battleAxe);
            Weapon broadSword = new Weapon(27, "Fred", "Stabby");
            nameofweaponsinList.Add(broadSword);
            Weapon photonBlaster = new Weapon(85, "Myrtle", "Shooty");
            nameofweaponsinList.Add(photonBlaster);



        }
           
    }
}
