using System;

namespace Rocket_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            RocketFacade facade = new RocketFacade();
            facade.LaunchingRocket();
            Console.ReadKey();
        }
    }
}
