using System;

namespace _1_3_PentagonSquare
{
    class Program
    {
        static void Main(string[] args)
        {          
           Point[] points = new Point[5];
            points[0] = GetPointFromUser("A");
            points[1] = GetPointFromUser("B");
            points[2] = GetPointFromUser("C");
            points[3] = GetPointFromUser("D");
            points[4] = GetPointFromUser("E");    

            double AB = CalcLineLength(points[0], points[1]);
            double BC = CalcLineLength(points[1], points[2]); 
            double AC = CalcLineLength(points[0], points[2]);

            double AE = CalcLineLength(points[0], points[4]);
            double AD = CalcLineLength(points[0], points[3]);
            double ED = CalcLineLength(points[4], points[3]);

            double CD = CalcLineLength(points[2], points[3]);


            double ABC = CalcTriangleArea(AB, BC, AC);  
            double ADE = CalcTriangleArea(AE, ED, AD);    
            double ACD = CalcTriangleArea(AC, CD, AD);

            double totalArea = ABC+ACD +ADE;
            Console.WriteLine(totalArea);
        }
         public class Point {
               public double X;
               public double Y;
           }
        static double CalcTriangleArea(double side, double side2, double side3) {
               //Formula of Heron
               double p = (side + side2 + side3)/2;
               double square = (p-side)*(p-side2);
               return square;

           }
        static double CalcLineLength(Point point1, Point point2)
           {
               //Distance between points
               double sqrX = Math.Pow(point1.X - point2.X,2);
               double sqrY = Math.Pow(point1.Y - point2.Y,2);
               double sideLength = Math.Sqrt(sqrX +sqrY);
               return sideLength;
           }
        static Point GetPointFromUser(string pointName)
            {
                Console.WriteLine($"Enter coordinates of point {pointName}");
                Point point = new Point();
                string[] inputs = Console.ReadLine().Split(',');
                point.X= double.Parse(inputs[0]);
                point.Y= double.Parse(inputs[1]);
                return point;
            }
    }
}
