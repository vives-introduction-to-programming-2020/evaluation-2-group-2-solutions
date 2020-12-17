using System;

namespace BRailButOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to B-Rail but on Time\n");

            Location bruges = new Location("Brugge", "8200");
            Location ostend = new Location("Ostend", "8400");

            Traject goingToWork = new Traject(ostend, bruges);

            Console.WriteLine(goingToWork);
        }
    }
}
