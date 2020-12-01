using System;
using gray_garage;

//Added an Interface
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