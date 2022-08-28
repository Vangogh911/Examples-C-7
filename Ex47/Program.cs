// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5    7    -2   -0,2
//  1   -3,3    8   -9,9
//  8    7,8  -7,1    9

double[,] CreateArrayRndDouble (int row, int column, double min, double max)
{
	double[,] matrix = new double[row, column];
	Random rnd = new Random();
	
	for (int i = 0; i < row; i++)
	{
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = rnd.NextDouble() * (max - min) + min;
        }
	}
	return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
            double output = Math.Round(matrix[i,j], 1);
			if (j < matrix.GetLength(1) - 1) Console.Write($"{output}, ");
			else Console.Write(output);
		}
		Console.WriteLine("]");
	}
}

double[,] matrix = CreateArrayRndDouble(3, 4, -10, 10);
PrintDoubleMatrix(matrix);
