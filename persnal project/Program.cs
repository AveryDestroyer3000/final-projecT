using System;
using System.Net.Security;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            int count = 0;
            int count1 = 0;

            string[] choices = new string[5] { "ROCK", "PAPER", "SCISSOR", "SPOCK", "LIZARD" };
            Random rnd = new Random();

            Console.WriteLine("Welcome to the games of Gavin");

            while (ans != "NO")
            {
                Console.WriteLine("Select any one: \n1->ROCK \n2->PAPER \n3->SCISSOR \n4->SPOCK \n5->LIZARD");
                
                int n = rnd.Next(0, 5);
                Console.WriteLine("Enter your choice:");
                string user = Console.ReadLine();
                if (user.Equals("1")) user = "ROCK";
                else if (user.Equals("2")) user = "PAPER";
                else if (user.Equals("3")) user = "SCISSOR";
                else if (user.Equals("4")) user = "SPOCK";
                else user = "LIZARD";
                Console.WriteLine("Player: " + user);
                Console.WriteLine("Computer:" + choices[n]);




                


                if (user == "ROCK" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "ROCK" && choices[n] == "PAPER")
                {
                    Console.WriteLine("Computer wins");
                    count1 += 1;
                }
                else if (user == "PAPER" && choices[n] == "ROCK")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "PAPER" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[n] == "ROCK")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "ROCK" && choices[n] == "SCISSORS")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "SCISSOR" && choices[n] == "PAPER")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
               else if (user == "SPOCK" && choices[n] == "ROCK")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user =="ROCK"  && choices[n] == "SPOCK")

                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "ROCK" && choices[n]=="PAPER")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "PAPER" && choices[n] == "ROCK")
                {

                    Console.WriteLine("User Wins");
                    count1 += 1;
                }
                else if (user ==  "ROCK" && choices[n] =="SCISSORS")
                {

                    Console.WriteLine("User Wins");
                    count1 += 1;
                }
                else if (user == "SCISSORS" && choices[n] == "ROCK")
                {

                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
               
                
               
                //-----------------------------------------------paper
                else if (user == "ROCK" && choices[n] =="LIZARD")
                {
                    Console.WriteLine("User Wins");
                    count += 1;
                }
                else if (user == "LIZARD" && choices[n] == "ROCK")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                //-------------------------------------------------------------ROCK
                else if (user == "LIZARD" && choices[n] == "SPOCK")
                {
                    Console.WriteLine("User Wins");
                    count += 1;
                }
                else if (user == "SPOCK" && choices[n] == "LIZARD")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
               
                else if (user == "PAPER" && choices[n] == "SPOCK")
                {
                    Console.WriteLine("User Wins");
                    count += 1;
                }
                else if (user == "SPOCK" && choices[n] == "PAPER")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                 else if (user == "PAPER" && choices[n] == "SPOCK")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SCISSORS" && choices[n] == "LIZARD")
                {
                    Console.WriteLine("User Wins");
                    count += 1;
                }
                else if (user == "LIZARD" && choices[n] == "SCISSORS")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                //--------------------------------------------------Paper
                else if (user == "LIZARD" && choices[n] == "PAPER")
                {
                    Console.WriteLine("User Wins");
                    count += 1;
                }
                else if (user == "PAPER" && choices[n] == "LIZARD")
                {
                   
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SPOCK" && choices[n] == "SCISSORS")
                {
                    Console.WriteLine("User Wins");
                    count += 1;
                }
                else if (user == "SISSSORS" && choices[n] == "SPOCK")
                {
                    Console.WriteLine("Computer Wins");
                    count += 1;
                }

                //--------------------------------------------same choice

                else if (user == "ROCK" && choices[n] == "ROCK")
                {
                    Console.WriteLine("Same choices");
                    count += 0;
                }
               else if (user == "PAPER" && choices[n] == "PAPER")
                {
                    Console.WriteLine("Same choices");
                    count += 0;
                }
               else if (user == "SCISSORS" && choices[n] == "SCISSORS")
                {
                    Console.WriteLine("Same choices");
                    count += 0;
                }
                else if (user == "SPOCK" && choices[n] == "SPOCK")
                {
                    Console.WriteLine("Same choices");
                    count += 0;
                }



               else if (user == "LIZARD" && choices[n] == "LIZARD")
                {
                    Console.WriteLine("Same choices");
                    count += 0;
                }


                {
                    Console.WriteLine("User wins " + count + " times");
                    Console.WriteLine("Computer wins " + count1 + " times");
                    Console.WriteLine("Do u want to continue(YES/NO):");
                    ans = Console.ReadLine().ToUpper();
                    Console.WriteLine("---------------------------------------");


                }



            }
           
        }
    }
}





   
        
    







