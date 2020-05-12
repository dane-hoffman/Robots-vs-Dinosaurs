using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Battlefield
    {
        //member variables
        public Fleet robotFleet;
        public Herd dinoHerd;





        //contructor
        public Battlefield()
        {
            robotFleet = new Fleet();
            dinoHerd = new Herd();

        }


        //member methods

        public void RunBattle()
        {

            //robot to attack dino

            robotFleet.robotOne.RobotAttack(dinoHerd.dinoOne);
            if(dinoHerd.dinoOne.health <= 0)
            {


            }

            // dino to attack robot

            dinoHerd.dinoOne.DinoAttack(robotFleet.robotOne);
        }




 
        


             //fleet and herd instantiation???????????/
    }
}
