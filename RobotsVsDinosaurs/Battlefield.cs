using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        public Battlefield()
        { 
            theFleet = new Fleet();
            theHerd = new Herd();

        }
       

        public void RobotAttackSequence(Dinosaur dinoThatIsGettingAttacked, Robot robotThatIsAttacking)

        

        {
            Console.WriteLine("What weapon do You Want, Axe, Blaster, Sword?");
            string input = Console.ReadLine();
            if(input == "Axe")
            {
                Weapon SecondWeapon = theFleet.nameofweaponsinList[0];
                robotThatIsAttacking.RobotAttacks(SecondWeapon, dinoThatIsGettingAttacked);
                Console.WriteLine("Robot has just attacked!");
            }
            else if(input =="Blaster")
                {
                Weapon SecondWeapon = theFleet.nameofweaponsinList[1];
                robotThatIsAttacking.RobotAttacks(SecondWeapon, dinoThatIsGettingAttacked);
                Console.WriteLine("Robot has just attacked!");
            }
            else
                {
                Weapon SecondWeapon = theFleet.nameofweaponsinList[2];
                robotThatIsAttacking.RobotAttacks(SecondWeapon, dinoThatIsGettingAttacked);
                Console.WriteLine("Robot has just attacked!");
              
            }
            Console.WriteLine(dinoThatIsGettingAttacked.type + " just got attacked and now has "+ dinoThatIsGettingAttacked.healthLevel + " left");
        }
        public void DinoBitesSequence(Robot RobotThatIsGettingAttacked, Dinosaur DinoThatIsAttacking)
        {
            Console.WriteLine("What weapon Do You Want, Jaws, Eyes, Fist?");
            string input = Console.ReadLine();

            if (input =="Jaws")
            {
                Weapon Equalizer = theHerd.nameofweaponsinList2[0];
                DinoThatIsAttacking.DinoBites(RobotThatIsGettingAttacked, Equalizer);
                Console.WriteLine("Dinosaur has just attacked!");
            }
            if (input == "Eyes")
            {
                Weapon Equalizer = theHerd.nameofweaponsinList2[1];
                DinoThatIsAttacking.DinoBites(RobotThatIsGettingAttacked, Equalizer);
                Console.WriteLine("Dinosaur has just attacked!");
            }
            if (input == "Fist")
            {
                Weapon Equalizer = theHerd.nameofweaponsinList2[2];
                DinoThatIsAttacking.DinoBites(RobotThatIsGettingAttacked, Equalizer);
                Console.WriteLine("Dinosaur has just attacked!");
            }
            Console.WriteLine(RobotThatIsGettingAttacked.name + "just got spanked and now has" + RobotThatIsGettingAttacked.healthLevel +"remaining");
        }
        
            

        public void RunGame()
        {
            Console.WriteLine("Welcome, ARE YOU READY TO RUUUUUMMMMBBBBLEEEEEEE!");
            string UserInput = Console.ReadLine();
            if (UserInput == "yes")
            {
                Console.WriteLine("Pull up your Grannie Panties and prepare");
                Console.ReadLine();

                while (theFleet.nameofRobotsinList.Count > 0 && theHerd.nameofDinosaursinList.Count > 0)
                {
                    RobotAttackSequence(theHerd.nameofDinosaursinList[0] , theFleet.nameofRobotsinList[0]);
                    DinoBitesSequence(theFleet.nameofRobotsinList[0] , theHerd.nameofDinosaursinList[0]);

                    if(theHerd.nameofDinosaursinList[0].healthLevel <= 0)
                    {
                        theHerd.nameofDinosaursinList.RemoveAt(0);

                        Console.WriteLine("Honor your Dead and Muddle Through!");
                        Console.ReadLine();
                    }

                    if (theFleet.nameofRobotsinList[0].healthLevel <= 0)
                    {
                        theFleet.nameofRobotsinList.RemoveAt(0);
                        Console.WriteLine("Your Dead, Get Out the Way");
                        Console.ReadLine();
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Go Stand in the Corner Until you grow a Pair!");
                Console.ReadLine();

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

