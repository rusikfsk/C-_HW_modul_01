using System;


namespace C__HW_modul_01
{
    internal class Task_7
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers to set the range:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int start = Math.Min(number1, number2);
            int end = Math.Max(number1, number2);

            if (start % 2 != 0)
            {
                start++; // Если начальное число нечетное, увеличиваем его на 1 для начала с четного числа
            }

            Console.WriteLine($"Even numbers in the range from {start} to {end}:");
            for (int i = start; i <= end; i += 2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
