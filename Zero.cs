using System;
public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }


    public void ChargeBattery()
    {
        // method definition omitted
    }
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