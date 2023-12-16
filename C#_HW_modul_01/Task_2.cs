using System;


namespace C__HW_modul_01
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter persent: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            double result = (percent / 100 ) * number;

            Console.WriteLine($"{percent}% of {number} = {result}");
        }
    }
}