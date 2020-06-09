using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {// member variable - Has A
        public Weapon RobotWeapon; //different because object has another object

        // What does the robot have - name, health level, power level, and a Weapon(from Weapon class), attack power level
        public int attackPower;
        public string name;
        public string typeOfWeapon;
        public int powerLevel;
        public int healthLevel;

        // constructor - Spawns
        public Robot(int attackPower, string name, Weapon typeOfWeapon, int powerLevel, int healthLevel)
        { this.attackPower = attackPower;
            this.name = name;
            this.RobotWeapon = typeOfWeapon;
            this.powerLevel = powerLevel;
            this.healthLevel = healthLevel;


        }


        // member methods - Can Do 
        public void RobotAttacks(Weapon attackingWeapon, Dinosaur DinoToAttack)

        {   //Robot will enter the Battlefield
            //Robot will grab a weapon
            //Robot will attack
            //Robot will hit target
            //Robot will miss target
            //Robot will get hit
            //Robot will dodge attack
            Console.WriteLine("Let's Get It On!");
            Console.WriteLine("You attack with :" + RobotWeapon.name +" and " + attackingWeapon.name);

            DinoToAttack.healthLevel -= RobotWeapon.attackPower + attackingWeapon.attackPower;
            if (DinoToAttack.healthLevel>=50)
            {
                Console.WriteLine("You missed, get to cover!");
                healthLevel-=20;

            }
            else if (DinoToAttack.healthLevel <= 50)
            {
                Console.WriteLine("Direct Hit, Great job Dino Murderer!");
               
            }
           

                                                 //Console.WriteLine("What weapon was grabbed");


        }


    }     


    //   



    //public void Robot()



}
