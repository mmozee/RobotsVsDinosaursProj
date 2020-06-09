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
        public List<Weapon> nameofweaponsinList; // The Fleet has 3 weapons to use
        public List<Robot> nameofRobotsinList;



        // constructor - Spawner


        public Fleet()   //constructors do not require return types because it is the object itself
        //accessibility (public)   Name of the Method(Fleet)    Parameters (whatever is needed)  

        {
            nameofweaponsinList = new List<Weapon>(); //instantiation has now been completed
            nameofRobotsinList = new List<Robot>();

            Weapon battleAxe = new Weapon(18, "Bob", "Knifey");//created new weapon
            nameofweaponsinList.Add(battleAxe);
            Weapon broadSword = new Weapon(27, "Fred", "Stabby");
            nameofweaponsinList.Add(broadSword);
            Weapon photonBlaster = new Weapon(85, "Myrtle", "Shooty");
            nameofweaponsinList.Add(photonBlaster);


            Weapon fingerGun = new Weapon(21, "fingerGun", "Gun");
            Weapon throwingStars = new Weapon(11, "throwingStars", "projectile");
            Weapon flamingLasso = new Weapon(18, "flamingLasso", "fire");

            Robot TinyTim = new Robot(75, "TinyTim", fingerGun, 18, 12);
            nameofRobotsinList.Add(TinyTim);
            Robot Minerva = new Robot(39, "Minerva", Weapon[1], 76, 60);
            nameofRobotsinList.Add(Minerva);
            Robot Felix = new Robot(75, "Felix", Weapon,  53, 81);
            nameofRobotsinList.Add(Felix);

            Felix.RobotAttacks(nameofweaponsinList[0]);
            Minerva.RobotAttacks(nameofweaponsinList[1]);
            TinyTim.RobotAttacks(nameofweaponsinList[2]);



        }
           
    }
}
