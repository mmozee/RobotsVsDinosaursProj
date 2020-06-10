using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {// member variables - Has A
        public List<Weapon> nameofweaponsinList2; // The Fleet has 3 weapons to use
        public List<Dinosaur> nameofDinosaursinList;



        // constructor - Spawner


        public Herd()   //constructors do not require return types because it is the object itself
        //accessibility (public)   Name of the Method(Fleet)    Parameters (whatever is needed)  

        {
            nameofweaponsinList2 = new List<Weapon>(); //instantiation has now been completed
            nameofDinosaursinList = new List<Dinosaur>();

            Weapon laser = new Weapon(15, "Gertie", "Shooty");//created new weapon
            nameofweaponsinList2.Add(laser);
            Weapon flameThrower = new Weapon(9, "Ted", "Firey");
            nameofweaponsinList2.Add(flameThrower);
            Weapon tailBlade = new Weapon(15, "Amanda", "Slashy");
            nameofweaponsinList2.Add(tailBlade);

            Weapon jawsOfDeath = new Weapon(21, "jawsOfDeath", "Teeth");
            Weapon eyesOfSorrow = new Weapon(11, "eyesOfSorrow", "Projectile");
            Weapon hammerFist = new Weapon(18, "hammerFist", "Hammer");

            Dinosaur Roki = new Dinosaur(12, "Amargasaurus", jawsOfDeath, 63, 91);
            nameofDinosaursinList.Add(Roki);
            Dinosaur Night = new Dinosaur(8, "Citipati", eyesOfSorrow, 71, 52);
            nameofDinosaursinList.Add(Night);
            Dinosaur Amelia = new Dinosaur(24, "Utahraptor", hammerFist, 59, 84);
            nameofDinosaursinList.Add(Amelia);

           

            //Roki.DinoBites(Robot.Felix, nameofweaponsinList2[0]);
            //Night.DinoBites(nameofweaponsinList2[1]);
            //Amelia.DinoBites(nameofweaponsinList2[2]);
        }
    }
}
