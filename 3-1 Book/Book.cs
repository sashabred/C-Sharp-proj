using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
  /// <summary>
  /// Info about book.
  /// </summary>
  public class Book : IIncreasedEditionNumber, IComparable
  {
    public string Title { get; set; }
    public string Author { get; set; }

    public int Edition { get; private set; } = 1;

    public bool Comparable(Book book)
        {
            if (book.Author !=this.Author) 
            {
               return false;          
            }
            else if (book.Title != this.Title) {
                return false;
            }

            else {
                return true;
            }

        }

        public int IncreaseEditionNumber()
    {
      return ++Edition;
    }

    //public override string ToString()
    //{
    //  return $"{Title}, edition {Edition}";
    //}
  }
}
