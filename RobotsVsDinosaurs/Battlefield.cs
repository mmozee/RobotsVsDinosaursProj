using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        Fleet theFleet;
        Herd theHerd;
        //// member variables - Has A
        //List<Weapon> nameofweaponsinList; // The Battlefield has 3 weapons to use


        //// constructor - Spawner
        //public Battlefield()
        //{
        //    nameofweaponsinList = new List<Weapon>();
        //    battleAxe 
        //    photonBlaster 
        //    broadSword 
        //    weapons.Add(battleAxe);

        public void RobotAttackSequence()
        

        {
            Console.WriteLine("What weapon?");
            string input = Console.ReadLine();
            if(input == "Axe")
            {
                Weapon SecondWeapon = theFleet.nameofweaponsinList[0];
                theFleet.nameofRobotsinList[0].RobotAttacks(SecondWeapon, theHerd.nameofDinosaursinList[0]);
            }
            else if(input =="Blaster")
                {
                Weapon SecondWeapon = theFleet.nameofweaponsinList[1];
                theFleet.nameofRobotsinList[1].RobotAttacks(SecondWeapon, theHerd.nameofDinosaursinList[1]);
            }
            else
                {
                Weapon SecondWeapon = theFleet.nameofweaponsinList[2];
                theFleet.nameofRobotsinList[2].RobotAttacks(SecondWeapon, theHerd.nameofDinosaursinList[2]);
            }
        }
        public void DinoBitesSequence()
        {
            Console.WriteLine("What weapon?");
            string input = Console.ReadLine();

            if (input =="Jaws")
            {
                Weapon Equalizer = theHerd.nameofweaponsinList2[0];
                theHerd.nameofDinosaursinList[0].DinoBites(theFleet.nameofRobotsinList[0], Equalizer);
            }
            if (input == "Eyes")
            {
                Weapon Equalizer = theHerd.nameofweaponsinList2[1];
                theHerd.nameofDinosaursinList[1].DinoBites(theFleet.nameofRobotsinList[1], Equalizer);
            }
            if (input == "Fist")
            {
                Weapon Equalizer = theHerd.nameofweaponsinList2[2];
                theHerd.nameofDinosaursinList[2].DinoBites(theFleet.nameofRobotsinList[2], Equalizer);
            }

        }

         

            


           

        //}


        // member methods - Can Do


    }
    //There is a Battlefield

    //There are Weapons

    //Dinosaur enters Battlefield
    //Dinosaur gets a Weapon
    //Dinosaur identifies a robot
    //Dinosaur attacks a robot
    //Dinosaur takes a hit
    //Dinosaur loses Dies
    //Dinosaur is victorious
    //Robot enters Battlefield
}   //Robot gets a Weapon
            //Robot identifies a robot
            //Robot attacks a robot
            //Robot takes a hit
            //Robot loses Dies
            //Robot is victorious

