namespace _17_AddFirstCharacterToFrontAndBack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();

            char firstChar = str[0];

            if (str.Length >= 2)
            {
                Console.WriteLine("Result is: ");
                Console.WriteLine(firstChar + str + firstChar);
            }
        }

    }
}
