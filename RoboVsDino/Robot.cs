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
        public Robot(string robotName)
        {
            name = robotName;
            health = 10;
            powerlevel = 5;
            weapon = new Weapon();


        }


        //member methods

        public void RobotAttack(Dinosaur dinoBeingAttacked)
        {
            dinoBeingAttacked.health -= weapon.attackpower;
            Console.WriteLine("The Dinosaur " + dinoBeingAttacked.type + " just took damage from a robot");

        }



    }
}
