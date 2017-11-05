using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Roman numeral: ");
            string input = Console.ReadLine();
            int? number = ConvertToNumber(input);
            if (number != null)
            {
                Console.WriteLine("{0} expressed as a number is {1}", input, number);
            }
            else
            {
                Console.WriteLine("Please enter a valid Roman numeral!");
            }
        }

        private static int? ConvertToNumber(string roman)
        {
            Dictionary<string, int> numerals = new Dictionary<string,int> { { "M", 1000 }, { "D", 500 }, { "C", 100 }, { "L", 50 }, { "X", 10 }, { "V", 5 }, { "I", 1 } };
            int number = 0;
            int position = 0;
            int prevNum = 1000;
            int num;

            while (position < roman.Length)
            {
                string numeral = roman.Substring(position,1).ToUpper();
                if (numerals.ContainsKey(numeral))
                {
                    num = numerals[numeral];
                    if (num <= prevNum)
                    {
                        number += num;
                    }
                    else
                    {   // Account for CM, CD, XC, XL, IX, IV
                        number = number + num - prevNum - prevNum;
                    }
                    prevNum = num;
                }
                else
                {
                    return null;
                }
                position++;
            }

            return number;
        }
    }
}
