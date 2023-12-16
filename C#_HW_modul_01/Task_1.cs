using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_01
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (userInput != "q")
            {
                Console.Write("Enter number from 1 to 100 or 'q' to exit: ");
                    userInput = Console.ReadLine();
                if (userInput == "q") 
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                int number;

                if (int.TryParse(userInput, out number))
                {
                    if (number >= 1 && number <= 100)
                    {
                        if(number % 3 == 0 && number % 5 == 0) 
                        {
                            Console.WriteLine("Fizz Buzz");
                        }
                        else if (number % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (number % 5 == 0) 
                        { 
                            Console.WriteLine("Buzz");
                        }
                        else 
                        { 
                            Console.WriteLine(number); 
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Error: Please enter  a valid number or 'q' to exit.");
                    }
                }
            }

        }
    }
}
