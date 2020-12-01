using System;

namespace gray_garage
{
    //An interface in C# is a construct that you define for classes to implement. Think of it as a contract 
    // If a class implements an interface, then it must define a method, property, or event for each one 
    //defined in the interface.

    //Interfaces group together common prop which you can then add other classes 
    public interface IElectricVehicle
    {
        //props of an electric vehicle
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }

        //method for charging the battery which is used in the Tesla and Zero
        public void ChargeBattery();


    }
}
