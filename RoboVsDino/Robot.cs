using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerlevel;
        public Weapon weapon;






        //contructor
        public Robot(string robotName, int health, int powerlevel, Weapon weapon)
        {
            name = robotName;
            this.health = health;
            this.powerlevel = powerlevel;
            this.weapon = new Weapon();


        }


        //member methods



    }
}
