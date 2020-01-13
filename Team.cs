using System;
using System.Collections.Generic;
using System.Text;

namespace final_program
{
    class Team
    {
        public void GetIntroduction()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Greetings!\n----------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("My name is Omar. I was born in Richmond, VA. I lived in Egypt for twelve years then I moved back to the US in 2010." +
                Environment.NewLine+
                "I play soccer. My favorite cuisine is Middle Eastern and I love icecream. I went to VCU College and I recently graduated" +
                Environment.NewLine+
                "with a degree in Business Information Systems. " +
                Environment.NewLine +
                "This sample provide calculators for GPA, height, volume, weight, and distant conversion.  <Press Enter to continue>");
            Console.ReadKey();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nMy name is Gideon. I am originally from NIgeria and I love playing sports. <Press Enter to continue>");
            //Console.ReadKey();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write("\nMy name is Omar Mohammed. I love video games, and I don't like school. <Press Enter to continue>");
            //Console.ReadKey();
            Console.Read();
        }
    }
}
