using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_6_PasswordRandomGenerator
{
    class Program
    {
       static void Main(string[] args)
        {
            getRange();
        } 
        
        static void getRange () {
             Random random = new Random();
             int numberOfDigits = random.Next(1, 7);
            int numberOfLowerLetters = random.Next(1, 8 - numberOfDigits);
                int numberOfUpperLetters = 8 - numberOfDigits - numberOfLowerLetters;

        //1. Создать цифры и буквы в нужном количестве
        List<char> initial = new List<char>();
        for (int j = 0; j < numberOfDigits; j++)
        {
          char zeroChar = '0';
          initial.Add((char)(zeroChar + random.Next(10)));
        }

        for (int j = 0; j < numberOfLowerLetters; j++)
        {
          int zeroChar = 65;
          initial.Add((char)(zeroChar + random.Next(10)));
        }
            for (int j = 0; j < numberOfUpperLetters; j++)
        {
          int zeroChar = 97;
          initial.Add((char)(zeroChar + random.Next(10)));
        }
        //Буквы?

       
        

        //2. Произвольно разместить их на 8 позициях
        List<char> passwordChars = new List<char>();
        passwordChars = initial.OrderBy(a => rng.Next()).ToList();

        Console.WriteLine(string.Join("", passwordChars.GetRange(0, 7)));
        
        //https://stackoverflow.com/questions/273313/randomize-a-listt
        }
        private static Random rng = new Random();  
        
    }
}
