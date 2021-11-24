using System;
using LimitedStack;

namespace _3_2_LimitedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            Stack<BankAccount> bankStack = new Stack<BankAccount>();

            intStack.Push(5);
            intStack.Push(15);
      //Console.WriteLine(intStack.Pop());
      //Console.WriteLine(intStack.Pop());

            intStack = new LimitedStack<int>(1);
            intStack.Push(5);
            intStack.Push(15);
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());

        }
    }
}
