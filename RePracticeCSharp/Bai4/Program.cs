using System;
namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;

            //display promt enter number1's value for user
            Console.WriteLine("Enter value for number 1:");
            //user enter value for number 1
            number1 = int.Parse(Console.ReadLine());

            //Display promt enter number2's value for user
            Console.WriteLine("Enter value for number 2:");
            //user enter value for number 2
            number2 = int.Parse(Console.ReadLine());

            //before swap value
            Console.WriteLine("Value of number 1 is " + number1);
            Console.WriteLine("Value of number 2 is " + number2);

            //swap value of two number
            temp = number1;
            number1 = number2;
            number2 = temp;

            //after swap value
            Console.WriteLine("Value of number 1 is " + number1);
            Console.WriteLine("Value of number 2 is " + number2);


        }
    }
}
