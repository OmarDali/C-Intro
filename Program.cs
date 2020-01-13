using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace final_program
{
    class Program
    {
        private static int index = 0;

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C# Intro Folder \n================");
                List<string> menuItems = new List<string>()
                {
                "Introduction",
                "GPA Calculator",
                "Height Conversion",
                "Volume Conversion",
                "Weight Conversion",
                "Distance Conversion",
                "Exit"
            };

                Console.CursorVisible = false;
                while (true)
                {
                    string selectedMenuItem = drawMenu(menuItems);
                    if (selectedMenuItem == "Introduction")
                    {
                        //Introduction Start
                        Team TeamInfo = new Team();
                        TeamInfo.GetIntroduction();


                        //Introduction End
                    }
                    else if (selectedMenuItem == "GPA Calculator")
                    {
                        //GPA Starts 

                        Console.Clear();
                        GPA gpacalculator = new GPA();
                        gpacalculator.GetGpa();

                        //GPA Ends
                    }


                    else if (selectedMenuItem == "Height Conversion")
                    {
                        //Height Conversion Start

                        Height HeightCalc = new Height();
                        HeightCalc.GetHeight();

                        //Height coversion End
                    }
                    else if (selectedMenuItem == "Volume Conversion")
                    {
                        // Volume Conversion Start

                        Console.Clear();
                    Volume VolumeCalc = new Volume();
                    VolumeCalc.GetVolume();
                             
                        // Volume Conversion End
                    }
                else if (selectedMenuItem == "Weight Conversion")
                {
                    // Weight Conversion Start

                    Weight WeightCalc = new Weight();
                    WeightCalc.GetWeight();
                    Console.Clear();

                    //Weight Conversion End
                }
                else if (selectedMenuItem == "Distance Conversion")
                {
                    //Distance Conversion Start

                    Distance DistanceCalc = new Distance();
                    DistanceCalc.GetDistance();

                    //Distance coversion End
                }
                else if (selectedMenuItem == "Exit")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            private static string drawMenu(List<string> items)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine(items[i]);
                    }
                    else
                    {
                        Console.WriteLine(items[i]);
                    }
                    Console.ResetColor();
                }

                ConsoleKeyInfo cKey = Console.ReadKey();

                if (cKey.Key == ConsoleKey.DownArrow)
                {
                    if (index == items.Count - 1)
                    {
                        //index = 0;
                    }
                    else { index++; }
                }
                else if (cKey.Key == ConsoleKey.UpArrow)
                {
                    if (index <= 0)
                    {
                        //index = menuItem.count - 1;
                    }
                    else { index--; }
                }
                else if (cKey.Key == ConsoleKey.Enter)
                {
                    return items[index];
                }
                else
                {
                    return "";
                }
                Console.Clear();
                return "";

            }

    }

}