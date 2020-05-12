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
        public Fleet fleet;
        public Herd herd;





        //contructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();

        }


        //member methods

        public void RunBattle()
        {

            //robot to attack dino

            fleet.robots[0].RobotAttack(herd.dinosaurs[0]);
            if(herd.dinosaurs[0].health <= 0)
            {
                herd.dinosaurs.RemoveAt(0);

            }

            // dino to attack robot

            herd.dinosaurs[0].DinoAttack(fleet.robots[0]);
            if(fleet.robots[0].health <= 0)
            {
                fleet.robots.RemoveAt(0);

            }


        }




 
        


             //fleet and herd instantiation???????????/
    }
}
