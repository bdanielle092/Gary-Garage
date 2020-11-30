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
        Console.WriteLine("Zoooooom!");
    }
    public override void Turn()
    {
        Console.WriteLine("left");
    }
}