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



            Vector vector1 = new Vector(10,20 );
            Vector vector2 = new Vector(8, 90);
            Vector vectorResult = new Vector();

            vectorResult = Vector.Add(vector1, vector2);
            Console.WriteLine(vectorResult);


            Console.ReadLine();
        }
    }
}
