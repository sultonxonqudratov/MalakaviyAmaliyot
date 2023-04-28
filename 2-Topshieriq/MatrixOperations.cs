using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2_Topshieriq;

public class MatrixOperations
{
    public static T[,] Transform<T>(T[,] matrix) where T : IComparable, IComparable<T>, IEquatable<T>, IFormattable
    {
        int n = (int)Math.Sqrt(matrix.Length);
        if (n * n != matrix.Length) throw new ArgumentException("The given matrix is not required format");
        T[] diagonal = new T[n];
        var result = new T[n,n];
        for (int i = 0; i < n; i++)
        {
            diagonal[i] = matrix[i, i];
        }
        for (int i = 0; n > i; i++) 
        for (int j = 0; j < n; j++)
        {
            result[i,j] = i ==j || diagonal[i].CompareTo(matrix[i,j]) == 1  ? matrix[i,j]: default(T);
        }
        return result;
    }

    public static void ShowMatrix<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + GetWhiteSpace(8 - matrix[i, j].ToString().Length));
            }
            Console.WriteLine();
        }
    }

    private static string GetWhiteSpace(int count = 0)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append(' ');
        }
        return sb.ToString();
    }
}
