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