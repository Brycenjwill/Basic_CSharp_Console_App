using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Brycen Williams";
            string location = "Kennett Square, PA";

            Console.WriteLine($"My name is {name}, I am from {location}!");

            DateTime today = DateTime.Today; //Get current date w hour
            DateTime christmas = new DateTime(today.Year, 12, 25);
            Console.WriteLine($"Today is {today.ToString("d")}."); //Convert to date only using toString

            int untilChristmas = (christmas - today).Days; //Get date diff between dates, use .Days to convert to int
            Console.WriteLine($"There are {untilChristmas} days until Christmas.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("\nWhat is the width?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("\nWhat is the height?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();

        }
    }
}
