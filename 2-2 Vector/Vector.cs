using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
  class MyVector
  {
    #region fields
    private double[] values;
    #endregion

    #region constructors
    public MyVector(int size = 0)
    {
      values = new double[size];
    }

    public MyVector(double[] values)
    {
      this.values = values;
    }
    #endregion

    #region properties
    public int Size
    {
      get
      {
        return values.Length;
      }
    }

    public double this[int index]
    {
      //get => GetElementAt(index);
      get
      {
        if (index < 0 || index >= Size)
          return double.NaN;
        return GetElementAt(index);
      }
      set {
        if (index < 0 || index >= Size)
          throw new ArgumentOutOfRangeException();
        SetElementAt(index, value);
      }
    }
    #endregion

    #region public methods
    #region methods for getting and setting elements
    public void Append(double newValue)
    {
      double[] newValues = new double[values.Length + 1];
      for (int i = 0; i < values.Length; i++)
      {
        newValues[i] = values[i];
      }
      newValues[newValues.Length - 1] = newValue;
      values = newValues;
    }

    public double GetElementAt(int index)
    {
      if (index < 0 || index >= values.Length)
      {
        throw new IndexOutOfRangeException("Index is out of vector's range");
      }
      return values[index];
    }

    public void SetElementAt(int index, double value)
    {
      if (index < 0 || index >= values.Length)
      {
        throw new IndexOutOfRangeException("Index is out of vector's range");
      }
      values[index] = value;
    }
    #endregion

    #region methods for overloading operators
    public MyVector Add(MyVector other)
    {
      if (values.Length != other.Size)
      {
        throw new Exception("Vectors have different sizes");
      }
      MyVector resultVector = new MyVector(values.Length);
      for (int i = 0; i < values.Length; i++)
      {
        resultVector.SetElementAt(i, values[i] + other.GetElementAt(i));
      }
      return resultVector;
    }

    public MyVector Add(int iValue)
    {
      MyVector resultVector = new MyVector(values.Length);
      for (int i = 0; i < values.Length; i++)
      {
        resultVector.SetElementAt(i, values[i] + iValue);
      }
      return resultVector;
    }


    //// add Subtract
    public MyVector Subtract(MyVector other)
    {
      if (values.Length != other.Size)
      {
        throw new Exception("Vectors have different sizes");
      }
      MyVector resultVector = new MyVector(values.Length);
      for (int i = 0; i < values.Length; i++)
      {
        resultVector.SetElementAt(i, values[i] - other.GetElementAt(i));
      }
      return resultVector;
    }
    public MyVector Subtract(int iValue)
    {
      MyVector resultVector = new MyVector(values.Length);
      for (int i = 0; i < values.Length; i++)
      {
        resultVector.SetElementAt(i, values[i] - iValue);
      }
      return resultVector;
    }

    public MyVector Multiply(double scalarValue)
    {
      MyVector resultVector = new MyVector(values.Length);
      for (int i = 0; i < values.Length; i++)
      {
        resultVector.SetElementAt(i, values[i] * scalarValue);
      }
      return resultVector;
    }
    //// add Divide
    
    public MyVector Divide (double scalarValue)
    {
      MyVector resultVector = new MyVector(values.Length);
      for (int i = 0; i < values.Length; i++)
      {
        resultVector.SetElementAt(i, values[i] / scalarValue);
      }
      return resultVector;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder("Vector elements are: ");
      for (int i = 0; i < values.Length; i++)
      {
        if (i != 0) sb.Append(", ");
        sb.Append(values[i]);
      }
      return sb.ToString();
    }

    public override int GetHashCode()
    {
      int hash = 0;
      foreach (var value in values)
      {
        hash += value.GetHashCode();
      }
      return hash;
    }

    public override bool Equals(object obj)
    {
      MyVector otherVector = obj as MyVector;
      if (otherVector is null)
        return false;
      if (this.GetHashCode() != obj.GetHashCode())
        return false;
      if (this.Size != otherVector.Size)
        return false;
      for (int i = 0; i < Size; i++)
      {
        if (values[i] != otherVector.GetElementAt(i))
          return false;
      }
      return true;
    }
    #endregion
    #endregion

    #region operators
    public static MyVector operator +(MyVector a, Int32 b)
    {
      return a.Add(b);
    }

    public static MyVector operator + (MyVector a, MyVector b)
    {
      return a.Add(b);
    }

    public static MyVector operator * (MyVector a, double scalar)
    {
      return a.Multiply(scalar);
    }

    public static bool operator == (MyVector a, MyVector b)
    {
      return a.Equals(b);
    }

    public static bool operator != (MyVector a, MyVector b)
    {
      return !(a == b);
    }

    #endregion


  }
}
