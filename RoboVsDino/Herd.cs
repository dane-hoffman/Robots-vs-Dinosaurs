using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Herd
    {

        //member variables
        public List<Dinosaur> dinosaurs;


        //contructor
        public Herd()
        {

            dinosaurs = new List<Dinosaur>();


            Dinosaur dinoOne = new Dinosaur("T-Rex");
            Dinosaur dinoTwo = new Dinosaur("Carl");
            Dinosaur dinoThree = new Dinosaur("Arcteryx");

            dinosaurs.Add(dinoOne);
            dinosaurs.Add(dinoTwo);
            dinosaurs.Add(dinoThree);


        }


        //member methods


    }
}
