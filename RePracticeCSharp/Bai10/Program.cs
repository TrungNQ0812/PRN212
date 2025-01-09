using System;
namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Input value of first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input value of second number:");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input value of third number:");
            number3 = int.Parse(Console.ReadLine());

            int format1 = (number1 + number2) * number3;
            int format2 = number1 * number2 + number2 * number3;

            Console.WriteLine("({0} + {1}) x {2} = {3}", number1, number2, number3, format1);
            Console.WriteLine("{0} x {1} + {1} x {2} = {3}", number1, number2, number3, format2);
        }
    }
}
