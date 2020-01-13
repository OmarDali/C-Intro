using System;
using System.Collections.Generic;
using System.Text;

namespace final_program
{
    class Weight
    {
        public void GetWeight()
        {
            Console.Clear();
            double WeightKilograms, WeightGrams, WeightPound, WeightOunce;
            String input;
            Console.WriteLine("Enter Weight in Kilograms\n=========================");
            input = Console.ReadLine();

            WeightKilograms = double.Parse(input);
            Console.WriteLine("Enter Weight in Grams");
            input = Console.ReadLine();
            WeightGrams = double.Parse(input);
            Console.WriteLine("Weight in Kilograms is {0}", WeightKilograms);
            Console.ReadLine();
            Console.WriteLine("Weight in Grams is {0}", WeightGrams);
            Console.ReadLine();
            WeightKilograms = WeightKilograms + (WeightGrams / 1000);
            WeightPound = WeightKilograms / 0.453592; WeightOunce = WeightPound * 16;
            Console.WriteLine("Weight in Pound is {0} lbs, and in Ounces is {1:F2} Oz", WeightPound, WeightOunce);
            Console.ReadLine();

        }
    }
}
