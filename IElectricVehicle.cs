using System;

namespace gray_garage
{
    //Interfaces group together common prop which you can then add other classes 
    public interface IElectricVehicle
    {
        //props of an electric vehicle
        int CurrentChargePercentage { get; set; }

        //method for charging the battery which is used in the Tesla and Zero
        public void ChargeBattery();


    }
}
