// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4:F0}", matrix[i,j]);
        }
        Console.WriteLine();
    }
}

void GetElement(int i, int j, int[,] matrix)
{
    if(i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
    {
        Console.Write(matrix[i-1,j-1]);
    }
    else
    {
        Console.Write("Такого элемента в массиве нет");
    }
}

int[,] matr = GetMatrix(3, 4);
PrintMatrix(matr);
int m = ReadNumber("Введите номер строки");
int n = ReadNumber("Введите номер столбца");
GetElement(m, n, matr);
