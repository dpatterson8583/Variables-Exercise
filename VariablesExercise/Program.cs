using System.Net.Cache;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   
            string Name = "David";
            int Age = 62;
            char middleInit = 'J';
            bool isRetired = false;
            double yearlySalary = 350000.00;
            decimal monthlyPaycheck = 18500.00m;

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"My name is {Name}");
            Console.WriteLine($"My age is {Age}");
            Console.WriteLine($"Am I retired?   {isRetired}");
            Console.WriteLine($"My middle initial is \"{middleInit}\"");
            Console.WriteLine($"My yearly salary is $" + Convert.ToString(yearlySalary));
            Console.WriteLine($"My monthly paycheck is $" + Convert.ToString(monthlyPaycheck));
        }
    }
}
