using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Fleet
    {
        //member variables
        public List<Robot> robots;


        //contructor
        public Fleet()
        {

            robots = new List<Robot>();

            Robot robotOne = new Robot("Tod");
            Robot robotTwo = new Robot("Fred");
            Robot robotThree = new Robot("Destructron 3000");

            robots.Add(robotOne);
            robots.Add(robotTwo);
            robots.Add(robotThree);

            
        }



        //member methods

        // GoToBattle Method

    }
}
