using System;
using System.Collections.Generic;
namespace _15_RemoveCharacterByIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("W3School", 3));
            Console.WriteLine(remove_char("W3School", 2));
        }

        public static string remove_char(string str, int index)
        {
            return str.Remove(index, 1);
        }
    }
}
