namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variable
            int number1, number2, number3, result;

            //input value for number1
            Console.WriteLine("Enter value for number 1:");
            number1 = int.Parse(Console.ReadLine());

            //Input value for number2
            Console.WriteLine("Enter value for number 2:");
            number2 = int.Parse(Console.ReadLine());

            //Input value for number3
            Console.WriteLine("Enter value for number 3:");
            number3 = int.Parse(Console.ReadLine());

            result = number1 * number2 * number3;

            Console.WriteLine("Output : {0} x {1} x {2} = {3}",
                number1, number2, number3, result);

        }
    }
}
