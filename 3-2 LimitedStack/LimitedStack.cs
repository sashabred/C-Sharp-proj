using System;
using System.Collections.Generic;
using System.Linq;

namespace LimitedStack
{
  public class LimitedStack<T> : Stack<T>
  {
    public int Limit { get; private set; }

    public LimitedStack(int limit)
    {
      if (limit < 1)
        throw new Exception("Limit must be more than zero");
      Limit = limit;
    }

    public override void Push(T element)
    {
      if (Size == Limit)
      {
        elements.RemoveAt(0);
      }
      base.Push(element);
    }
  }
}
