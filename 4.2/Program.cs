using System;

namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 4);
            Matrix m2 = new Matrix(3, 4);
            Matrix m3 = Matrix.Addition(m1, m2);
            WriteMatrix(m1);
            WriteMatrix(m2);
            WriteMatrix(m3);
            Console.ReadKey();

        }

        private static void WriteMatrix(Matrix m)
        {
            for (int i = 0; i < m.GetM(); i++)
            {
                for (int j = 0; j < m.GetN(); j++)
                {
                    Console.Write(m.GetMatrix()[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
