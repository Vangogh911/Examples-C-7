// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void ShowMatrixElement (int[,] matr)
{
    Console.WriteLine("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введите номер столбца: ");
    int col = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine();
    if (row < matr.GetLength(0) && col < matr.GetLength(1))
    {
        Console.WriteLine($"Значение элемента = {matr[row, col]}");
    }
    else Console.WriteLine("Введенный индекс находится за пределами массива");
}

int[,] matrix = CreateArrayRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ShowMatrixElement(matrix);
