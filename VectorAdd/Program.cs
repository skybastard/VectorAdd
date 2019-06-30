using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VectorAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first vector magnitude: ");
                double vec1magnitude = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter first vector angle: ");
                double vec1angle = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second vector magnitude: ");
                double vec2magnitude = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second vector angle: ");
                double vec2angle = Convert.ToDouble(Console.ReadLine());

                double vec1X = vec1magnitude * Math.Cos(vec1angle * (Math.PI / 180)); // to deg from radians
                double vec1Y = vec1magnitude * Math.Sin(vec1angle * (Math.PI / 180));
                Vector vector1 = new Vector(vec1X, vec1Y);

                double vec2X = vec2magnitude * Math.Cos(vec2angle * (Math.PI / 180));
                double vec2Y = vec2magnitude * Math.Sin(vec2angle * (Math.PI / 180));
                Vector vector2 = new Vector(vec2X, vec2Y);

                Vector resultVector = new Vector();
                resultVector = Vector.Add(vector1, vector2);

                double resultMagnitude = Math.Sqrt(Math.Pow(resultVector.X, 2) + Math.Pow(resultVector.Y, 2));

                Vector xAxis = new Vector(3, 0);
                double resultAngle = Vector.AngleBetween(xAxis, resultVector);

                Console.WriteLine("\nX and Y components:  " + resultVector);
                Console.WriteLine("Magnitude:  " + resultMagnitude);
                Console.WriteLine("Angle:  " + resultAngle);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);  // catch input errors 
            }



            
            


            Console.ReadLine();
        }
    }
}
