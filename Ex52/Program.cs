// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArrayRndInt (int row, int column, int min, int max)
{
	int[,] matrix = new int[row, column];
	Random rnd = new Random();
	
	for (int i = 0; i < row; i++)
	{
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}, ");
			else Console.Write(matrix[i,j]);
		}
		Console.WriteLine("]");
	}
}

void ColumnMeanValue (int[,] matr)
{
    double[] meanValues = new double[matr.GetLength(1)];
    double meanValue = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
	{
		for (int j = 0; j < matr.GetLength(0); j++)
		{
			meanValue += matr[j,i];
		}
        meanValue /= 3;
        meanValues[i] = Math.Round(meanValue, 1);
        meanValue = 0;
	}
    Console.Write("Среднее арифметическое каждого столбца: ");
    Console.Write(string.Join("; ", meanValues));
    Console.WriteLine(".");
}

int[,] matrix = CreateArrayRndInt(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
ColumnMeanValue(matrix);
