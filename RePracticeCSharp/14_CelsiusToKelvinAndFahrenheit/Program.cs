namespace _14_CelsiusToKelvinAndFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius, kelvin, fahrenheit;

            Console.WriteLine("Input value of celsius:");
            celsius = int.Parse(Console.ReadLine());

            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine("Celsius is: " + celsius);
            Console.WriteLine("Kelvin is: " + kelvin);
            Console.WriteLine("Fahrenheit is: " + fahrenheit);
        }
    }
}
