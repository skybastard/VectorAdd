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

            
            double vec1magnitude = 36;
            double vec1angle = 123;
            double vec1X = vec1magnitude * Math.Cos(vec1angle * (Math.PI / 180)); // to deg from radians
            double vec1Y = vec1magnitude * Math.Sin(vec1angle * (Math.PI / 180));
            
            Vector vector1 = new Vector(vec1X, vec1Y);

            double vec2magnitude = 83;
            double vec2angle = 57;
            double vec2X = vec2magnitude * Math.Cos(vec2angle * (Math.PI / 180));
            double vec2Y = vec2magnitude * Math.Sin(vec2angle * (Math.PI / 180));

            Vector vector2 = new Vector(vec2X, vec2Y);

            Vector resultVector = new Vector();
            resultVector = Vector.Add(vector1, vector2);

            double resultMagnitude = Math.Sqrt(Math.Pow(resultVector.X, 2) + Math.Pow(resultVector.Y, 2));
            double resultAngle = Math.Atan(resultVector.Y / resultVector.X) * (180 / Math.PI);
            Console.WriteLine("X and Y components:  " + resultVector);
            Console.WriteLine("Magnitude:  " + resultMagnitude);
            Console.WriteLine("Angle:  " + resultAngle);
            


            Console.ReadLine();
        }
    }
}
