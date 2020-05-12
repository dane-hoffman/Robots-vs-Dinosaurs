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
        public Robot robotOne;
        public Robot robotTwo;
        public Robot robotThree;
        public double fleetHealth;
        



        //contructor
        public Fleet()
        {

            robotOne = new Robot("Tod", 9, 6);
            robotTwo = new Robot("Fred", 9, 6);
            robotThree = new Robot("Destructron 3000", 9, 6);

            
        }



        //member methods

        // GoToBattle Method

    }
}
