using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";
            var lastName = "Maggs";

            var name = string.Format("{0} {1}", firstName, lastName);

            var names = new string[3] {"john", "jack", "mary"};
            var formattedNames = string.Join(",", names);
            System.Console.WriteLine(formattedNames);
        }
    }
}
