namespace _18_CheckNegativeAndPositivePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input first number
            Console.WriteLine("Input first number:");
            int number1 = int.Parse(Console.ReadLine());

            //Input second number
            Console.WriteLine("Input second number:");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > 0 && number2 < 0 || number1 < 0 && number2 > 0) {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
