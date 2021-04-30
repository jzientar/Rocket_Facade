using System;

namespace Rocket_Facade
{
    public class RocketFacade
    {
        private StructuralSystem Structural { get; set; }
        private PayloadSystem Payload { get; set; }
        private GuidanceSystem Guidance { get; set; }
        private PropulsionSystem Propulsion { get; set; }

        public RocketFacade()
        {
            Structural = new StructuralSystem();
            Payload = new PayloadSystem();
            Guidance = new GuidanceSystem();
            Propulsion = new PropulsionSystem();
        }
        public void LaunchingRocket()
        {
            Console.WriteLine("_______Starting up Rocket Systems_______");
            Structural.startStructuralSystem();
            Payload.checkingSystemIntegrity();
            Guidance.startGuidanceSystem();
            Propulsion.checkingEngine();
            System.Console.WriteLine("_______All systems are on and working_______");
        }
    }
}