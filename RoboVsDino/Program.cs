using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Click Enter to run a battle scenario of Robots vs Dinosaurs!");


            Battlefield battlefield = new Battlefield();

            battlefield.RunBattle();


            Console.ReadLine();
        }
    }
}
