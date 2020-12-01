using System;

namespace gray_garage
{
    //Interfaces group together common prop which you can then add other classes 
    public interface IGasVehicle
    {
        //props of a gas vehicle
        int CurrentTankPercentage { get; set; }

        //method for refueling the tank which is used in the Ram and Cessna
        public void RefuelTank();


    }
}