using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Dinosaur
    {
        //member variables
        public string type;
        public double health;
        public double energy;
        public double attackpower;



        //contructor

        public Dinosaur(string type)
        {
            this.type = type;
            health = 12;
            energy = 5;
            attackpower = 2;



        }


        //member methods

        public void DinoAttack(Robot robotBeingAttacked)
        {
            robotBeingAttacked.health -= attackpower;
            Console.WriteLine("The Robot " + robotBeingAttacked.name + " just took " + attackpower + " damage from a dinosaur\n");

        }
        //creat method for decreasing Health based on 


    }


}
