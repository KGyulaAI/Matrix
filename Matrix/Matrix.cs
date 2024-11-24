using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matrix
{
    internal class Matrix
    {
        double[,] matrix;

        public Matrix()
        {
            matrix = new double[3, 3];
        }
        public Matrix(int n)
        {
            matrix = new double[n, n];
        }
        public Matrix(int m, int n)
        {
            matrix = new double[m, n];
        }

        public static Matrix Sum(Matrix A, Matrix B)
        {
            Matrix eredmeny = new Matrix(A.Sorok, A.Oszlopok);
            for (int i = 0; i < A.Sorok; i++)
            {
                for (int j = 0; j < A.Oszlopok; j++)
                {
                    eredmeny.matrix[i, j] = A.matrix[i, j] + B.matrix[i, j];
                }
            }
            return eredmeny;
        }
        public void Fill(double ertek)
        {
            for (int i = 0; i < Sorok; i++)
            {
                for (int j = 0; j < Oszlopok; j++)
                {
                    matrix[i, j] = ertek;
                }
            }
        }
        public override string ToString()
        {
            string eredmeny = "";

            for (int i = 0; i < Sorok; i++)
            {
                for (int j = 0; j < Oszlopok; j++)
                {
                    eredmeny += matrix[i, j];
                }
                eredmeny += "\n";
            }

            return eredmeny;
        }

        public int Oszlopok
        {
            get { return matrix.GetLength(1); }
        }
        public int Sorok
        {
            get { return matrix.GetLength(0); }
        }
    }
}
