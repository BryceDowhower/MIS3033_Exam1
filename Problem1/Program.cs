//Bryce Dowhower Exam 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, single = "";
            int length, finalvalue = 0, workingvalue = 0;
            Console.WriteLine("Please input in a number >>");
            input = Console.ReadLine();
            length = input.Length;
            string[] Numbers = new string[length];
            for (int i = 0; i < length; i++)
            {
                single = input.Substring(i, 1);
                Numbers[i] = single;
            }

            foreach (var character in Numbers)
            {
                //Console.Write(character);
                if (character != "," && character != ".")
                {
                    workingvalue = Convert.ToInt32(character);
                    finalvalue = workingvalue + finalvalue;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"All of the numbers in your input add up to the total value of {finalvalue}.");
            Console.ReadKey();
        }
    }
}
