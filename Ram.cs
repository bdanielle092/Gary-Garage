using System;
namespace gray_garage
{
    //Added an Interface.
    //Vehicle is the parents. you can only have one interface. 
    //Ram is the child
    //you have to bring in the props of the interface because the interface is the construct
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        //props of the Ram 
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        //method to refuel the tank 
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        //overriding whats in Vehicle. Vehicle is the parent/base.
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram Rrrruuuummmbbble on by!");
        }
        public override void Turn()
        {
            Console.WriteLine("The Ram turned left");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram came to a quick stop!");
        }
    }
}