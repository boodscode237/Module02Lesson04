using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            // ageText += 10;
            //
            // Console.WriteLine($"You are going to be {ageText} years old in 10 years.");

            // int age = int.Parse(ageText);

            bool isValisdAge = int.TryParse(ageText, out int age);

            // if (isValisdAge)
            // {
            //     age += 10;
            //
            //     Console.WriteLine($"You are going to be {age} years old in 10 years."); 
            // }
            // else
            // {
            //     Console.WriteLine("That was not a valid age");
            // }

            if (isValisdAge)
            {
                if (2022 - age > 2000)
                {
                    Console.WriteLine("You weren't born yet in 2000");
                }
                else
                {
                    Console.WriteLine($"You were born before or in the year 2000 and your age was {2000 - (2022 - age)}");
                }
            }

            Console.ReadLine();
        }
    }
}
