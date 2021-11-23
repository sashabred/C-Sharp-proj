using System;

namespace Book
{
  class Program
  {
    static void Main(string[] args)
    {
      Book warAndPeace = new Book { Title = "War and Peace" };
      Book warAndPeace2 = new Book { Title = "War and Peace" };
      warAndPeace.Author = "Lev Tolstoy";
      warAndPeace2.Author = "Lev Tolstoy";
      Console.WriteLine(warAndPeace);
      warAndPeace.IncreaseEditionNumber();
      Console.WriteLine(warAndPeace);
      IIncreasedEditionNumber withVersion = warAndPeace;
     Console.WriteLine(warAndPeace.Comparable(warAndPeace2));
      IIncreasedEditionNumber[] collection = { withVersion, warAndPeace };
      Console.WriteLine(warAndPeace.Author);
    }
  }
}
