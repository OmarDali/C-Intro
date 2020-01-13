using System;
using System.Collections.Generic;
using System.Text;

namespace final_program
{
    class Height
    {
        public void GetHeight()
        {
            Console.Clear();
            double HeightMeter, HeightCentimeters, HeightFeet, HeightInches;
            String input;
            Console.WriteLine("Enter Height in Meter\n=====================");
            input = Console.ReadLine();

            HeightMeter = double.Parse(input);
            Console.WriteLine("Enter Height in Centimetes");
            input = Console.ReadLine();
            HeightCentimeters = double.Parse(input);
            Console.WriteLine("Height in Meters is {0}", HeightMeter);
            Console.ReadLine();
            Console.WriteLine("Height in Centimeters is {0}", HeightCentimeters);
            Console.ReadLine();
            HeightMeter = HeightMeter + (HeightCentimeters / 100);
            HeightFeet = HeightMeter / .3048; HeightInches = HeightFeet * 12;
            Console.WriteLine("Your Height in feets is {0} F, and in Inches is {1:F2}IN", HeightFeet, HeightInches);
            Console.ReadLine();
        }
    }
}
