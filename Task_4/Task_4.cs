using System;


namespace C__HW_modul_01
{
    internal class Task_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number: ");
            string userInput = Console.ReadLine();

            if (userInput.Length != 6 || !int.TryParse(userInput, out _))
            {
                Console.WriteLine("Error: You must enter a six-digit number.");
                return;
            }

            Console.WriteLine("Enter the digit numbers for exchange (for example, 1 and 6)");
            string positionsInput = Console.ReadLine();
            string[] positions = positionsInput.Split(' ');

            if (positions.Length != 2 || !int.TryParse(positions[0], out _) || !int.TryParse(positions[1], out _))
            {
                Console.WriteLine("Error: Incorrect entry of digit numbers.");
                return;
            }

            int position1 = int.Parse(positions[0]);
            int position2 = int.Parse(positions[1]);

            if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
            {
                Console.WriteLine("Error: The digit number must be from 1 to 6.");
                return;
            }

            char[] digits = userInput.ToCharArray();

            // Обмен цифр местами
            char temp = digits[position1 - 1];
            digits[position1 - 1] = digits[position2 - 1];
            digits[position2 - 1] = temp;

            string result = new string(digits);
            Console.WriteLine("Result of digit exchange: " + result);
        }
    }
}
