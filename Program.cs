using System;
using System.Collections.Generic;

namespace gray_garage
{
    class Program
    {
        // using classes to instantiate new objects
        static void Main(string[] args)
        {
            //making a new Zero called fxs. Then giving it a color and number of occupancy. 
            //what the battery percentage can be charge to and what percentage its at now
            Zero fxs = new Zero();
            fxs.MainColor = "red";
            fxs.MaximumOccupancy = "4";
            fxs.BatteryKWh = 100;
            fxs.CurrentChargePercentage = 50;

            Tesla modelS = new Tesla();
            modelS.MainColor = "black";
            modelS.MaximumOccupancy = "2";
            modelS.BatteryKWh = 100;
            modelS.CurrentChargePercentage = 20;

            Cessna mx410 = new Cessna();
            mx410.MainColor = "blue";
            mx410.MaximumOccupancy = "4";
            mx410.FuelCapacity = 100;
            mx410.CurrentTankPercentage = 30;

            Ram truck = new Ram();
            truck.MainColor = "grey";
            truck.MaximumOccupancy = "5";
            truck.FuelCapacity = 100;
            truck.CurrentTankPercentage = 70;

            // using interface to create list 
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                //objects to be used
                 fxs, modelS
            };

            Console.WriteLine("---Electric Vehicles---");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Your battery has {ev.CurrentChargePercentage} percentage left");
            }
            // looping through and charging the vehicle
            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }
            //looping through the Electric Vehicles to see there current charge Percentage again and make sure its charged 
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Your battery now has {ev.CurrentChargePercentage} percentage");
            }

            /***********************************************/
            Console.WriteLine("");


            // using interface to create list 
            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                //objects to be used in list
                truck, mx410
            };
            //looping through the Gas Vehicles to see there current fuel Percentage  
            Console.WriteLine("---Gas Vehicles---");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The Tank has {gv.CurrentTankPercentage} fuel left  ");
            }
            //looping through and refueling the tank 
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }
            //looping through the Gad Vehicles to see there current fuel Percentage again and make sure its refueled 
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Your tank now has {gv.CurrentTankPercentage} fuel ");
            }
            Console.WriteLine("");

            // Calling methods on instantiated objects
            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            truck.Drive();
            Console.WriteLine("");

            fxs.Turn();
            modelS.Turn();
            mx410.Turn();
            truck.Turn();
            Console.WriteLine("");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            truck.Stop();


        }
    }
}
