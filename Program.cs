using System;
using System.Collections.Generic;

namespace gray_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truck = new Ram();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            truck.Drive();

            fxs.Turn();
            modelS.Turn();
            mx410.Turn();
            truck.Turn();

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            truck.Stop();


        }
    }
}
