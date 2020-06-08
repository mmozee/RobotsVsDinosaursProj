using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //member variable - Has A (weapon has an attack power, name, type of weapon)
        int attackPower;
        string name;
        string typeOfWeapon;

        // constructor - Spawner
        public Weapon(int attackPower, string name, string typeOfWeapon)
        {
            this.attackPower = attackPower;
            this.name = name;
            this.typeOfWeapon = typeOfWeapon;
        }

        //member methods - Can Do
    }
}
