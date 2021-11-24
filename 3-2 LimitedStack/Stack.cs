using System.Collections.Generic;
using System.Linq;

namespace LimitedStack
{
  public class Stack<T>
  {
    protected List<T> elements = new List<T>();

    public int Size => elements.Count;

    public virtual void Push(T element)
    {
      elements.Add(element);
    }

    public virtual T Pop()
    {
      if (Size == 0)
        throw new System.Exception("Stack is Empty");
      T element = elements.Last();
      elements.RemoveAt(Size - 1);
      return element;
    }
  }
}
