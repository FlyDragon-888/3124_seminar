// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int ReadNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetMatrix()
{
    int[,,] matrix = new int[2, 2, 2];
    Console.WriteLine("Введите неповторяющиеся двузначные числа:");
    int[] r = new int[8];
    int s = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                bool n = true;
                while(n)
                {
                    n = false;
                    matrix[i,j,k] = ReadNumber();
                    if(matrix[i,j,k] > 9 && matrix[i,j,k] < 100)
                    {
                        for(int z = 0; z < s; z++)
                        {
                            if(matrix[i,j,k] == r[z])
                            {
                                Console.WriteLine("Введите неповторяющиеся числа:");
                                n = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        n = true;
                        Console.WriteLine("Введите двузначные числа:");
                    }
                }
                r[s] = matrix[i,j,k];
                s += 1;
            }
        }
    }
    Console.WriteLine();
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i,j,k]}({i},{j},{k})");
            }
        }
    }
}

int[,,] matr = GetMatrix();
PrintMatrix(matr);