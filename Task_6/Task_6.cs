using System;

namespace C__HW_modul_01
{
    internal class Task_6
    {
        static void Main()
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Convert from Celsius to Fahrenheit");
            Console.WriteLine("2. Convert from Fahrenheit to Celsius");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Error: Invalid operation choice.");
                return;
            }

            double temperature;
            Console.WriteLine("Enter the temperature:");

            if (!double.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Error: Invalid temperature input.");
                return;
            }

            switch (choice)
            {
                case 1:
                    ConvertCelsiusToFahrenheit(temperature);
                    break;
                case 2:
                    ConvertFahrenheitToCelsius(temperature);
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation choice.");
                    break;
            }
        }

        static void ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} degrees Celsius = {fahrenheit} degrees Fahrenheit");
        }

        static void ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit = {celsius} degrees Celsius");
        }
    }
}


