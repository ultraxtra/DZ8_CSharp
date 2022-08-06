using System;
using static System.Console;
using System.Collections.Generic;
namespace DZ8_CSharp
{
    public class Programm
    {
        
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            Problem3();
        }

        public static void Problem1()
        {
            Ocean ocean1 = new Ocean();
            WriteLine("Ocean animals:\n");

            foreach (OceanAnimals oceanAnimals1 in ocean1)
            {
                WriteLine(oceanAnimals1);
            }
        }

        public static void Problem2()
        {
            FootballTeam football = new FootballTeam();
            WriteLine("Ocean animals:\n");

            foreach (Footballers footballers in football)
            {
                WriteLine(footballers);
            }
        }

        public static void Problem3()
        {
            Caffee cafees = new Caffee();
            WriteLine("Cafee workers:\n");
            foreach(CafeeWorkeres cafeeWorkeres in cafees)
            {
                WriteLine(cafeeWorkeres);
            }
        }
    }
}

