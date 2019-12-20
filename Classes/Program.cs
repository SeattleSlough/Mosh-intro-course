using System;



namespace Classes
{
    public class Person
    {
       public string FirstName;
       public string LastName;

       public void Introduce()
       {
           System.Console.WriteLine("My name is " + FirstName + " " + LastName);
       } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
