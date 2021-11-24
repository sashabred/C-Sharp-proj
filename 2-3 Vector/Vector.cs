using System;

namespace Vector
{
    public class Vector
    {
        private double[] values;
        private int Size {
            get {
                return values.Length;
            }
        }

        public Vector(int size=0) {
            values = new double[size];
        }
        public double this[int index] {
            get{
                return GetElementById(index);
            }
            set {
                SetElementById(index, value);
            }
        }

        public void Append(double newValue) {
            double[] newValues = new double[values.Length +1];
            for (int i = 0;i<values.Length;i++){
                newValues[i] = values[i];
                }  
            newValues[newValues.Length-1] = newValue;
            values = newValues;
        }

        public double GetElementById(int id) {

            if (id > values.Length || id < 0 ) {
                throw new IndexOutOfRangeException("Выход за пределы массива");
            }
            return values[id];
        }

            public void SetElementById(int id, double value) {

            if (id > values.Length || id < 0 ) {
                throw new IndexOutOfRangeException("Выход за пределы массива");
            }
            values[id] = value;
        }
            public string GetAll() {
                var s = string.Join(", ", values); 
                return s;               
        }

           public Vector Add(Vector other){
               if (values.Length != other.Size) {
                   throw new Exception ("Разные размеры Векторов");
               }
               Vector newVector = new Vector(values.Length);
               for (int i = 0; i<values.Length; i++) {
                   newVector[i] +=other[i];
                   }
                return newVector;
           }

           public Vector Subtract(Vector other){
               if (values.Length != other.Size) {
                   throw new Exception ("Разные размеры Векторов");
               }
                Vector newVector = new Vector(values.Length);
               for (int i = 0; i<values.Length; i++) {
                   newVector.SetElementById(i, values[i]-other[i]);
                   }
                return newVector;
           }
 

    }
}