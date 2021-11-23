using System;
using System.Collections.Generic;

namespace _1_1_Prime_numbers
{
    class Program
    {
         static void Main(string[] args)
        {
            int num = GetNumFromUser();
            if(num<0)
            {
                Console.WriteLine("Enter number above zero");
            }
            PrimeNums(num).ForEach(Console.WriteLine);
        }

        static int GetNumFromUser()
            {   Console.WriteLine("Enter number");
                string input = Console.ReadLine();
                int num=(int) int.Parse(input);               
                return num;
            }
        public static List<int> PrimeNums(int x) {
         
            List<int> allnums = new List<int> ();
            List<int> primes = new List<int> ();
            for (int i = 2; i<x; i++)
            {
                if(!allnums.Contains(i))  {
                    primes.Add(i);
                    for(int j=i*2; j<x;j+=i){
                        allnums.Add(j);
                    }
                }
            }
            return primes;

        }
    }
}
