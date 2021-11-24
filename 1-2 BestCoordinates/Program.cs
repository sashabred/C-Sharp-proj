using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1_2_BestCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double[]> coordinates = GetCoordinates();
            coordinates.ForEach(Console.WriteLine);
            double sumX, sumY, sumX2, sumXY;
            sumX=0;
            sumY=0;
            sumX2=0;
            sumXY = 0;
            foreach (double[] coord in coordinates) {
                sumX+=coord[0];
                sumY+=coord[1];
                sumX2 += coord[0]*coord[0];
                sumXY += coord[0]*coord[1];
            }
            double n = coordinates.Count;
            double m = (sumXY - ((sumX*sumY)/n))/(sumX2 - ((sumX*sumX)/n));
            double b = sumY/n - m*(sumX/n);
            Console.WriteLine($"y= {m:F3} x + {b:f3}");
            
            
        }
       
        public static List<double[]> GetCoordinates() {
            Console.WriteLine("Enter coords");
            var coords= new List<double[]>();
            while (true) 
            {
                string input = Console.ReadLine();
                if (input == "q") break;
                double[] xAndY = new double[2];
                string[] inputDiv = input.Split(',');
                xAndY[0] = Convert.ToDouble(inputDiv[0].Replace(".", ","));
                xAndY[1] = Convert.ToDouble(inputDiv[1].Replace(".", ","));
                coords.Add(xAndY);
            }
            return coords;
          
        }
    }
}
