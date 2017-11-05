using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                if (number > 0 && number <= 3999)
                {
                    string roman = ConvertToRoman(number);
                    Console.WriteLine("{0} expressed as Roman numerals is {1}", number, roman);
                }
                else
                {
                    Console.WriteLine("Please enter a number from 1 to 3999!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }

        private static string ConvertToRoman(int number)
        {
            int[] divisors = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "VI", "I" };
            StringBuilder romanNumerals = new StringBuilder();
            int cursor = 0;

            while (number > 0)
            {
                while (number / divisors[cursor] > 0)
                {
                    number -= divisors[cursor];
                    romanNumerals.Append(numerals[cursor]);
                }
                cursor++;
            }

            return romanNumerals.ToString();
        }
    }
}
