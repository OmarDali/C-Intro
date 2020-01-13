using System;
using System.Collections.Generic;
using System.Text;

namespace final_program
{
    class Volume
    {
        public void GetVolume()
        {

            Console.Clear();
            double VolumeLiters, VolumeMilliliters, VolumeGallons, VolumeFlounce;
            String input;
            Console.WriteLine("Enter Volume in Liters\n==============");
            input = Console.ReadLine();

            VolumeLiters = double.Parse(input);
            Console.WriteLine("Enter Volume in Milliliters");
            input = Console.ReadLine();
            VolumeMilliliters = double.Parse(input);
            Console.WriteLine("Volume in Liters is {0}", VolumeLiters);
            Console.ReadLine();
            Console.WriteLine("Volume in Milliliters is {0}", VolumeMilliliters);
            Console.ReadLine();
            VolumeLiters = VolumeLiters + (VolumeMilliliters / 1000);
            VolumeGallons = VolumeLiters / 3.78541; VolumeFlounce = VolumeGallons * 128;
            Console.WriteLine("Volume in Gallons is {0} G, and in Fluid ounce is {1:F2} Fl Oz", VolumeGallons, VolumeFlounce);
            Console.ReadLine();

        }
    }
}
