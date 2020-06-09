using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        // member variable - Has A
        public Weapon DinosaurWeapon; //different because object has another object

        // What does the dinosaur have - name, health level, power level, and a Weapon(from Weapon class), attack power level
        public int attackPower;
        public string type;
        public string typeOfWeapon;
        public int energyLevel;
        public int healthLevel;

        // constructor - Spawns
        public Dinosaur(int attackPower, string type, Weapon typeOfWeapon, int energyLevel, int healthLevel)
        {
            this.attackPower = attackPower;
            this.type = type;
            this.DinosaurWeapon = typeOfWeapon;
            this.energyLevel = energyLevel;
            this.healthLevel = healthLevel;
        }

        // member methods - Can Do
        public void DinoBites(Robot RobotToSmash, Weapon TieBreaker)
        {
            Console.WriteLine("They are coming, Let's Go!!");
            Console.WriteLine("You attack with :" + DinosaurWeapon.name + " and " + TieBreaker.name);

            RobotToSmash.healthLevel -= DinosaurWeapon.attackPower + TieBreaker.attackPower*2;
            if (RobotToSmash.healthLevel >= 50)
            {
                Console.WriteLine("You missed, Bite Em!");
                healthLevel -= 3;

            }
            else if (RobotToSmash.healthLevel <= 50)
            {
                Console.WriteLine("Direct Hit, Die Robot Die!");

            }

        }
    }
}
