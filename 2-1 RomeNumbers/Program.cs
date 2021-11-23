using System;
using System.Collections.Generic;
using System.Text;

namespace _2_1_RomeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            toRomeNumbers();         
        }

        static int userInput() {
            Console.WriteLine("Input num");
            string input = Console.ReadLine();
            int userInp = Int32.Parse(input);
            return userInp;
        }

        static void toRomeNumbers() {
            int input = userInput();
            
            Dictionary<int, string> NumberRomanDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };

            var roman = new StringBuilder();

            foreach (var item in NumberRomanDictionary)
                {
                    while (input >= item.Key)
                    {
                    roman.Append(item.Value);
                    input -= item.Key;
                    }
                }
            Console.WriteLine(roman);

        } 
    }
}
