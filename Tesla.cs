using System;
namespace gray_garage
{
    //added an Interface. 
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        //props of the Tesla
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        //method to charge Battery 
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        //overriding whats in Vehicle. Vehicle is the parent/base.
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla Mmmmmm on by!");
        }
        public override void Turn()
        {
            Console.WriteLine("The Tesla took a right turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla came to a stop slowly !");
        }
    }
}