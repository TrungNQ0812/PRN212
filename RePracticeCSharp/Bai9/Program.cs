using System;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, number4;

            Console.WriteLine("Input value of number 1:");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input value of number 2:");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input value of number 3:");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input value of number 4:");
            number4 = Convert.ToDouble(Console.ReadLine());

            double total = number1 + number2 + number3 + number4;

            double average = total / 4;

            Console.WriteLine("average is: ({0} + {1} + {2} + {3}) / 4 = {4}", number1, number2, number3, number4, average);
        }
    }
}
