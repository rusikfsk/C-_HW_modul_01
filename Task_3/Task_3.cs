using System;


namespace C__HW_modul_01
{
    internal class Task_3
    {
        static void Main(string[] args)
        {
            int[] digits = new int[4]; // Создаем массив для хранения цифр
            int result = 0;

            Console.WriteLine("Enter four numbers:");

            for (int i = 0; i < 4; i++)
            {
                // Читаем цифры с клавиатуры и помещаем их в массив
                digits[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Формируем число из введенных цифр
            for (int i = 0; i < 4; i++)
            {
                result = result * 10 + digits[i];
            }

            Console.WriteLine("A number formed from the entered digits: " + result);
        }
    }
}
