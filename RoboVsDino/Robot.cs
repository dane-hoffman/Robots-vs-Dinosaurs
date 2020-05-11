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
        string name;
        int health;
        int powerlevel;
        Weapon weapon = new Weapon();




        //contructor
        public Robot(string name, int health, int powerlevel, Weapon weapon)
        {
            name = "Tod";
            health = 9;
            powerlevel = 6;
            Weapon weapon = new Weapon("Laser Gun", 7);

        }


        //member methods



    }
}
