using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;

            var flags = new bool[3];
            System.Console.WriteLine(flags[0]);

            var names = new string[] {"jack", "john", "mary"};

            foreach (string name in names)
            {
                System.Console.WriteLine(name);
            }
            
        }
    }
}
