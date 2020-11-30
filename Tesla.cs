using System;

public class Tesla : Vehicle // Electric car
{
    public double BatteryKWh { get; set; }
    

    public void ChargeBattery()
    {
        // method definition omitted
    }
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