using System;
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
        Robot robotOne;
        Robot robotTwo;
        Robot robotThree;



        //contructor
        public Fleet()
        {

            robotOne = new Robot("Tod", 9, 6);
            robotTwo = new Robot("Fred", 9, 6);
            robotThree = new Robot("Destructron 3000", 9, 6);
            
        }
         

        //member methods



    }
}
