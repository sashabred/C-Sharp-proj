using System;

namespace _1_4_QueenMove
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var moves = GetUserInput();
            if (!IsCorrect(moves.Item1, moves.Item2)){
                Console.WriteLine("Не верный ход");
            }
            else{
            Console.WriteLine("Верный ход");}
           
        }
         public static Tuple<string,string> GetUserInput()
            {
                Console.WriteLine("Введите ход ферзя в формате: 'е2-е4'");
                string[] input = Console.ReadLine().Split('-');
                string moveOld = input[0];
                string moveNew = input[1];
                return Tuple.Create(moveOld, moveNew);
            }

   
        public static bool IsCorrect(string moveOld, string moveNew)
            {
              
                int d1 = char.ToUpper(moveOld[0]) - char.ToUpper(moveNew[0]);
               
                int d2 = int.Parse(moveOld[1].ToString()) - int.Parse(moveNew[1].ToString());
                return (d1 == d2 || d1 == 0 || d2 == 0 && moveOld != moveNew);
            }
    }
    
}
