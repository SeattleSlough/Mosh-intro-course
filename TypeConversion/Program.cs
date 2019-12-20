using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = a++;
                System.Console.WriteLine(b);
                System.Console.WriteLine(a);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte.");
            }
            
        }
    }
}
