using System.Numerics;
using System.Runtime.CompilerServices;

namespace lab2
{
    public static class MatrixOperation<T> where T : INumber<T>
    {
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static T[,] Multiply(T[,] a, T[,] b)
        {
            var aRowCount = a.GetLength(0);
            var aColumnsCount = a.GetLength(1);
            var bRowCount = b.GetLength(0);
            var bColumnsCount = b.GetLength(1);
            
            if (aColumnsCount != bRowCount)
                throw new Exception("Количество столбцов первой матрицы не равно количеству строк второй матрицы");

            var c = new T[aRowCount, bColumnsCount];

            for (int i = 0; i < aRowCount; i++)
            {
                for (int j = 0; j < bColumnsCount; j++)
                {
                    for (int k = 0; k < aColumnsCount; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            
            return c;
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static T[,] Generate(int rowsCount, int columnCount, Func<T> rand)
        {
            var matrix = new T[rowsCount, columnCount];
            for (var i = 0; i < rowsCount; i++)
            {
                for (var j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = rand();
                }
            }

            return matrix;
        }
    }
}