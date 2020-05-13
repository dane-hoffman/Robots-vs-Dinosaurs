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
        public double attackPower;





        //contructor
        public Robot(string robotName, double health)
        {
            name = robotName;
            this.health = health;
            powerlevel = 5;
            weapon = new Weapon();
            attackPower = weapon.attackpower + powerlevel - health;

        }


        //member methods

        public void RobotAttack(Dinosaur dinoBeingAttacked)
        {
            dinoBeingAttacked.health -= attackPower;

            Console.WriteLine("The Dinosaur " + dinoBeingAttacked.type + " just took " + attackpower + " damage from a robot\n");

        }



    }
}
