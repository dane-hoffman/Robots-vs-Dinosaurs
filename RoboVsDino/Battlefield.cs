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

            while (fleet.robots.Count > 0 && herd.dinosaurs.Count > 0)
            {
                fleet.robots[0].RobotAttack(herd.dinosaurs[0]);
                if (herd.dinosaurs[0].health <= 0)
                {
                    herd.dinosaurs.RemoveAt(0);

                }


                herd.dinosaurs[0].DinoAttack(fleet.robots[0]);
                if (fleet.robots[0].health <= 0)
                {
                    fleet.robots.RemoveAt(0);

                }


            }

            if(fleet.robots.Count > 0)
            {
                Console.WriteLine("The Robots have one the battle!");

            }

            else
            {

                Console.WriteLine("The Dinosaurs have one the battle!");

            }


        }




 
        


             //fleet and herd instantiation???????????/
    }
}
