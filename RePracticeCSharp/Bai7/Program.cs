using System;
namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            int number1, number2;

            //Input value for number1
            Console.WriteLine("Enter value for number1:");
            number1 = int.Parse(Console.ReadLine());

            //Input value for number2
            Console.WriteLine("Enter value for number2:");
            number2 = int.Parse(Console.ReadLine());

            // Addition operation
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        
            // Subtraction operation
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
        
            // Multiple operation
            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);

            // Division operation
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);

            // Modulus operation
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);
        }
    }
}
