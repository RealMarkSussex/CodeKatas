using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas._4Kyu
{
    class MatrixDeterminant
    {
        public static int Determinant(int[][] matrix)
        {
            if (matrix.Length == 1)
            {
                return matrix[0][0];
            }

            var result = 0;
            var matrixSize = matrix[0].Length;
            for (var i = 0; i < matrixSize; i++)
            {
                for (var j = 0; j < matrixSize; j++)
                {
                    if (j % 2 == 0)
                    {
                        result += Result(matrix, i, j);
                    }
                    else
                    {
                        result -= Result(matrix, i, j);
                    }
                }
            }

            return result;
        }

        private static int Result(int[][] matrix, int i, int j)
        {
            var determinant = Determinant(matrix.Where((arr, k) => k != i) //skip row#i
                .Select(arr => arr.Where((item, k) => k != j) //skip col#j
                    .ToArray())
                .ToArray());
            var value = matrix[0][j];
            return value * determinant;
        }
    }
}
