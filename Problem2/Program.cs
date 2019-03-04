using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string model;
            double weight, mpg;
            int engine;
            Console.WriteLine("Please enter in the MODEL of your Ford vehicle >>");
            model = Console.ReadLine();
            Console.WriteLine("Please enter in the WEIGHT (in pounds) of your vehicle >>");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter in what type of engine your vehicle has (V4 | V6 | V8)  >>");
            engine = Convert.ToInt32(Console.ReadLine().Substring(1));
            
            Ford Vehicle = new Ford();

            Vehicle.Model = model;
            Vehicle.Weight = weight;
            Vehicle.Engine = engine;
            mpg = Vehicle.CalculateMPG();
            Console.WriteLine();
            Console.WriteLine("The details of your vehicle are as follows:");
            Console.WriteLine();
            Console.WriteLine($"Model: {Vehicle.Model}");
            Console.WriteLine($"Weight: {Vehicle.Weight}");
            Console.WriteLine($"Engine: V{Vehicle.Engine}");
            Console.WriteLine($"MPG: {mpg} miles to the gallon");
            Console.ReadKey();
        }
    }
}
