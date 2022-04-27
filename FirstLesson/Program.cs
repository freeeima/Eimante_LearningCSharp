using System;

namespace FirstLesson
{
    class Program
    {
        static void Main()
        {
            
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter a number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double y = Convert.ToDouble(Console.ReadLine());
            double sum;
            sum = calculator.Add(x, y);
            Console.WriteLine("The sum of two numbers is:");
            Console.WriteLine(sum);
            
        }
    }
}
