using System;
using System.Collections.Generic;
using System.Text;

namespace final_program
{
    class Distance
    {

        public void GetDistance()
        {
            Console.Clear();
            double DistanceKiloMeters, DistanceMeters, DistanceMile, DistanceFeet;
            String input;
            Console.WriteLine("Enter Distance in Kilometer\n=========================");
            input = Console.ReadLine();

            DistanceKiloMeters = double.Parse(input);
            Console.WriteLine("Enter Distance in Meters");
            input = Console.ReadLine();
            DistanceMeters = double.Parse(input);
            Console.WriteLine("Distance in Kilometers is {0}", DistanceKiloMeters);
            Console.ReadLine();
            Console.WriteLine("Distance in Meters is {0}", DistanceMeters);
            Console.ReadLine();
            DistanceKiloMeters = DistanceKiloMeters + (DistanceMeters / 1000);
            DistanceMile = DistanceKiloMeters / 1.60934; DistanceFeet = DistanceMile * 5280;
            Console.WriteLine("Distance in Miles is {0} M, and in Feet is {1:F2} F", DistanceMile, DistanceFeet);
            Console.ReadLine();
        }
    }
}
