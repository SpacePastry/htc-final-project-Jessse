using System;
using System.Collections.Generic;

namespace Tc_final_project_jesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Would you like to start?");
            while (Console.ReadLine() == "yes"){
            int RsbCom = random.Next(1, 3);
            Console.WriteLine("Hey, dude choose rock, paper or scissors, (all lower case pls)");
            string Rsb = Console.ReadLine();

            List<string> nmLst = new List<string> { "rock", "paper", "scissors" };



            if (Rsb == "paper" && RsbCom == 3) {
                Console.WriteLine("You win against the computer");
            }
            else if (Rsb == "paper" && RsbCom == 2) {
                Console.WriteLine("You tied with the computer");
            }
            else if (Rsb == "paper" && RsbCom == 1) {
                Console.WriteLine("You lost against the computer");
            }
                        
            
            else if (Rsb == "rock" && RsbCom == 1 ) {
                Console.WriteLine("You win against the computer");
            }
            else if (Rsb == "rock" && RsbCom == 3) {
                Console.WriteLine("You tied with the computer");
            }
            else if (Rsb == "rock" && RsbCom == 2) {
                Console.WriteLine("You lost against the computer");
            }


            else if (Rsb == "scissors" && RsbCom == 2) {
                Console.WriteLine("You win against the computer");
            }
            else if (Rsb == "scissors" && RsbCom == 1) {
                Console.WriteLine("You tied with the computer");
            }
            else if (Rsb == "scissors" && RsbCom == 3) {
                Console.WriteLine("You lost against the computer");
            }
            else {
                Console.WriteLine("Please try again");
            }
            // rr9 rp6 rs3 ss1 sr3 sp2 pp4 ps2 pr6 
            //r 3
            //p 2
            //s 1

            Console.WriteLine("Would you like to play again?");
            continue;
            
            
            }
        }
    }
}
