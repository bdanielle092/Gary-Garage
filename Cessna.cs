using System;
namespace gray_garage
{
    //added an interface
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        //props of the Cessna
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        //Method to refuel the tank 
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        //overriding whats in Vehicle. Vehicle is the parent/base.
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna Zoooooom right by the store!");
        }
        public override void Turn()
        {
            Console.WriteLine("The Cessna took a Right on baker lane");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna stopped suddenly !");
        }
    }
}