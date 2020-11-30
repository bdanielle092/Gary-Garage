using System;

public class Ram  : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }
 

    public void RefuelTank()
    {
        // method definition omitted
    }
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