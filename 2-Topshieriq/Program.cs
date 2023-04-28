
using _2_Topshieriq;

double[,] randomMatrix = new double[9, 9];

for (int i = 0; i < randomMatrix.GetLength(0); i++)
{
    for (int j = 0; j < randomMatrix.GetLength(1); j++)
    {
        randomMatrix[i, j] = Math.Round(Random.Shared.NextDouble() * 100, 2);
    }
}

MatrixOperations.ShowMatrix(randomMatrix);

Console.WriteLine("\n\n");

var newMatrix = MatrixOperations.Transform(randomMatrix);
MatrixOperations.ShowMatrix(newMatrix);
Console.ReadKey();