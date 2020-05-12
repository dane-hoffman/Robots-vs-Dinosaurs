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
        public double health;
        public double powerlevel;
        public Weapon weapon;






        //contructor
        public Robot(string robotName, double health, double powerlevel)
        {
            name = robotName;
            this.health = health;
            this.powerlevel = powerlevel;
            weapon = new Weapon();


        }


        //member methods



    }
}
