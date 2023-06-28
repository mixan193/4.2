using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 4);
            Matrix m2 = new Matrix(3, 4);
            Matrix m3 = Matrix.Addition(m1, m2);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m1.GetMatrix()[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m2.GetMatrix()[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m3.GetMatrix()[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
