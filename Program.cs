using System;
using System.Collections.Generic;

namespace Tc_final_project_jesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RsbCom = random.Next(1, 3);

            int Rsb = 0;
            Console.WriteLine("Hey, dude choose rock, paper or scissors, (all lower case pls)");
            

            numList<string> nmLst = new List<string> { "rock", "paper", "scissors" };


            if (Rsb == "paper" && RsbCom == 3 ) {
                Console.WriteLine("You win against the computer");
            }

           
           
           
            // rr9 rp6 rs3 ss1 sr3 sp2 pp4 ps2 pr6 
            //r 3
            //p 2
            //s 1
        }
    }
}
