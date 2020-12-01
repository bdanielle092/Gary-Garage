using System;
using gray_garage;

//added a Interface
public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
{
    //props of the Zero
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; }

    //Method to charge the battery 
    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }

    //overriding whats in Vehicle. Vehicle is the parent/base.
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero Zoooooom by with {MaximumOccupancy} people in the car!");
    }
    public override void Turn()
    {
        Console.WriteLine("The Zero took a left");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero came to a stop!");
    }
}