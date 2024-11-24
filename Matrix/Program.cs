namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Matrix matrix2 = new Matrix(5);
            Matrix matrix3 = new Matrix(6, 7);

            matrix.Fill(1);
            matrix2.Fill(5);
            matrix3.Fill(8);

            Console.WriteLine(matrix);
            Console.WriteLine(matrix2);
            Console.WriteLine(matrix3);
            Console.WriteLine(Matrix.Sum(matrix, matrix2));
        }
    }
}
