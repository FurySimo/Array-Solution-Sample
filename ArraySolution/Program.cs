using System;
using System.Linq;

namespace ArraySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colours = { "Red", "Green", "Blue", "Yellow" };
            int[] numbers1 = { 10, 20, 30, 40 };
            int[] numbers2 = { 50, 60, 70, 80 };
            Console.WriteLine("Accessing an element:");
            Console.WriteLine(colours[0]);
            Console.WriteLine("Changing an element:");
            colours[0] = "Violet";
            Console.WriteLine(colours[0]);
            Console.WriteLine("Length of Array:");
            Console.WriteLine(colours.Length);
            Console.WriteLine("Displaying elements of arrays by loop:");
            for (int i = 0; i < colours.Length; i++)
            { Console.WriteLine(colours[i]);}
            Console.WriteLine("Displaying elements of arrays by foreach:");
            foreach (string i in colours) 
            { Console.WriteLine(i); }
            Console.WriteLine("Sorting Arrays:");
            Array.Sort(colours);
            foreach (string i in colours)
            { Console.WriteLine(i); }
            Array.Sort(numbers1);
            foreach (int i in numbers1)
            { Console.WriteLine(i); }
            Console.WriteLine("Max,Min and Sum of Arrays:");
            Console.WriteLine("Max:") ;
            Console.WriteLine(numbers1.Max());
            Console.WriteLine("Min:");
            Console.WriteLine(numbers1.Min());
            Console.WriteLine("Sum:");
            Console.WriteLine(numbers1.Sum());


        }
    }
}
