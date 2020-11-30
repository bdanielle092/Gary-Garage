using System;
public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine("Zoooooom!");
    }
    public override void Turn()
    {
        Console.WriteLine("Right");
    }
}