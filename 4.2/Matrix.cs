using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Matrix
    {
        private int m, n;
        private int[,] matrix;
        private static Random random = new Random();

        public Matrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            matrix = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(999);
                }
            }
        }

        public int[,] GetMatrix()
        {
            return matrix;
        }

        public int GetN() 
        {
            return n;
        }
        
        public int GetM() 
        {
            return m; 
        }

        public static Matrix Addition(Matrix matrix1, Matrix matrix2)
        {
            if(!(matrix1.m == matrix2.m && matrix1.n == matrix2.n))
            {
                Console.WriteLine("У матриц разный размер");
                return null;
            }
            Matrix result = new Matrix(matrix1.m, matrix1.n);
            for(int i = 0; i < matrix1.m; i++)
            {
                for(int j = 0; j < matrix1.n; j++)
                {
                    result.matrix[i, j] = matrix1.matrix[i, j] + matrix2.matrix[i, j];
                }
            }
            return result;
        }
    }
}
