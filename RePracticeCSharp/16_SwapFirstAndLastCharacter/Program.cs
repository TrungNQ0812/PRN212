namespace _16_SwapFirstAndLastCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("W3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine("x");
        }

        public static string first_last(string str)
        {
            char first, last;

            first = str[0];
            last = str[str.Length - 1];

            if (str.Length >= 3)
            {
                str.Remove(0, 1);
                str.Remove(str.Length - 2, str.Length - 1);
            }
            else
            {
                return str;
            }

            str.Append(first);
            str = last + str;

            return str;
        }
    }
}
