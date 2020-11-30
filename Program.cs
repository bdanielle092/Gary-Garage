using System;
using System.Collections.Generic;

namespace gray_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "red";
            fxs.MaximumOccupancy = "4";

            Tesla modelS = new Tesla();
            modelS.MainColor = "black";
            modelS.MaximumOccupancy = "2";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "blue";
            mx410.MaximumOccupancy = "4";

            Ram truck = new Ram();
            truck.MainColor = "grey";
            truck.MaximumOccupancy = "5";

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
